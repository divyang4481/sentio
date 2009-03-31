using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using Sentio.Grid.Executor.Commands;

namespace Sentio.Grid.Executor
{
    public partial class MainWIndow : Form
    {
        protected Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
        protected Stack<string> history = new Stack<string>();


        public MainWIndow()
        {
            InitializeComponent();
            commandInput.KeyDown += new KeyEventHandler(commandInput_KeyDown);
        }

        void commandInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (history.Count != 0)
                    commandInput.Text = history.Pop();
            }
        }

        

        private void execCommandBtn_Click(object sender, EventArgs e)
        {
            WriteLine(" > " + commandInput.Text);
            history.Push(commandInput.Text);
            string fullCmdText = commandInput.Text;
            string[] cmdChunks = fullCmdText.Split(' ');
            if (cmdChunks.Length > 0)
            {
                if (commands.Keys.Contains(cmdChunks[0].Trim()))
                {
                    try
                    {
                        WriteLine(commands[cmdChunks[0].Trim()].Execute(fullCmdText));
                    }
                    catch(Exception ex)
                    {
                        WriteLine("Error: " + ex.Message);
                    }
                }
                else
                    WriteLine(String.Format(Messages.UnkonwnCommand, cmdChunks[0].Trim()));
            }
            commandInput.Text = "";
            commandInput.Focus();
        }

        private void MainWIndow_Load(object sender, EventArgs e)
        {
            Write("Loading environment...");
            Thread loadEnvironmentThread = new Thread(delegate()
                                                          {
                                                              foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                                                              {
                                                                  object[] temp =
                                                                      t.GetCustomAttributes(typeof (CommandAttribute),
                                                                                            false);
                                                                  if (temp.Length != 0)
                                                                  {
                                                                      CommandAttribute cmdAttrib =
                                                                          (CommandAttribute) temp[0];
                                                                      if (cmdAttrib != null)
                                                                      {
                                                                          ICommand cmd =
                                                                              (ICommand)
                                                                              t.InvokeMember(t.FullName,
                                                                                             BindingFlags.CreateInstance,
                                                                                             null, null, null);
                                                                          lock (commands)
                                                                          {
                                                                              commands.Add(cmdAttrib.Name, cmd);
                                                                          }
                                                                      }
                                                                  }
                                                              }
                                                              WriteLine("done");
                                                          });
            loadEnvironmentThread.Start();

            commandInput.Focus();
        }

        public void Write(string text)
        {
            if(ConsoleTxt.InvokeRequired)
                ConsoleTxt.Invoke(new MethodInvoker(delegate { 
                    ConsoleTxt.Text += text;
                    ConsoleTxt.Select(ConsoleTxt.Text.Length - 1, 0); 
                    ConsoleTxt.ScrollToCaret(); }));
            else
                ConsoleTxt.Text += text;
        }

        public void WriteLine(string text)
        {
            Write(text + Environment.NewLine);
        }

    }
}
