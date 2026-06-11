using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            if (radioMajor.IsChecked == true)
            {
                MajorDeck majorDeck = new MajorDeck();
                majorDeck.FillDeck();

                System.Diagnostics.Debug.WriteLine(majorDeck.PullCards(1)[0].name);
            }
            else if (radioMinor.IsChecked == true) 
            {
                MinorDeck minorDeck = new MinorDeck();
                minorDeck.FillDeck();

                System.Diagnostics.Debug.WriteLine(minorDeck.PullCards(1)[0].name);
            }
            else
            {
                FullDeck fullDeck = new FullDeck();
                fullDeck.FillDeck();

                System.Diagnostics.Debug.WriteLine(fullDeck.PullCards(1)[0].name);
            }
        }

        
    }
}