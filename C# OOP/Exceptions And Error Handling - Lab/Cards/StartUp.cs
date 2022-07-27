using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            HashSet<Card> col = new HashSet<Card>();
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string[] currCard = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Card cardToAdd = new Card(currCard[0], currCard[1]);
                    col.Add(cardToAdd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(" ", col));
        }
    }

    public class Card
    {
        private string _face;
        private char _suit;
        string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private string[] validSuites = new string[] { "S", "H", "D", "C" };

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit.ToCharArray()[0];
        }
        public string Face
        {
            get => this._face;
            set
            {
                if (validFaces.Contains(value))
                {
                    this._face = value;
                }
                else
                {
                    throw new Exception("Invalid card!");
                }
            }
        }

        public char Suit
        {
            get => this._suit;
            set
            {
                if (validSuites.Contains($"{value}"))
                {
                    switch (value)
                    {
                        case 'C':
                            this._suit = '\u2663';
                            break;

                        case 'D':
                            this._suit = '\u2666';
                            break;

                        case 'H':
                            this._suit = '\u2665';
                            break;

                        case 'S':
                            this._suit = '\u2660';
                            break;
                    }
                }
                else
                {
                    throw new Exception("Invalid card!");
                }
            }
        }

        public override string ToString()
        {
            return $"[{this.Face}{this.Suit}]";
        }
    }
}
