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

        private void VirtualAnimalStore_Load(object sender, EventArgs e)
        {
            foreach (var pair in TheStore.DataStore)
            {
                for (int i = 0; i < TheStore.DataStore.Count; i++)
                {
                    tlpStore.Controls.Add(new Label() { Text = pair.Key, Anchor = AnchorStyles.None, AutoSize = true }, 0, i);
                }

            }
            
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
