using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public enum Resource
    {
        Lumber,
        Stone,
        Brick,
        Ore,
        Glass,
        Cloth,
        Paper,
        Gold
    }

    enum Science
    {
        Compass,
        Gear,
        Tablet,
        Any
    }

    enum Direction
    {
        Right,
        Left,
        Self,
        LeftRight,
        All
    }

    public enum EffectType
    {
        VP,
        Produce,
        Science,
        Military,
        Money,
        Trade
    }

    public enum CardType
    {
        RawMaterial,
        ManufacturedGoods,
        Civilian,
        Scientific,
        Commercial,
        Military,
        Guild
    }

    public enum Action
    {
        Build,
        Wonder,
        Discard,
        None
    }

    public partial class Card : PictureBox
    {

        public struct CardEffect
        {
            public EffectType effectType;
            public string[] values;
        }

        protected Age age;
        protected CardType type;
        protected string playerNumber;
        protected CardEffect effect1, effect2;
        protected bool faceUp;
        protected Dictionary<Resource, int> buildCost;
        protected List<string> freeBuilds;

        public Card()
        {
            this.BackColor = SystemColors.ActiveCaptionText;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(107, 160);
            faceUp = false;
            effect1 = new CardEffect();            
            this.Image = global::WindowsFormsApplication1.Properties.Resources.card_ageI;
            this.Action = Action.None;
            buildCost = new Dictionary<Resource, int>();
            for (int i = 0; i < 8; i++)
            {
                Resource r = (Resource)i;
                buildCost[r] = 0;
            }

            freeBuilds = new List<string>();
        }



        //put all card effects in this class?
        //or the game class?
        //or its own seperate class?

        public void CreateCard(string[] cardInfo)
        {
            //set Age
            switch (cardInfo[0])
            {
                case "1":
                    age = Age.I;
                    break;
                case "2":
                    age = Age.II;
                    break;
                case "3":
                    age = Age.III;
                    break;
                default:
                    break;
            }

            //set CardType
            string[] s = cardInfo[1].Split(' ');
            switch (s[0])
            {
                case "Raw":
                    type = CardType.RawMaterial;
                    break;
                case "Manufactured":
                    type = CardType.ManufacturedGoods;
                    break;
                case "Science":
                    type = CardType.Scientific;
                    break;
                case "Military":
                    type = CardType.Military;
                    break;
                case "Civilian":
                    type = CardType.Civilian;
                    break;
                case "Commercial":
                    type = CardType.Commercial;
                    break;
                case "Guild":
                    type = CardType.Guild;
                    break;
                default:
                    break;
            }

            //set card name
            this.Name = cardInfo[2];

            //set player number
            playerNumber = cardInfo[3];

            //set card effect type
            
            string[] effectTypes = cardInfo[4].Split(',');

            switch (effectTypes[0])
            {
                case "VP":
                    effect1.effectType = EffectType.VP;
                    break;
                case "Resource":
                    effect1.effectType = EffectType.Produce;
                    break;
                case "Science":
                    effect1.effectType = EffectType.Science;
                    break;
                case "Trade":
                    effect1.effectType = EffectType.Trade;
                    break;
                case "Money":
                    effect1.effectType = EffectType.Money;
                    break;
                case "Military":
                    effect1.effectType = EffectType.Military;
                    break;
                default:
                    break;
            }

            if (effectTypes.Length == 2)
            {
                effect2 = new CardEffect();
                effect2.values = new string[1];
                effect2.effectType = EffectType.VP;
            }

            //set effect values array
            if (effectTypes.Length == 1)
            {
                string[] p = cardInfo[5].Split(',');
                effect1.values = new string[p.Length];
                effect1.values = p;
            }

            if (effectTypes.Length == 2)
            {
                string[] p = cardInfo[5].Split(',');
                effect1.values = new string[p.Length];
                effect2.values = new string[1];

                if (p.Length == 1)
                {
                    effect1.values[0] = p[0];
                    effect2.values[0] = p[0];
                }
                if (p.Length == 2)
                {
                    effect1.values[0] = p[0];
                    effect2.values[0] = p[1];
                }
            }

            //add card image

            //set build cost
            if (cardInfo[6] != "none")
            {
                string[] c = cardInfo[6].Split(',');
                foreach (string resource in c)
                {
                    string[] p = resource.Split('_');
                    switch (p[0])
                    {
                        case "Cloth":
                            BuildCost[Resource.Cloth] = int.Parse(p[1]);
                            break;
                        case "Lumber":
                            BuildCost[Resource.Lumber] = int.Parse(p[1]);
                            break;
                        case "Stone":
                            BuildCost[Resource.Stone] = int.Parse(p[1]);
                            break;
                        case "Gold":
                            BuildCost[Resource.Gold] = int.Parse(p[1]);
                            break;
                        case "Brick":
                            BuildCost[Resource.Brick] = int.Parse(p[1]);
                            break;
                        case "Paper":
                            BuildCost[Resource.Paper] = int.Parse(p[1]);
                            break;
                        case "Glass":
                            BuildCost[Resource.Glass] = int.Parse(p[1]);
                            break;
                        case "Ore":
                            BuildCost[Resource.Ore] = int.Parse(p[1]);
                            break;
                        default:
                            break;
                    }
                }
            }

            //set free builds
            if (cardInfo[7] != "none")
            {
                string[] c = cardInfo[7].Split(',');

                foreach (string str in c)
                    FreeBuilds.Add(str);
            }
        }



        public CardEffect CardEffect1
        { get { return effect1; } }

        public CardEffect CardEffect2
        { get { return effect2; } }

        public CardType CardType
        { get { return type; } }

        public Age Age
        { get { return age; } }

        public string PlayerNumber
        { get { return playerNumber; } }

        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        public Action Action { get; set; }

        public Dictionary<Resource, int> BuildCost
        { get { return buildCost; } }

        public List<string> FreeBuilds
        { get { return freeBuilds; } }
    }    
}
