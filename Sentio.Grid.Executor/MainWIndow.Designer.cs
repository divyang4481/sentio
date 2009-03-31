namespace Sentio.Grid.Executor
{
    partial class MainWIndow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commandInput = new System.Windows.Forms.TextBox();
            this.ConsoleTxt = new System.Windows.Forms.TextBox();
            this.execCommandBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sentio.Grid.Executor.Properties.Resources.toolbar_bg;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sentio.Grid.Executor.Properties.Resources.sentio_platform_tag;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // commandInput
            // 
            this.commandInput.BackColor = System.Drawing.Color.Gray;
            this.commandInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.commandInput.Location = new System.Drawing.Point(0, 0);
            this.commandInput.Name = "commandInput";
            this.commandInput.Size = new System.Drawing.Size(644, 25);
            this.commandInput.TabIndex = 1;
            // 
            // ConsoleTxt
            // 
            this.ConsoleTxt.BackColor = System.Drawing.Color.DimGray;
            this.ConsoleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTxt.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ConsoleTxt.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTxt.Multiline = true;
            this.ConsoleTxt.Name = "ConsoleTxt";
            this.ConsoleTxt.ReadOnly = true;
            this.ConsoleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleTxt.Size = new System.Drawing.Size(644, 178);
            this.ConsoleTxt.TabIndex = 2;
            // 
            // execCommandBtn
            // 
            this.execCommandBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.execCommandBtn.Location = new System.Drawing.Point(569, 0);
            this.execCommandBtn.Name = "execCommandBtn";
            this.execCommandBtn.Size = new System.Drawing.Size(75, 25);
            this.execCommandBtn.TabIndex = 3;
            this.execCommandBtn.Text = ">";
            this.execCommandBtn.UseVisualStyleBackColor = true;
            this.execCommandBtn.Click += new System.EventHandler(this.execCommandBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.execCommandBtn);
            this.panel2.Controls.Add(this.commandInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 25);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ConsoleTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 178);
            this.panel3.TabIndex = 5;
            // 
            // MainWIndow
            // 
            this.AcceptButton = this.execCommandBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 233);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWIndow";
            this.Text = "Sentio Grid Platform";
            this.Load += new System.EventHandler(this.MainWIndow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox commandInput;
        private System.Windows.Forms.Button execCommandBtn;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.TextBox ConsoleTxt;
        private System.Windows.Forms.Panel panel3;
    }
}

