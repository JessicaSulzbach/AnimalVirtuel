using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAnimal
{
    public partial class VirtualAnimalStore : Form
    {
        private Store _theStore;
        private const int NUMBER_OF_PRODUCTS = 7;
        internal Store TheStore
        {
            get { return _theStore; }
            set { _theStore = value; }
        }

        public VirtualAnimalStore()
        {
            InitializeComponent();
            TheStore = new Store();
        }

        private void VirtualAnimalStore_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            tlpStore.Controls.Clear();

            int Column = 1;

            tlpStore.Controls.Add(new Label() { Text = "Produits", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 0, 0);
            tlpStore.Controls.Add(new Label() { Text = "Prix", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 1, 0);
            tlpStore.Controls.Add(new Label() { Text = "Qnt", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 2, 0);
            foreach (var pair in TheStore.DataStore)
            {
                tlpStore.Controls.Add(new Label() { Text = pair.Key, Anchor = AnchorStyles.Left, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Regular) }, 0, Column);
                tlpStore.Controls.Add(new Label() { Text = string.Format("{0:0.00}", pair.Value), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Regular) }, 1, Column);
                tlpStore.Controls.Add(new TextBox() { Name = "tbxQnty" + Column }, 2, Column);
                Column++;
            }

            for (int i = 0; i < 7; i++)
            {
                ((TextBox)tlpStore.Controls["tbxQnty" + (i + 1)]).KeyPress += new KeyPressEventHandler(Filter);
            }
        }

        public void Filter(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) e.Handled = true;
        }

        public void Buy()
        {
            List<int> QntyList = new List<int>();
            int[] t = new int[NUMBER_OF_PRODUCTS];
            for (int i = 0; i < NUMBER_OF_PRODUCTS; i++)
            {
                if (tlpStore.Controls["tbxQnty" + (i + 1)].Text == "")
                {
                    t[i] = 0;
                }
                else
                {
                    t[i] = Convert.ToInt32(((TextBox)tlpStore.Controls["tbxQnty" + (i + 1)]).Text);
                }

                QntyList.Add(t[i]);
                ((TextBox)tlpStore.Controls["tbxQnty" + (i + 1)]).Text = "";

            }

            this.TheStore.Sell(QntyList);
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            this.Buy();
        }

        private void btnBuyAndBack_Click(object sender, EventArgs e)
        {
            this.Buy();
            this.Close();
        }
    }
}
