using System.Diagnostics;
using System.Drawing;
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
using Image = System.Windows.Controls.Image;

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

        private int GetSelectedNumber()
        {
            int numToGenerate = 0;

            if (radio1.IsChecked == true)
            {
                numToGenerate = 1;
            }
            else if (radio2.IsChecked == true)
            {
                numToGenerate = 2;
            }
            else if (radio3.IsChecked == true)
            {
                numToGenerate = 3;
            }
            else if (radio4.IsChecked == true)
            {
                numToGenerate = 4;
            }
            else if (radio5.IsChecked == true)
            {
                numToGenerate = 5;
            }
            else if (radio6.IsChecked == true)
            {
                numToGenerate = 6;
            }
            else if (radio7.IsChecked == true)
            {
                numToGenerate = 7;
            }
            else if (radio8.IsChecked == true)
            {
                numToGenerate = 8;
            }
            else if (radio9.IsChecked == true)
            {
                numToGenerate = 9;
            }
            else
            {
                numToGenerate = 10;
            }
            return numToGenerate;
        }

        private void Show_Cards(int Number, List<Card> ChosenCards)
        {
            switch (Number)
            {
                case 1:
                    oneListBox.Visibility = Visibility.Visible;

                    String imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";

                    oneListBox.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {

            if (radioMajor.IsChecked == true)
            {
                MajorDeck majorDeck = new MajorDeck();
                majorDeck.FillDeck();

                int selectedNum = GetSelectedNumber();
                List<Card> generatedCards = majorDeck.PullCards(selectedNum);

                Show_Cards(selectedNum, generatedCards);
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