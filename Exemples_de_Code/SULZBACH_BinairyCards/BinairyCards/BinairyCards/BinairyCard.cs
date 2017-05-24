using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinairyCards
{
    class BinairyCard : PictureBox
    {
        private Bitmap _backImage;
        public Bitmap BackImage
        {
            get
            {
                return _backImage;
            }

            set
            {
                _backImage = BinairyCards.Properties.Resources.back; 
            }
        }

        private Bitmap _cardImage;
        public Bitmap CardImage
        {
            get
            {
                return _cardImage;
            }

            set
            {
                _cardImage = value;
            }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private bool _enable;
        public bool Enable
        {
            get { return _enable; }
            set
            {
                if (value == true) 
                { 
                    this.Image = CardImage;
                    _enable = value;
                }
                else
                {
                    this.Image = BackImage;
                    _enable = value;
                }
            }
        }

        public void ToTurnOver()
        {
            if (this.Enable == false)
            {
                this.Enable = true;
            }
            else
            {
                this.Enable = false;
            }
        }

        public BinairyCard(int value, Bitmap image)
        {
            this.Value = value;
            this.CardImage = image;
            this.Enable = false;
            this.BackImage = Properties.Resources.back;
            
        }
    }
}
