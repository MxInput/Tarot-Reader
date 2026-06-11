using System;
using System.Drawing.Text;

public enum Arcana
{
	Major,
	Minor
}

public class Card
{
	public string name
	{ get; set; }

	public Arcana arcana
	{ get; set; }

	public Card(string name, Arcana arcana)
	{
		this.name = name;
		this.arcana = arcana;
	}
}

public class MajorDeck
{
    public List<Card> Cards = new List<Card>();
    public void FillDeck() {
		Cards.Add(new Card("The Fool", Arcana.Major));
        Cards.Add(new Card("The Magician", Arcana.Major));
        Cards.Add(new Card("The High Priestess", Arcana.Major));
        Cards.Add(new Card("The Empress", Arcana.Major));
        Cards.Add(new Card("The Emperor", Arcana.Major));
        Cards.Add(new Card("The Hierophant", Arcana.Major));
        Cards.Add(new Card("The Lovers", Arcana.Major));
        Cards.Add(new Card("The Chariot", Arcana.Major));
        Cards.Add(new Card("Strength", Arcana.Major));
        Cards.Add(new Card("The Hermit", Arcana.Major));
        Cards.Add(new Card("The Wheel of Fortune", Arcana.Major));
        Cards.Add(new Card("Justice", Arcana.Major));
        Cards.Add(new Card("The Hanged Man", Arcana.Major));
        Cards.Add(new Card("Death", Arcana.Major));
        Cards.Add(new Card("Temperance", Arcana.Major));
        Cards.Add(new Card("The Devil", Arcana.Major));
        Cards.Add(new Card("The Tower", Arcana.Major));
        Cards.Add(new Card("The Star", Arcana.Major));
        Cards.Add(new Card("The Moon", Arcana.Major));
        Cards.Add(new Card("The Sun", Arcana.Major));
        Cards.Add(new Card("Judgement", Arcana.Major));
        Cards.Add(new Card("The World", Arcana.Major));
    }
}

public class MinorDeck
{
    private static string[] NumberNames = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
    public List<Card> Cards = new List<Card>();
    public void FillDeck()
    {
        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 14; j++)
            {
                string foundNum = "";
                if (j != 0 && j < 10)
                {
                    foundNum = NumberNames[j - 1];
                }
                else
                {
                    if (j == 0)
                    {
                        foundNum = "Ace";
                    }
                    else
                    {
                        switch (j)
                        {
                            case 10:
                                foundNum = "Page";
                                break;
                            case 11:
                                foundNum = "Knight";
                                break;
                            case 12:
                                foundNum = "Queen";
                                break;
                            case 13:
                                foundNum = "King";
                                break;
                        }


                    }
                }

                string minorArcana = "";

                switch (i)
                {
                    case 0:
                        minorArcana = "Wands";
                        break;
                    case 1:
                        minorArcana = "Cups";
                        break;
                    case 2:
                        minorArcana = "Swords";
                        break;
                    case 3:
                        minorArcana = "Pentacles";
                        break;

                }

                Cards.Add(new Card(foundNum + " of " + minorArcana, Arcana.Minor));
            }
        }
    }
}

public class FullDeck
{
    public List<Card> Cards = new List<Card>();

    MajorDeck majorDeck = new MajorDeck();
    MinorDeck minorDeck = new MinorDeck();

    majorDeck
}