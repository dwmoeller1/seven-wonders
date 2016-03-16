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
    enum Resource
    {
        Lumber,
        Stone,
        Brick,
        Ore,
        Glass,
        Cloth,
        Paper
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

    public partial class Card : PictureBox, System.ComponentModel.ISupportInitialize
    {

        public struct CardEffect
        {
            public EffectType effectType;
            public string[] values;
        }

        protected string name;
        protected Age age;
        protected CardType type;
        protected string playerNumber;
        protected CardEffect effect1, effect2;
        protected bool faceUp;

        public Card(string[] cardInfo)
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(107, 160);
            faceUp = false;
            effect1 = new CardEffect();
            CreateCard(cardInfo);
            this.InitialImage = global::WindowsFormsApplication1.Properties.Resources.card_ageI;
            this.Location = new Point(3, 3);
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
            name = cardInfo[2];

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

        public string Name
        { get { return name; } }

        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }
    }
    
}
