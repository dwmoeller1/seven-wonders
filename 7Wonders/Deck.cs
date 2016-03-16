using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public class Deck: List<Card>
    {
        protected int playerNumber;
        public Deck(Age age, int playerNumber)
        {
            this.Age = age;
            this.playerNumber = playerNumber;
            CreateDeck();
        }

        public Deck()
        { 
        }

        private void CreateDeck()
        {
            //create deck based on number of players and age

            {
                //create cards from xcel db
                //create the Application object we can use in the member functions.
                Microsoft.Office.Interop.Excel.Application _cardExcelFile = new Microsoft.Office.Interop.Excel.Application();
                //_cardExcelFile.Visible = true;  ??

                string fileName = "C:/Users/user/Documents/Visual Studio 2010/Projects/7Wonders/7Wonders/Resources/7_Wonders_Card_List.xlsx";

                //open the workbook
                Workbook workbook = _cardExcelFile.Workbooks.Open(fileName,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                //select the first sheet        
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

                //find the used range in worksheet
                Range excelRange = worksheet.UsedRange;

                //get an object array of all of the cells in the worksheet (their values)
                object[,] valueArray = (object[,])excelRange.get_Value(
                            XlRangeValueDataType.xlRangeValueDefault);
                
                //read to see if row has card data, if so create card and add to deck. Guilds set aside.
                List<Card> guildList = new List<Card>();

                for (int row = 1; row <= worksheet.UsedRange.Rows.Count; ++row)
                {
                    if (valueArray[row, 1] != null
                        && valueArray[row, 2] != null
                        && valueArray[row, 1].ToString() == "Card"
                        && (int)(double)valueArray[row, 2] == (int)Age)
                    {
                        //add non-guild cards
                        if (valueArray[row, 3].ToString() != "Guild"
                        && playerNumber >= (int)(double)valueArray[row, 5])
                        {
                            string[] cardInfo = new string[worksheet.UsedRange.Columns.Count];
                            for (int i = 0; i < worksheet.UsedRange.Columns.Count - 1; ++i)
                            {
                                cardInfo[i] = (valueArray[row, i + 2]).ToString();
                            }
                            
                            Card card = new Card();
                            this.Add(card);
                            card.CreateCard(cardInfo);
                        }

                        //create guild cards

                        if (valueArray[row, 3].ToString() == "Guild")
                        {
                            string[] cardInfo = new string[worksheet.UsedRange.Count];
                            for (int i = 0; i < worksheet.UsedRange.Columns.Count - 1; ++i)
                            {
                                cardInfo[i] = (valueArray[row, i + 2]).ToString();
                            }

                            Card card = new Card();
                            guildList.Add(card);
                            card.CreateCard(cardInfo);
                        }
                    }
                }

                //clean up stuffs
                workbook.Close(false, Type.Missing, Type.Missing);
                Marshal.ReleaseComObject(workbook);

                _cardExcelFile.Quit();
                Marshal.FinalReleaseComObject(_cardExcelFile);

                //shuffle guild cards and add to deck in Age 3
                if (Age == Age.III)
                {
                    Shuffle(guildList);
                    for (int i = 0; i < playerNumber + 2; i++)
                        this.Add(guildList[i]);
                }
            }
        }

        public void Shuffle(List<Card> deck)
        {
            for (int i = deck.Count; i > 1; i--)
            {
                
                int pos = MainForm.Random.Next(i);
                var x = deck[i - 1];
                deck[i - 1] = deck[pos];
                deck[pos] = x;
            }
        }

        public Age Age { get; set; }
    }
}
