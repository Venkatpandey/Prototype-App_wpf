using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prototype_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game = new Game();
        GameRules gamerule = new GameRules();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
           
            string userWord = txtReturn.Text;
            string retWord = gamerule.wordPlayedByUser(userWord.ToLower());
            txtHistory.Text += "User Word: " + retWord + Environment.NewLine;
            //game.playedWord(userWord.ToLower());

            string systemWord = game.getReply(retWord);
            string retSysWord = gamerule.playedWord(systemWord.ToLower());
            txtHistory.Text += "            System Word: " + retSysWord + Environment.NewLine;
            
            //game.playedWord(systemWord.ToLower());
            //var x = xletters.Find(mm => mm == match);

            txtReturn.Text = string.Empty;
        }

        private void txtReturn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void newGame_Click(object sender, RoutedEventArgs e)
        {
            string newWord = game.gameInitiator();
            string retSysWord = gamerule.playedWord(newWord);
            txtHistory.Text += "            System Word: " + retSysWord + Environment.NewLine;
            
        }

    }
}
