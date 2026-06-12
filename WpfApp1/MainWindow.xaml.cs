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

        private void Button_Click(object sender, EventArgs e)
        {

            if (radioMajor.IsChecked == true)
            {
                MajorDeck majorDeck = new MajorDeck();
                majorDeck.FillDeck();

                String imagePathName = "pack://application:,,,/WpfApp1;component/images/" + majorDeck.PullCards(1)[0].name + ".png";
                
                Image img = new Image();

                System.Diagnostics.Debug.WriteLine(listBox.Items.Count, majorDeck.PullCards(1)[0].name);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.UriSource = new Uri(imagePathName);

                img.Source = bitmapImage;


                listBox.Items.Clear();

                listBox.Items.Add(img);
                


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