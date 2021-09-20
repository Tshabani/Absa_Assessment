using CardsAssessment.CardsShuffler;
using System;
using System.Collections.Generic;

namespace CardsAssessment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Cards CardsObj = new Cards();

            CardsObj.Shuffle();

            //Display Output
            int count = 0; 
            foreach (var item in CardsObj.GetCards())
            {
                count++;
                Console.WriteLine($"#{count}. \t{item.CardValue} \tof \t{item.CardSuit}");
            }

        }
    }
}