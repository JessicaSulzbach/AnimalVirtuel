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
    public partial class VirtualAnimalMaterials : Form
    {
        Inventory _theInventory;

        internal Inventory TheInventory
        {
            get { return _theInventory; }
            set { _theInventory = value; }
        }

        public VirtualAnimalMaterials()
        {
            InitializeComponent();
        }

        private void btnMaterialsBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VirtualAnimalMaterials_Load(object sender, EventArgs e)
        {
            int Column = 1;

            tlpMaterials.Controls.Add(new Label() { Text = "Produits", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 0, 0);
            tlpMaterials.Controls.Add(new Label() { Text = "Quantité", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 1, 0);
            tlpMaterials.Controls.Add(new Label() { Text = "Utiliser", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Bold) }, 2, 0);
            foreach (var pair in TheInventory.DataStore)
            {
                tlpMaterials.Controls.Add(new Label() { Text = pair.Key, Anchor = AnchorStyles.Left, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Regular) }, 0, Column);
                tlpMaterials.Controls.Add(new Label() { Text = string.Format("{0:0.00}", pair.Value), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 12, FontStyle.Regular) }, 1, Column);
                tlpMaterials.Controls.Add(new TextBox() { Name = "tbxQnty" + Column }, 2, Column);
                Column++;
            }

            for (int i = 0; i < 7; i++)
            {
                ((TextBox)tlpMaterials.Controls["tbxQnty" + (i + 1)]).KeyPress += new KeyPressEventHandler(Filter);
            }
        }
    }
}
