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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;


namespace XML_Serial_Deserial
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\Users\venkat\Documents\GitHub\WPF_XML_Serial_Deserial\WPF_XML_Serial_Deserial\WPF_XML_Serial_Deserial\bin\Debug";
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Movie movie = new Movie();
                movie.Title = "Star Trek";
                movie.Plot = "Find mysterious planets..";
                XmlSave.SaveData(movie, saveFileDialog.FileName);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            XmlLoad<Movie> loadMovie = new XmlLoad<Movie>();

            movie = loadMovie.LoadData("test.xml");
            textBoxTitle.Text = movie.Title;
            textBoxPlot.Text = movie.Plot;
        }
    }

     public class Movie
    {
        private string title;
        private string plot;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Plot
        {
            get { return plot; }
            set { plot = value; }
        }
    }
}