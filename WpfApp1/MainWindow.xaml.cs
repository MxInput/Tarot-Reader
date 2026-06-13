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
using System.IO;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;
using Path = System.IO.Path;
using Microsoft.VisualBasic;

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

            Random rand = new Random();

            if (ReversalsInclusion.IsChecked == true)
            {
                for (int i = 0; i < ChosenCards.Count; i++)
                {
                    reversals.Add(true);
                }
            }
            else
            {
                for (int i = 0; i < ChosenCards.Count; i++)
                {
                    reversals.Add(true);
                }
            }

            switch (Number)
            {
                case 1:
                    oneListBox.Visibility = Visibility.Visible;

                    String imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";

                    oneListBox.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 2:
                    twoListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Two_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Two_Two.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 3:
                    threeListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Three_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Three_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Three_Three.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 4:
                    fourListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Four_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Four_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Four_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Four_Four.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 5:
                    fiveListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Five_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Five_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Five_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Five_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Five_Five.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 6:
                    sixListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Six_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Six_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Six_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Six_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Six_Five.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Six_Six.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 7:
                    sevenListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Seven_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Seven_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Seven_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Seven_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Seven_Five.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Seven_Six.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Seven_Seven.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 8:
                    eightListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Eight_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Eight_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Eight_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Eight_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Eight_Five.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Eight_Six.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Eight_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Eight_Eight.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 9:
                    nineListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Nine_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Nine_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Nine_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Nine_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Nine_Five.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Nine_Six.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Nine_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Nine_Eight.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[8].name + ".png";
                    Nine_Nine.Source = new BitmapImage(new Uri(imagePathName));
                    break;
                case 10:
                    tenListBox.Visibility = Visibility.Visible;

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[0].name + ".png";
                    Ten_One.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[1].name + ".png";
                    Ten_Two.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[2].name + ".png";
                    Ten_Three.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[3].name + ".png";
                    Ten_Four.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[4].name + ".png";
                    Ten_Five.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[5].name + ".png";
                    Ten_Six.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[6].name + ".png";
                    Ten_Seven.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[7].name + ".png";
                    Ten_Eight.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[8].name + ".png";
                    Ten_Nine.Source = new BitmapImage(new Uri(imagePathName));

                    imagePathName = "pack://application:,,,/WpfApp1;component/images/" + ChosenCards[9].name + ".png";
                    Ten_Ten.Source = new BitmapImage(new Uri(imagePathName));
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

                SaveEntry newEntry = new SaveEntry(currentCards, DateTime.Now, input);

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