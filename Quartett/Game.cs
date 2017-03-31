using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartett
{
    class Game
    {
        public int roundIndex = 0;

        public int actualPlayerIndex = 0;

        public string[] image;

        private static Random rng = new Random();

        private Player currentPlayer;

        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
            }
        }

        List<Card> cards = new List<Card>();

        List<Player> players = new List<Player>();

        Repository repository = new Repository();

        // __construct
        public Game()
        {
            CreateCards();
            CreatePlayers();
            ShuffleCards();
            DistributeCards();
            PlayRound();
        }

        // Create cards
        public void CreateCards()
        {
            for (int i = 0; i < repository.cards; i++)
            {
                Card card = new Card();
                card.Id = i;
                card.Name = repository.name[i];
                for (int j = 0; j < Card.numberOfProperties; j++)
                {
                    Property property = new Property();
                    property.HigherValueWins = true;
                    property.Unit = repository.unit[j];
                    property.Value = repository.stats[j][i];
                    card.Properties.Add(property);
                }
                cards.Add(card);
            }
        }

        // Create player
        public void CreatePlayers()
        {
            for (int i = 0; i < Player.numberOfPlayers; i++)
            {
                Player player = new Player();
                player.Id = i;
                player.Name = "Spieler" + (i + 1);
                players.Add(player);
            }
        }

        public List<Card> GetCards()
        {
            return cards;
        }

        // Shuffle cards
        public void ShuffleCards()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        // Distribute cards
        public void DistributeCards()
        {
            int i = 1;
            foreach (Card card in cards)
            {
                if (i == Player.numberOfPlayers)
                {
                    i = 0;
                }
                card.Player = players[i];
                players[i].Cards.Add(card);
                i++;
            }
        }

        // Play round
        public void PlayRound()
        {
            if (HasEveryPlayerEnoughCards() == true)
            {
                if (currentPlayer == null)
                {
                    currentPlayer = players.First();
                    Console.WriteLine("Gebe deinen Spielernamen ein:");
                    currentPlayer.Name = Console.ReadLine();
                    Console.Clear();
                }

                Player player = currentPlayer;
                Property property = player.PlayCard();
                List<Card> currentCardsOfAllPlayers = GetCurrentCardsOfAllPlayers();
                Player winner = CompareCardsAndFindWinner(property, currentCardsOfAllPlayers);

                if (winner.Name == null)
                {
                    CurrentPlayer = currentCardsOfAllPlayers[0].Player;
                    Console.WriteLine("Es liegt ein Split vor es wird eine neue Eigenschaft gewählt!");
                }
                else
                {
                    CurrentPlayer = winner;
                    Console.WriteLine();
                    Console.WriteLine("Statisitk:");
                    Console.WriteLine();
                    foreach (Player playerAfterRound in players)
                    {
                        Console.WriteLine(playerAfterRound.Name + " " + playerAfterRound.Cards.Count() + " Karten");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                PlayRound();
            }
            else
            {
                int mostCards = 0;
                Player winner = new Player();

                foreach (Player player in players)
                {
                    if (player.Cards.Count > mostCards)
                    {
                        mostCards = player.Cards.Count;
                        winner = player;
                    }
                }
                Console.Clear();
                Console.WriteLine(winner.Name + " hat das Spiel gewonnen!");
                Console.ReadKey();
            }
        }

        // Compare cards and find winner
        public Player CompareCardsAndFindWinner(Property property, List<Card> currentCardsOfAllPlayers)
        {
            Card winningCard = currentCardsOfAllPlayers.First();

            Player winner = new Player();

            int indexOfProperty = 0;

            foreach (Card card in currentCardsOfAllPlayers)
            {
                int i = 0;

                foreach (Property key in card.Properties)
                {
                    if (property == key)
                    {
                        indexOfProperty = i;
                        break;
                    }
                    i++;
                }
                if (indexOfProperty > 0)
                {
                    break;
                }
            }

            if (Split(currentCardsOfAllPlayers, indexOfProperty) == false)
            {
                foreach (Card card in currentCardsOfAllPlayers)
                {
                    if (card.Properties[indexOfProperty].Value > winningCard.Properties[indexOfProperty].Value)
                    {
                        winningCard = card;
                    }
                }

                winner = winningCard.Player;

                Console.WriteLine();
                Console.WriteLine(winningCard.Name + " schlägt:");

                foreach (Card card in currentCardsOfAllPlayers)
                {
                    if (card.Name != winningCard.Name)
                    {
                        Console.WriteLine();
                        Console.WriteLine(card.Name);
                    }
                }
                Console.WriteLine();
                Console.WriteLine(winner.Name + " hat diese Runde gewonnen.");
                Console.WriteLine();

                if (winner.Id == 0)
                {
                    Console.WriteLine("Du erhälst die gegnerischen Karten!");
                }
                else
                {
                    Console.WriteLine("Deine Karte ging an: " + winner.Name);
                }

                foreach (Card card in currentCardsOfAllPlayers)
                {
                    card.Player.Cards.Remove(card);
                    winner.Cards.Add(card);
                    card.Player = winner;
                }
                return winner;
            }
            return currentPlayer;
            
        }

        // Get current cards of all players
        public List<Card> GetCurrentCardsOfAllPlayers()
        {
            List<Card> cards = new List<Card>();

            foreach (Player player in players)
            {
                cards.Add(player.GetActualCard());
            }
            return cards;
        }

        // Has every player enough cards
        public bool HasEveryPlayerEnoughCards()
        {
            bool hasEnoughCards = true;

            foreach (Player player in players)
            {
                if (player.Cards.Count <= 0)
                {
                    hasEnoughCards = false;
                }
            }
            return hasEnoughCards;
        }

        // Split
        public bool Split(List<Card> cards, int propertyIndex)
        {

            bool split = false;

            int i = 0;

            foreach (Card card in cards)
            {
                Card currentCard = cards[i];

                foreach (Card otherCard in cards)
                {
                    if(otherCard.Properties[propertyIndex].Value == currentCard.Properties[propertyIndex].Value)
                    {
                        if (otherCard.Id != currentCard.Id)
                        {
                            split = true;
                        }
                    }
                }
                i++;
            }
            return split;
        }
    }
}
