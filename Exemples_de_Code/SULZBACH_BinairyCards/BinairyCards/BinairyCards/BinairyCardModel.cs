using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BinairyCards
{
    class BinairyCardModel
    {
        private string imageName;
        private int total;
        private int rest;
        private List<int> cardList = new List<int>();

        private List<BinairyCard> _cards;
        public List<BinairyCard> Cards
        {
            get
            {
                return _cards;
            }

            set
            {
                _cards = value;
            }
        }

        public void setToFalse()
        {
            foreach (BinairyCard value in Cards)
            {
                value.Enable = false;
            }
        }

        public BinairyCardModel(int paramMax)
        {
            Cards = new List<BinairyCard>();
            paramMax = Convert.ToInt32(Math.Pow(2, paramMax)/2);


            int count = 0;
            while (paramMax > 1)
            {
                if (count > 0)
                {
                    paramMax = paramMax / 2;
                }

                imageName = "Value_" + paramMax;
                this.Cards.Add(new BinairyCard(paramMax, (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(imageName, Properties.Resources.Culture)));
                count++;
            }
        }

        public int decimalValue()
        {
            total = 0;

            foreach (BinairyCard value in Cards)
            {
                if (value.Enable == true)
                {
                    total += value.Value;
                }
            }

            return total;
        }

        public List<int> ReturnBits()
        {
            foreach (BinairyCard value in Cards)
            {
                if (value.Enable == true)
                {
                    cardList.Add(value.Value);
                }
                else
                {
                    cardList.Add(0);
                }
            }

            return cardList;
        }

        public List<bool> binaryValue(int paramDecimalValue)
        {
            List<bool> status = new List<bool>();

            for (int i = 0; i < this.Cards.Count; i++)
            {
                rest = paramDecimalValue % 2;
                paramDecimalValue = paramDecimalValue / 2;

                if (rest == 0)
                {
                    status.Add(false);
                }
                else
                {
                    status.Add(true);
                }
            }

            return status;

        }

        public void ToTurnALL(bool paramTurn)
        {
            for (int i = 0; i < this.Cards.Count; i++)
            {
                Cards[i].Enable = paramTurn;
            }
        }
    }
}
