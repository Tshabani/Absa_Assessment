using System;
using System.Collections.Generic;
using System.Text;

namespace CardsAssessment.CardsShuffler
{
    public class Cards
    {
        private readonly List<string> Suits = new List<string>() { "Spades", "Diamonds", "Club", "Heart" };
        private readonly List<string> CardList = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private List<Deck> Decks { get; set; }

        public Cards()
        {
            Decks = new List<Deck>();
            foreach (var SuitItem in Suits)
            {
                foreach (var cardItem in CardList)
                {
                    Decks.Add(new Deck()
                    {
                        CardSuit = SuitItem,
                        CardValue = cardItem
                    });

                }
            }  
        }

        public List<Deck> GetCards()
        {
            return Decks; 
        }

        public void Shuffle()
        {
            //Shuffle cards
            for (int i = Decks.Count - 1; i > 0; i--)
            {
                var index = new Random().Next(i);
                var tempDeck = Decks[i];
                Decks[i] = Decks[index];
                Decks[index] = tempDeck;
            }
        }
    }
}
