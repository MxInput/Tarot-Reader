using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Path = System.IO.Path;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SavedWindow : Window
    {
        public SavedWindow()
        {
            InitializeComponent();
            ConvertSavedData();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (((MainWindow)Application.Current.MainWindow) != null)
            {
                ((MainWindow)Application.Current.MainWindow).SavesOpen = false;
            }
        }

        private void ConvertSavedData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string appFolderPath = Path.Combine(appDataPath, "Simple Tarot Reader");

            if (!Directory.Exists(appFolderPath))
            {
                Directory.CreateDirectory(appFolderPath);
            }

            string filePath = Path.Combine(appFolderPath, "cards.json");

            string jsonString = File.ReadAllText(filePath);

            var loadedEntries = System.Text.Json.JsonSerializer.Deserialize<List<SaveEntry>>(jsonString);

            List<DisplayEntry> displayCards = new List<DisplayEntry>();

            if (loadedEntries != null) 
            {
                foreach (SaveEntry foundEntry in loadedEntries)
                {
                    string currentCardName = "";
                    int count = 0;

                    foreach (Card foundCard in foundEntry.cards)
                    {
                        string reversedStatus = "Reversed";
                        if (!foundEntry.reversals[count])
                        {
                            reversedStatus = "Normal";
                        }

                        if (currentCardName == "")
                        {
                            currentCardName += foundCard.name + " - " + reversedStatus;
                        }
                        else
                        {
                            currentCardName += ", " + foundCard.name + " - " + reversedStatus;
                        }
                        count++;
                    }
                    DisplayEntry displayEntry = new DisplayEntry(currentCardName, foundEntry.dateTime, foundEntry.label);
                    displayCards.Add(displayEntry);
                }

                SavedCards.ItemsSource = displayCards;
            }
        }
    }
}
