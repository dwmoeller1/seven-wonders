using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{

    public enum Neighbor
    {
        Right,
        Left,
        Both
    }

    public class Player
    {
        protected Hand hand;
        protected List<Card> builtCards, wonderCards;
        protected Dictionary<Resource,int> resources;
        protected Dictionary<Player, int> tradesPending;

        public Player(string name)
        {
            SetPlayerInfo();
            hand = new Hand();
            Name = "Player " + name;
            builtCards = new List<Card>();
            wonderCards = new List<Card>();
            resources = new Dictionary<Resource, int>();
            resources.Add(Resource.Brick, 0);
            resources.Add(Resource.Cloth, 0);
            resources.Add(Resource.Glass, 0);
            resources.Add(Resource.Gold, 3);
            resources.Add(Resource.Lumber, 0);
            resources.Add(Resource.Ore, 0);
            resources.Add(Resource.Paper, 0);
            resources.Add(Resource.Stone, 0);

            tradesPending = new Dictionary<Player, int>();
        }

        void SetPlayerInfo()
        {
            //dialog to choose playermat and playername
        }

        public void BuildCard(Card card)
        {
            builtCards.Add(card);
            //resolve effects
            //add end of game effects
            //add ongoing effects
            card.Action = Action.None;
        }

        public void BuildWonder(Card card)
        {
            wonderCards.Add(card);
            //resolve wonder effects
            card.Action = Action.None;
        }


        public Player LeftNeighbor { get; set; }

        public Player RightNeighbor { get; set; }

        public Hand Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public GameBoard GameBoard { get; set; }

        public string Name { get; set; }

        public void AddResource(Resource resource, int x)
        {
            resources[resource] += x;
        }

        public void CheckTrade(Player neighbor, Resource resource, int goldAvailable, out bool confirm, out int amount)
        {
            int payment = 2;
            //check trade card buildings bonus


            if (goldAvailable >= payment)
            {
                confirm = true;
                amount = payment;
            }
            else
            {
                confirm = false;
                amount = 0;
            }
        }

        public Dictionary<Resource,int> Resources
        {
            get { return resources; }
        }

        public Dictionary<Player, int> TradesPending
        {
            get { return tradesPending; }
        }
    }
}
