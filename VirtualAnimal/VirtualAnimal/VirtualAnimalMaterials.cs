/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI
 * Name         : VirtualAnimalMaterials
 * Description  :
 * Last modified: 23.05.2017
 ****************************************************************************/
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
        private Inventory _theInventory;

        internal Inventory TheInventory
        {
            get { return _theInventory; }
            set { _theInventory = value; }
        }

        public VirtualAnimalMaterials(Inventory i)
        {
            InitializeComponent();
            TheInventory = i;

            TheInventory.InventoryData();
            TheInventory.InventoryData("Materials");
        }

        private void VirtualAnimalMaterials_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            TheInventory.SaveOrRecover.FileReader("Product_name_and_price.txt");
            TheInventory.InventoryData("Materials");
            tlpMaterials.Controls.Clear();

            int Line = 1;

            tlpMaterials.Controls.Add(new Label() { Text = "Produits", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Bold) }, 0, 0);
            tlpMaterials.Controls.Add(new Label() { Text = "Quantité", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Bold) }, 1, 0);
            foreach (var pair in TheInventory.DataInventoryHALF)
            {
                tlpMaterials.Controls.Add(new RadioButton() { Name = "rdbMaterial" + Line, Text = pair.Key, Anchor = AnchorStyles.Left, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Regular) }, 0, Line);
                tlpMaterials.Controls.Add(new Label() { Name = "lblMaterial" + Line, Text = string.Format("{0}", pair.Value), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Regular) }, 1, Line);
                Line++;
            }
        }

        private void btnMaterialsBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaterialsUse_Click(object sender, EventArgs e)
        {
            string myKey;
            int myValue;
            for (int i = 1; i < TheInventory.DataInventoryHALF.Count; i++)
            {
                if (((RadioButton)tlpMaterials.Controls["rdbMaterial" + (i)]).Checked)
                {
                    myKey = ((RadioButton)tlpMaterials.Controls["rdbMaterial" + (i)]).Text;
                    myValue = Convert.ToInt32(((Label)tlpMaterials.Controls["lblMaterial" + (i)]).Text);

                    if (myValue != 0)
                    {
                        TheInventory.DataInventoryFULL[myKey] = myValue - 1;
                        TheInventory.DataInventoryHALF[myKey] = myValue - 1;

                        TheInventory.Rewrite();
                        if (myKey == "Shampooing")
                        {
                            TheInventory.Use("Shower");
                        }
                        else if(myKey == "Brosse")
                        {
                            TheInventory.Use("Brush");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oups... Vous n'avez plus de " + myKey + ", il faut aller en acheter au magasin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            this.Close();
        }

        private void btnMaterialsSell_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= TheInventory.DataInventoryHALF.Count; i++)
            {
                if (((RadioButton)tlpMaterials.Controls["rdbMaterial" + (i)]).Checked)
                {
                    if (TheInventory.DataInventoryHALF.ContainsKey(((RadioButton)tlpMaterials.Controls["rdbMaterial" + (i)]).Text))
                    {
                        string myKey = ((RadioButton)tlpMaterials.Controls["rdbMaterial" + (i)]).Text;

                        TheInventory.DataInventoryFULL[myKey] = 0;
                        TheInventory.DataInventoryHALF[myKey] = 0;
                    }
                    TheInventory.Rewrite();
                }

            }
            UpdateView();
        }
    }
}
