using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class SaveEntry
    {
        public List<Card> cards
        { get; set; }

        public DateTime dateTime
        { get; set; }

        public SaveEntry(List<Card> cards, DateTime dateTime)
        {
            this.cards = cards;
            this.dateTime = dateTime;
        }
    }
}
