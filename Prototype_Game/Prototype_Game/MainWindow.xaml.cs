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
        DictionaryLoader dictLoader = new DictionaryLoader();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
            List<string> xletters = dictLoader.xEntries();
            List<string> aletters = dictLoader.aEntries();
            List<string> bletters = dictLoader.bEntries();
            List<string> cletters = dictLoader.cEntries();
            List<string> dletters = dictLoader.dEntries();
            List<string> eletters = dictLoader.eEntries();
            List<string> fletters = dictLoader.fEntries();
            List<string> gletters = dictLoader.gEntries();
            List<string> hletters = dictLoader.hEntries();
            List<string> iletters = dictLoader.iEntries();
            List<string> jletters = dictLoader.jEntries();
            List<string> kletters = dictLoader.kEntries();
            List<string> lletters = dictLoader.lEntries();
            List<string> mletters = dictLoader.mEntries();
            List<string> nletters = dictLoader.nEntries();
            List<string> oletters = dictLoader.oEntries();
            List<string> pletters = dictLoader.pEntries();
            List<string> qletters = dictLoader.qEntries();
            List<string> rletters = dictLoader.rEntries();
            List<string> sletters = dictLoader.sEntries();
            List<string> tletters = dictLoader.tEntries();
            List<string> uletters = dictLoader.uEntries();
            List<string> vletters = dictLoader.vEntries();
            List<string> wletters = dictLoader.wEntries();
            List<string> yletters = dictLoader.yEntries();
            List<string> zletters = dictLoader.zEntries();
            


            string match = "Xenomi";

            var x = xletters.Find(mm => mm == match);

            txtReturn.Text += x;
        }
    }
}
