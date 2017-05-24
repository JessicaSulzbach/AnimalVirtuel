using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinairyCards
{
    public partial class BinairyCardView : Form
    {
        const int CARD_HEIGHT = 142;
        const int ALIGNMENT_VALUE = 10;
        int automatic = 0;
        int widthOfCard;
        int startLocation;
        bool increasing;

        public BinairyCardView()
        {
            InitializeComponent();
            creatingCards(8);
        }

        private PictureBox[] _pbx;
        public PictureBox[] pbx
        {
            get { return _pbx; }
            set { _pbx = value; }
        }

        private BinairyCardModel _model;
        internal BinairyCardModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private List<Label> _lblDecimal;
        public List<Label> LblDecimal
        {
            get { return _lblDecimal; }
            set { _lblDecimal = value;}
        }

        private List<Label> _lblBinairy;
        public List<Label> LblBinairy
        {
            get { return _lblBinairy;}
            set {_lblBinairy = value;}
        }

        private int _numberOfCards;
        public int NumberOfCards
        {
            get { return _numberOfCards;}
            set {_numberOfCards = value;}
        }

        public void creatingCards(int paramNumberOfBits)
        {
            if (LblDecimal != null)
            {
                foreach (Label lblValue in LblDecimal)
                {
                    lblValue.Hide();
                    this.Controls.Remove(lblValue);
                }
            }

            if (LblBinairy != null)
            {
                foreach (Label lblValue in LblBinairy)
                {
                    lblValue.Hide();
                    this.Controls.Remove(lblValue);
                }
            }

            if (Model != null)
            {
                foreach (BinairyCard value in Model.Cards)
                {
                    value.Hide();
                    this.Controls.Remove(value);
                }
            }

            this.NumberOfCards = paramNumberOfBits;
            widthOfCard = (this.gbxCards.Width / NumberOfCards) - ALIGNMENT_VALUE;

            Model = new BinairyCardModel(NumberOfCards);
            LblDecimal = new List<Label>();
            LblBinairy = new List<Label>();

            startLocation = gbxCards.Width - ALIGNMENT_VALUE - widthOfCard;

            Model.Cards.Reverse();

            foreach (PictureBox card in Model.Cards)
            {
                card.Location = new Point(startLocation, 20);
                card.Anchor = AnchorStyles.None;
                card.Dock = DockStyle.None;
                card.Size = new Size(widthOfCard, CARD_HEIGHT);
                card.SizeMode = PictureBoxSizeMode.StretchImage;
                card.Image = BinairyCards.Properties.Resources.back;
                card.Show();
                card.Click += new EventHandler(this.card_Click);
                gbxCards.Controls.Add(card);

                Label lblEnable = new Label();
                lblEnable.Location = new Point(startLocation + 45, 40);
                lblEnable.Text = Convert.ToString(2);
                lblEnable.Width = 30;
                lblEnable.ForeColor = System.Drawing.Color.Blue;
                LblBinairy.Add(lblEnable);
                lblEnable.Show();
                gbxBinaryValue.Controls.Add(lblEnable);

                Label lblValue = new Label();
                lblValue.Location = new Point(startLocation + 45, 40);
                lblValue.ForeColor = System.Drawing.Color.Blue;
                lblValue.Show();
                LblDecimal.Add(lblValue);
                gbxCalculations.Controls.Add(lblValue);

                startLocation = startLocation - widthOfCard - ALIGNMENT_VALUE;

            }

            UpdateView();
        }

        public void UpdateView()
        {
            for (int i = 0; i < NumberOfCards; i++)
            {
                if (Model.Cards[i].Enable == false)
                {
                    LblDecimal[i].Text = "0";
                    LblBinairy[i].Text = "0";
                }
                else
                {
                    LblDecimal[i].Text = Convert.ToString(Model.Cards[i].Value);
                    LblBinairy[i].Text = "1";
                }
            }

            lblTotal.Text = Convert.ToString(Model.decimalValue());
        }

        void card_Click(object sender, System.EventArgs e)
        {
            BinairyCard card = (BinairyCard)sender;
            card.ToTurnOver();
            UpdateView();
        }

        private void tmrAutomatic_Tick(object sender, EventArgs e)
        {
            if (increasing == true)
            {
                List<bool> isEnabled = Model.binaryValue(automatic);

                for (int i = 0; i < Model.Cards.Count; i++)
                {
                    Model.Cards[i].Enable = isEnabled[i];
                }

                automatic++;
            }
            else
            {
                List<bool> isEnabled = Model.binaryValue(automatic);

                for (int i = 0; i < Model.Cards.Count; i++)
                {
                    Model.Cards[i].Enable = isEnabled[i];
                }

                automatic--;
            }

            UpdateView();
        }


        private void tsmiUp_Click(object sender, EventArgs e)
        {
            automatic = Model.decimalValue();
            increasing = true;
            tmrAutomatic.Enabled = true;
            tsslMode.Text = "Mode automatique: Croissant";
        }

        private void tmsiDown_Click(object sender, EventArgs e)
        {
            automatic = Model.decimalValue();
            increasing = false;
            tmrAutomatic.Enabled = true;
            tsslMode.Text = "Mode automatique: Décroissant";
        }

        private void tsmiShowAll_Click(object sender, EventArgs e)
        {
            Model.ToTurnALL(true);
            UpdateView();
        }

        private void tsmiHideAll_Click(object sender, EventArgs e)
        {
            Model.ToTurnALL(false);
            UpdateView();
        }

        private void tsmiModeManuel_Click(object sender, EventArgs e)
        {
            tmrAutomatic.Enabled = false;
            tsslMode.Text = "Mode manuel";
        }

        private void tsmiTwoCards_Click(object sender, EventArgs e)
        {
            creatingCards(2);
        }

        private void tsmiThreeCards_Click(object sender, EventArgs e)
        {
            creatingCards(3);
        }

        private void tsmiFourCards_Click(object sender, EventArgs e)
        {
            creatingCards(4);
        }

        private void tsmiFiveCards_Click(object sender, EventArgs e)
        {
            creatingCards(5);
        }

        private void tsmiSixCards_Click(object sender, EventArgs e)
        {
            creatingCards(6);
        }

        private void tsmiSevenCards_Click(object sender, EventArgs e)
        {
            creatingCards(7);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            creatingCards(8);
        }
    }
}
