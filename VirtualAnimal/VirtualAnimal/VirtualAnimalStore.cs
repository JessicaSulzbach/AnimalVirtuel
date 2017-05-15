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
        TextBox aaa;
        private void VirtualAnimalStore_Load(object sender, EventArgs e)
        {
            int Column = 1;

            foreach (var pair in TheStore.DataStore)
            {
                tlpStore.Controls.Add(new Label() { Text = pair.Key, Anchor = AnchorStyles.None, AutoSize = true }, 0, Column);
                tlpStore.Controls.Add(new Label() { Text = Convert.ToString(pair.Value), Anchor = AnchorStyles.None, AutoSize = true }, 1, Column);
                tlpStore.Controls.Add(new TextBox() { Name = "tbxQnty" + Column });
                Column++;
            }

        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
