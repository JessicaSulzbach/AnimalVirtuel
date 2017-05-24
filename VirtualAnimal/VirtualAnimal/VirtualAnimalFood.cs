/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI - Virtual animal 
 * Name         : VirtualAnimalFood
 * Description  : Food form 
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
    public partial class VirtualAnimalFood : Form
    {
        // Variable
        private Inventory _theInventory;

        // Propertie
        public Inventory TheInventory
        {
            get { return _theInventory; }
            set { _theInventory = value; }
        }

        public VirtualAnimalFood(Inventory i)
        {
            InitializeComponent();
            TheInventory = i;

            TheInventory.InventoryData();
            TheInventory.InventoryData("Food");
        }

        private void VirtualAnimalFood_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        /// <summary>
        /// Fills the table panel layout with the labels and radio buttons necessary
        /// </summary>
        private void UpdateView()
        {
            TheInventory.SaveOrRecover.FileReader("Product_name_and_price.txt");
            TheInventory.InventoryData("Food");
            tlpFood.Controls.Clear();

            int Line = 1;

            tlpFood.Controls.Add(new Label() { Text = "Produits", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Bold) }, 0, 0);
            tlpFood.Controls.Add(new Label() { Text = "Quantité", Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Bold) }, 1, 0);
            foreach (var pair in TheInventory.DataInventoryHALF)
            {
                tlpFood.Controls.Add(new RadioButton() { Name = "rdbFood" + Line, Text = pair.Key, Anchor = AnchorStyles.Left, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Regular) }, 0, Line);
                tlpFood.Controls.Add(new Label() { Name = "lblFood" + Line, Text = string.Format("{0}", pair.Value), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Verdana", 11, FontStyle.Regular) }, 1, Line);
                Line++;
            }
        }

        /// <summary>
        /// Quantity minus 1
        /// Closes the form and a animation plays
        /// </summary>
        private void btnFoodUse_Click(object sender, EventArgs e)
        {
            string myKey;
            int myValue;
            for (int i = 1; i <= TheInventory.DataInventoryHALF.Count; i++)
            {
                if (((RadioButton)tlpFood.Controls["rdbFood" + (i)]).Checked)
                {
                    myKey = ((RadioButton)tlpFood.Controls["rdbFood" + (i)]).Text;
                    myValue = Convert.ToInt32(((Label)tlpFood.Controls["lblFood" + (i)]).Text);

                    if (myValue > 0)
                    {
                        TheInventory.DataInventoryFULL[myKey] = myValue - 1;
                        TheInventory.DataInventoryHALF[myKey] = myValue - 1;

                        TheInventory.Rewrite();
                        if (myKey == "Riz" || myKey == "Sushi")
                        {
                            TheInventory.Use("Eat");
                        }
                        else
                        {
                            TheInventory.Use("Happy");
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
  
        /// <summary>
        /// Form stays open.
        /// The quantity equals 0
        /// </summary>
        private void btnFoodSell_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= TheInventory.DataInventoryHALF.Count; i++)
            {
                if (((RadioButton)tlpFood.Controls["rdbFood" + (i)]).Checked)
                {
                    if (TheInventory.DataInventoryHALF.ContainsKey(((RadioButton)tlpFood.Controls["rdbFood" + (i)]).Text))
                    {
                        string myKey = ((RadioButton)tlpFood.Controls["rdbFood" + (i)]).Text;

                        TheInventory.DataInventoryFULL[myKey] = 0;
                        TheInventory.DataInventoryHALF[myKey] = 0;
                    }
                    TheInventory.Rewrite();
                }
            }
            UpdateView();
        }

        private void btnFoodBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
