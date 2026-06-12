using System;
using System.Drawing.Text;
using System.Windows.Navigation;

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
    private static Random rand = new Random();

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
        Cards.Add(new Card("Wheel of Fortune", Arcana.Major));
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

    public List<Card> PullCards(int Number)
    {
        List<Card> ChosenCards = new List<Card>();
        for (int i = 0; i < Number; i++)
        {
            int r = rand.Next(Cards.Count);
            ChosenCards.Add(Cards[r]);
        }
        return ChosenCards;
    }
}

public class MinorDeck
{
    private static Random rand = new Random();

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

                string suitName = "";

                switch (i)
                {
                    case 0:
                        suitName = "Wands";
                        break;
                    case 1:
                        suitName = "Cups";
                        break;
                    case 2:
                        suitName = "Swords";
                        break;
                    case 3:
                        suitName = "Pentacles";
                        break;

                }

                Cards.Add(new Card(foundNum + " of " + suitName, Arcana.Minor));
            }
        }

    }
    public List<Card> PullCards(int Number)
    {
        List<Card> ChosenCards = new List<Card>();
        for (int i = 0; i < Number; i++)
        {
            int r = rand.Next(Cards.Count);
            ChosenCards.Add(Cards[r]);
        }
        return ChosenCards;
    }
}

public class FullDeck
{
    private static Random rand = new Random();


    public List<Card> Cards = new List<Card>();

    private MajorDeck majorDeck = new MajorDeck();
    private MinorDeck minorDeck = new MinorDeck();

    public void FillDeck()
    {
        majorDeck.FillDeck();
        minorDeck.FillDeck();

        Cards.AddRange(majorDeck.Cards);
        Cards.AddRange(minorDeck.Cards);
    }

    public List<Card> PullCards(int Number)
    {
        List<Card> ChosenCards = new List<Card>();
        for (int i = 0; i < Number; i++)
        {
            int r = rand.Next(Cards.Count);
            ChosenCards.Add(Cards[r]);
        }
        return ChosenCards;
    }
}