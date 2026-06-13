using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;
using Path = System.IO.Path;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected static bool savesOpen = false;
        protected bool alreadySaved = false;
        protected List<Card> currentCards = new List<Card>();
        protected List<bool> reversals = new List<bool>();

        static Random rand = new Random();

        public bool SavesOpen
        { 
            get
            {
                return savesOpen;
            }
            set
            {
                savesOpen = value;
            }
        }

        

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

        private void Hide_Menus()
        {
            oneListBox.Visibility = Visibility.Collapsed;
            twoListBox.Visibility = Visibility.Collapsed;
            threeListBox.Visibility = Visibility.Collapsed;
            fourListBox.Visibility = Visibility.Collapsed;
            fiveListBox.Visibility = Visibility.Collapsed;
            sixListBox.Visibility = Visibility.Collapsed;
            sevenListBox.Visibility = Visibility.Collapsed;
            eightListBox.Visibility = Visibility.Collapsed;
            nineListBox.Visibility = Visibility.Collapsed;
            tenListBox.Visibility = Visibility.Collapsed;
        }

        private void Show_Cards(int Number, List<Card> ChosenCards)
        {
            alreadySaved = false;
            Hide_Menus();

            reversals.Clear();

            if (ReversalsInclusion.IsChecked == true)
            {
                for (int i = 0; i < ChosenCards.Count; i++)
                {
                    int r = rand.Next(2);
                    if (r == 0)
                    {
                        reversals.Add(true);
                    }
                    else { 
                        reversals.Add(false); 
                    }
                }
            }
            else
            {
                for (int i = 0; i < ChosenCards.Count; i++)
                {
                    reversals.Add(false);
                }
            }

            switch (Number)
            {
                case 1:
                    oneListBox.Visibility = Visibility.Visible;

                    String imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";

                    oneListBox.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        oneListBox.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        oneListBox.RenderTransform = rotateTransform;
                    }
                    break;
                case 2:
                    twoListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Two_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Two_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Two_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Two_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Two_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Two_Two.RenderTransform = rotateTransform;
                    }
                    break;
                case 3:
                    threeListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Three_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Three_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Three_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Three_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Three_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Three_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Three_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Three_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Three_Three.RenderTransform = rotateTransform;
                    }

                    break;
                case 4:
                    fourListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Four_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Four_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Four_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Four_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Four_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Four_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Four_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Four_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Four_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Four_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Four_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Four_Four.RenderTransform = rotateTransform;
                    }
                    break;
                case 5:
                    fiveListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Five_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Five_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Five_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Five_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Five_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Five_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Five_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Five_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Five_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Five_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Five_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Five_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Five_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Five_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Five_Five.RenderTransform = rotateTransform;
                    }
                    break;
                case 6:
                    sixListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Six_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Six_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Six_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Six_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Six_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_Five.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Six_Six.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[5] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Six_Six.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Six_Six.RenderTransform = rotateTransform;
                    }
                    break;
                case 7:
                    sevenListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Seven_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Seven_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Seven_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Seven_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Seven_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Five.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Seven_Six.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[5] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Six.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Six.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Seven_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[6] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Seven_Seven.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Seven_Seven.RenderTransform = rotateTransform;
                    }
                    break;
                case 8:
                    eightListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Eight_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Eight_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Eight_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Eight_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Eight_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Five.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Eight_Six.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[5] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Six.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Six.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Eight_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[6] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Seven.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Seven.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Eight_Eight.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[7] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Eight_Eight.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Eight_Eight.RenderTransform = rotateTransform;
                    }
                    break;
                case 9:
                    nineListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Nine_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Nine_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Nine_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Nine_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Nine_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Five.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Nine_Six.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[5] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Six.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Six.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Nine_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[6] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Seven.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Seven.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Nine_Eight.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[7] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Eight.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Eight.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[8].name + ".png";
                    Nine_Nine.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[8] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Nine_Nine.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Nine_Nine.RenderTransform = rotateTransform;
                    }
                    break;
                case 10:
                    tenListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Ten_One.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[0] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_One.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_One.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Ten_Two.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[1] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Two.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Two.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Ten_Three.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[2] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Three.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Three.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Ten_Four.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[3] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Four.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Four.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Ten_Five.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[4] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Five.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Five.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Ten_Six.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[5] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Six.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Six.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Ten_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[6] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Seven.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Seven.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Ten_Eight.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[7] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Eight.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Eight.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[8].name + ".png";
                    Ten_Nine.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[8] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Nine.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Nine.RenderTransform = rotateTransform;
                    }

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[9].name + ".png";
                    Ten_Ten.Source = new BitmapImage(new Uri(imagePathName));

                    if (reversals[9] == true)
                    {
                        var rotateTransform = new RotateTransform(180);
                        Ten_Ten.RenderTransform = rotateTransform;
                    }
                    else
                    {
                        var rotateTransform = new RotateTransform(0);
                        Ten_Ten.RenderTransform = rotateTransform;
                    }
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
                currentCards = generatedCards;
            }
            else if (radioMinor.IsChecked == true) 
            {
                MinorDeck minorDeck = new MinorDeck();
                minorDeck.FillDeck();

                int selectedNum = GetSelectedNumber();
                List<Card> generatedCards = minorDeck.PullCards(selectedNum);

                Show_Cards(selectedNum, generatedCards);
                currentCards = generatedCards;
            }
            else
            {
                FullDeck fullDeck = new FullDeck();
                fullDeck.FillDeck();

                int selectedNum = GetSelectedNumber();
                List<Card> generatedCards = fullDeck.PullCards(selectedNum);

                Show_Cards(selectedNum, generatedCards);
                currentCards = generatedCards;
            }
        }

        private void Open_Saves(object sender, EventArgs e)
        {
            if (!SavesOpen)
            {
                SavedWindow savedWindow = new SavedWindow();
                savedWindow.Show();

                SavesOpen = true;
            }
        }


        private void Save_Pull(object sender, EventArgs e)
        {
            if (currentCards.Any() && !alreadySaved)
            {
                alreadySaved = true;
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                string appFolderPath = Path.Combine(appDataPath, "Simple Tarot Reader");

                if (!Directory.Exists(appFolderPath))
                {
                    Directory.CreateDirectory(appFolderPath);
                }

                string filePath = Path.Combine(appFolderPath, "cards.json");

                string input = Interaction.InputBox("Enter Label for Reading", "Reading Title", "General Drawing");

                SaveEntry newEntry = new SaveEntry(currentCards, DateTime.Now, input, reversals);

                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    List<SaveEntry> entryList = new List<SaveEntry>();
                    entryList.Add(newEntry);

                    string jsonString = System.Text.Json.JsonSerializer.Serialize(entryList, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, jsonString);
                }
                else
                {
                    string jsonString = File.ReadAllText(filePath);
                    var loadedEntries = System.Text.Json.JsonSerializer.Deserialize<List<SaveEntry>>(jsonString);

                    loadedEntries.Add(newEntry);

                    string newJsonString = System.Text.Json.JsonSerializer.Serialize(loadedEntries, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, newJsonString);
                }
                
                MessageBox.Show("Saved.");
            }
            else if (alreadySaved)
            {
                MessageBox.Show("Already Saved.");
            }
        }
    }
}