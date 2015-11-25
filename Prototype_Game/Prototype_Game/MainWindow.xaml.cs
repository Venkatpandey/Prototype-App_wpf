using System;
using System.Collections.Generic;
using System.IO;
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
        public List<string> playedWords = new List<string>();

        public int PlayerScore { get; set; }
        public int PlayerPoints { get; set; }
        public int SystemScore { get; set; }
        public int SystemPoints { get; set; }

        Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            //new GameSettings();
            txtHistory.Text = string.Empty;
            string newWord = game.gameInitiator();
            string retSysWord = playedWord(newWord);
            txtHistory.Text += "            System Word: " + retSysWord + Environment.NewLine;
        }

        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
            string userWord = txtReturn.Text;

            playuser(userWord);

            txtReturn.Text = string.Empty;
        }

        private void saveWords_Click(object sender, RoutedEventArgs e)
        {
            //string fileloc = @"C:\Users\pande\Documents\GitHub\Prototype-App_wpf\Prototype_Game\Prototype_Game\bin\Debug\SaveWords.txt";
            //StreamWriter file = new System.IO.StreamWriter(fileloc);
            string filename = DateTime.Now.ToString("yyyy-dd-M-HH-mm-ss");
            FileStream fs = new FileStream(filename, FileMode.CreateNew);
            StreamWriter file = new StreamWriter(fs);
            playedWords.ForEach(file.WriteLine);

            file.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            string msg = " World Building Game.\n Developed By Venkat Raman Pandey.\n ENJOY..!!";
            MessageBox.Show(msg, "About");
        }

        private void newGame_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        public void playuser(string word)
        {
            if (word.Length == 0)
            {
                txtHistory.Text += "Enter a Word: " + Environment.NewLine;
            }

            else
            {
                string retWord = wordPlayedByUser(word.ToLower());
                //string wordo = gamerule.playedWord();
                txtHistory.Text += "User Word: " + retWord + Environment.NewLine;
                if (retWord != "")
                {
                    playSystem(retWord);
                }
            }
        }

        public void playSystem(string retWord)
        {
            string systemWord = game.getReply(retWord);
            string retSysWord = playedWord(systemWord.ToLower());
            txtHistory.Text += "            System Word: " + retSysWord + Environment.NewLine;
        }

        private void txtReturn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public string playedWord(string word)
        {
            if (playedWords.Contains(word))
            {
                txtHistory.Text += "Word already Played..!" + Environment.NewLine;
            }
            else
            {
                playedWords.Add(word);

            }

            return word;
        }

        public string wordPlayedByUser(string word)
        {
            string lastEntry = playedWords.Last();
            string lastAlphabet = lastEntry[lastEntry.Length - 1].ToString();

            if (word.StartsWith(lastAlphabet) == false)
            {

                word = string.Empty;

                txtHistory.Text += "Please enter another valid word..!" + Environment.NewLine;
            }

            else if (playedWords.Contains(word))
            {

                word = string.Empty;

                txtHistory.Text += "Word already Played..!" + Environment.NewLine;
            }
            else
            {
                playedWords.Add(word);

            }

            return word;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
