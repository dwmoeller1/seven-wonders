using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public enum Age
    {
        I=1,
        II=2,
        III=3
    }

    public class Game
    {
        protected Deck ageOneDeck, ageTwoDeck, ageThreeDeck, discardPile;
        protected List<Player> players;
        protected Age gameAge;
        protected int round;
        protected GameBoard gameBoard;
        protected Card selectedCard;
        protected List<Card> pendingCards;

        public Game(int numberofPlayers)
        {
            this.NumberofPlayers = numberofPlayers;
            NewGameSetup();
            gameBoard = new GameBoard();
            gameBoard.Show();
            selectedCard = null;
            GameBoard.CardPlayButtons.Visible = false;
        }

        private void NewGameSetup()
        {
            //Create players and set neighbors
            players = new List<Player>();
            for (int i = 0; i < NumberofPlayers; i++)
            {
                Player player = new Player((i+1).ToString());
                players.Add(player);
                player.GameBoard = this.GameBoard;
            }

            SetNeighbors();

            //MainForm.ConfigureButtons(NumberofPlayers);

            //create decks
            ageOneDeck = new Deck(Age.I, NumberofPlayers);
            ageOneDeck.Shuffle(ageOneDeck);

            ageTwoDeck = new Deck(Age.II, NumberofPlayers);
            ageTwoDeck.Shuffle(ageTwoDeck);

            ageThreeDeck = new Deck(Age.III, NumberofPlayers);
            ageThreeDeck.Shuffle(ageThreeDeck);

            discardPile = new Deck();

            pendingCards = new List<Card>();

            round = 1;
            gameAge = Age.I;
        }

        public void StartRound()
        {
            if(round == 1)
                foreach (Player player in players)
                    DealCard(player, 7);

            CurrentPlayer = players[0];
            DisplayCurrentPlayer();
        }

        private void DisplayCurrentPlayer()
        {
            //show currentplayer play area 

            //show currentplayer hand and subscribe to Click event
            GameBoard.Instructions = CurrentPlayer.Name + " Please Select a Card";

            GameBoard.HandArea.Controls.Clear();
            foreach (Card card in CurrentPlayer.Hand)
            {
                GameBoard.HandArea.Controls.Add(card);
                card.Click += new EventHandler(card_Click);
            }
        }

        //click card event shows card play buttons
        void card_Click(object sender, EventArgs e)
        {
            Card card = sender as Card;

            SelectedCard = card;            

            //show discard button and subscribe to click event
            GameBoard.CardPlayButtons.Visible = true;
            GameBoard.Btn_Discard.Click += new EventHandler(CardPlayButtons_Click);
            GameBoard.Btn_Build.Click += new EventHandler(CardPlayButtons_Click);
            GameBoard.Btn_Wonder.Click += new EventHandler(CardPlayButtons_Click);
            GameBoard.Btn_Cancel.Click += new EventHandler(CardPlayButtons_Click);

            GameBoard.Instructions = CurrentPlayer.Name + " How would you like to play the card?";
        }

        void CardPlayButtons_Click(object sender, EventArgs e)
        {
            //Add to cards played and proceed to next player or end round
            Button btn = sender as Button;
            if (SelectedCard != null)
            {
                switch (btn.Name)
                {
                    case "btn_Build":
                        if (CheckBuildRequirements())
                            SelectedCard.Action = Action.Build;
                        else
                            SelectedCard = null;
                        break;
                    case "btn_Discard":
                        SelectedCard.Action = Action.Discard;
                        break;
                    case "btn_Wonder":
                        if (CheckBuildRequirements())
                            SelectedCard.Action = Action.Wonder;
                        else
                            SelectedCard = null;
                        break;
                    default:
                        SelectedCard = null;
                        GameBoard.CardPlayButtons.Visible = false;
                        break;
                }
            }

            if (SelectedCard != null)
            {
                pendingCards.Add(SelectedCard);
                CurrentPlayer.Hand.Remove(SelectedCard);

                GameBoard.CardPlayButtons.Visible = false;

                if (CurrentPlayer == players[NumberofPlayers - 1])
                    ResolveRound();
                else
                {
                    CurrentPlayer = CurrentPlayer.LeftNeighbor;
                    DisplayCurrentPlayer();
                }
            }                
        }

        private void ResolveRound()
        {
            //process each card played, pass hands or end Age
            GameBoard.HandArea.Controls.Clear();

            if (round == 6)
            {
                EndAge();
                return;
            }

            ResolveCardsPlayed();
            PassHands();

            round++;
            CurrentPlayer = players[0];
            DisplayCurrentPlayer();
        }

        private void ResolveCardsPlayed()
        {
            //check action and apply appropriate results
            for (int i = 0; i < players.Count; i++)
            {
                Card card = pendingCards[i] as Card;
                switch (card.Action)
                {
                    case Action.Discard:
                        DiscardPile.Add(card);
                        card.Action = Action.None;
                        players[i].AddResource(Resource.Gold, 3);
                        break;
                    case Action.Build:
                        players[i].BuildCard(card);
                        //update resources
                        break;
                    case Action.Wonder:
                        players[i].BuildWonder(card);
                        break;
                    default:
                        break;
                }
            }

            pendingCards.Clear();
        }

        private void PassHands()
        {
            List<Hand> hands = new List<Hand>();
            for (int i = 0; i < players.Count; i++)
                hands[i] = players[i].Hand;

            for (int i = 0; i < players.Count; i++)
            {
                if (Age == Age.II)
                    players[i].RightNeighbor.Hand = hands[i];
                else
                    players[i].LeftNeighbor.Hand = hands[i];
            }
        }

        private void EndAge()
        {
            throw new NotImplementedException();
        }

        private void DealCard(Player player, int number)
        {
            for (int i = 0; i < number; i++)
            {
                player.Hand.Add(CurrentDeck[0]);
                CurrentDeck.RemoveAt(0);
            }
        }

        private void SetNeighbors()
        {
            for (int i = 0; i < NumberofPlayers; i++)
            {
                if (i==0)
                {
                    players[i].LeftNeighbor = players[i + 1];
                    players[i].RightNeighbor = players[NumberofPlayers-1];
                }
                else if (i == NumberofPlayers - 1)
                {
                    players[i].LeftNeighbor = players[0];
                    players[i].RightNeighbor = players[i - 1];
                }
                else
                {
                    players[i].LeftNeighbor = players[i + 1];
                    players[i].RightNeighbor = players[i - 1];
                }
            }
        }

        public bool CheckBuildRequirements()
        {
            //check for wonder or card build - wonder face down and pull build requirements from wonder card

            //build dialog
            BuildDialog buildDialog = new BuildDialog(CurrentPlayer, SelectedCard);
            buildDialog.ShowDialog();

            if (buildDialog.DialogResult == DialogResult.OK)
            {
                buildDialog.Dispose();
                return true;
            }
            else
            {
                buildDialog.Dispose();
                return false;
            }
        }

        public int NumberofPlayers { get; set; }

        public int Round
        { get { return round; } }

        public Age Age
        { get { return gameAge; } }

        public Deck CurrentDeck
        {
            get
            {
                switch (Age)
                {
                    case Age.I:
                        return ageOneDeck;                        
                    case Age.II:
                        return ageTwoDeck;
                    case Age.III:
                        return ageThreeDeck;
                    default:
                        return ageOneDeck;
                }
            }
        }

        public Deck DiscardPile
        {
            get { return discardPile; }
        }

        public GameBoard GameBoard
        {
            get { return gameBoard; }
        }

        public Player CurrentPlayer { get; set; }

        public Card SelectedCard
        {
            get { return selectedCard; }
            set
            {
                if (selectedCard != null)
                    selectedCard.BorderStyle = BorderStyle.None;                

                selectedCard = value;

                if(selectedCard!=null)
                    selectedCard.BorderStyle = BorderStyle.Fixed3D;               
            }
        }
    }
}
