namespace Sentio.Grid.Executor.Commands
{
    [Command(Name="quit")]
    class Quit : ICommand
    {
        public string Execute(string input)
        {
            // quick and dirty.
            // w nastepnej iteracji zmienimy to, zeby sprawdzal czy nic sie nie wykonuje, 
            // jezeli sie nie wykonuje to ok, zamykamy, przy czym informujemy serwer o tym
            // a jezeli wykonuje to pokazujemy liste procesow razem z menagerem procesow.
            System.Windows.Forms.Application.Exit();
            return "Bye bye.";
        }
    }
}
