using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class SaveEntry
    {
        public List<Card> cards
        { get; set; }

        public List<bool> reversals
        { get; set; }

        public DateTime dateTime
        { get; set; }

        public string label
        { get; set; }

        public SaveEntry(List<Card> cards, DateTime dateTime, string label, List<bool> reversals)
        {
            this.cards = cards;
            this.dateTime = dateTime;
            this.label = label;
            this.reversals = reversals;
        }
    }

    class DisplayEntry
    {
        public string cardNames
        { get; set; }

        public DateTime dateTime
        { get; set; }

        public string label
        { get; set; }


        public DisplayEntry(string cardNames, DateTime dateTime, string label)
        {
            this.cardNames = cardNames;
            this.dateTime = dateTime; 
            this.label = label;
        }
    }
}
