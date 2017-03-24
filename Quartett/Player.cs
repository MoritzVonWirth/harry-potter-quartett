using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartett
{
    class Player
    {
        private Int32 id;

        private string name;

        public const int numberOfPlayers = 3;

        private static Random rng = new Random();

        List<Card> cards = new List<Card>();

        public Int32 Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            { 
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
            set
            {
                cards = value;
            }
        }

        // Count cards
        public int CountCards()
        {
            int numberOfCards = cards.Count();
            return numberOfCards;
        }

        // Play card
        public Property PlayCard()
        {
            Card card = GetActualCard();
            Property property = ChooseProperty(card);
            return property;
        }

        // Choose property
        public Property ChooseProperty(Card card)
        {
            Property property = new Property();

            if (card.Player.id == 0)
            {
                int a = 1;
                int b = 2;
                int c = 3;
                int d = 4;
                int e = 5;

                Console.WriteLine("Du hast "+card.Name+" gezogen!");
                Console.WriteLine();

                List<string> image = card.GetImage();

                foreach (string line in image)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
                Console.WriteLine("Wähle die Eigenschaft die zu vergleichen möchtest:");

                Console.WriteLine();

                Console.WriteLine(card.Name);

                Console.WriteLine(a + ". " + card.Properties[0].Unit + " " + card.Properties[0].Value);
                Console.WriteLine(b + ". " + card.Properties[1].Unit + " " + card.Properties[1].Value);
                Console.WriteLine(c + ". " + card.Properties[2].Unit + " " + card.Properties[2].Value);
                Console.WriteLine(d + ". " + card.Properties[3].Unit + " " + card.Properties[3].Value);
                Console.WriteLine(e + ". " + card.Properties[4].Unit + " " + card.Properties[4].Value);

                string checkReadLine;
                checkReadLine = Console.ReadLine();

                if (checkReadLine == "")
                {
                    checkReadLine = "0";
                }

                int indexOfChoosenProperty = Convert.ToInt32(checkReadLine);

                property = new Property();

                if (indexOfChoosenProperty == a)
                {
                    property = card.Properties[a - 1];
                }

                if (indexOfChoosenProperty == b)
                {
                    property = card.Properties[b - 1];
                }

                if (indexOfChoosenProperty == c)
                {
                    property = card.Properties[c - 1];
                }

                if (indexOfChoosenProperty == d)
                {
                    property = card.Properties[d - 1];
                }

                if (indexOfChoosenProperty == e)
                {
                    property = card.Properties[e - 1];
                }

                if (indexOfChoosenProperty <= 0 || indexOfChoosenProperty > e)
                {
                    Console.WriteLine("Bitte wähle eine Zahl zwischen 1-5!");
                    property = ChooseProperty(card);
                }
            }
            else
            {
                int a = 1;
                int b = 2;
                int c = 3;
                int d = 4;
                int e = 5;

                int k = rng.Next(5 + 1);

                if (k == 0)
                {
                    k++;
                }

                int indexOfChoosenProperty = k;

                property = new Property();

                if (indexOfChoosenProperty == a)
                {
                    property = card.Properties[a - 1];
                }

                if (indexOfChoosenProperty == b)
                {
                    property = card.Properties[b - 1];
                }

                if (indexOfChoosenProperty == c)
                {
                    property = card.Properties[c - 1];
                }

                if (indexOfChoosenProperty == d)
                {
                    property = card.Properties[d - 1];
                }

                if (indexOfChoosenProperty == e)
                {
                    property = card.Properties[e - 1];
                }

                if (indexOfChoosenProperty <= 0 || indexOfChoosenProperty > e)
                {
                    Console.WriteLine("Bitte wähle eine Zahl zwischen 1-5!");
                    property = ChooseProperty(card);
                }
            }

            return property; 
        }

        // Get actual card
        public Card GetActualCard()
        {
            Card actualCard = cards.First();
            return actualCard;
        }

    }
}
