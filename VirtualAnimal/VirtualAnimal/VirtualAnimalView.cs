using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAnimal
{
    public partial class VirtualAnimalView : Form
    {
        
        private Animal _theAnimal;
        private DataRecovery _saveOrRecover;

        internal DataRecovery SaveOrRecover
        {
            get { return _saveOrRecover; }
            set { _saveOrRecover = value; }
        }
        internal Animal TheAnimal
        {
            get { return _theAnimal; }
            set { _theAnimal = value; }
        }


        public VirtualAnimalView()
        {
            InitializeComponent();

            TheAnimal = new Animal();
            SaveOrRecover = new DataRecovery();

        }

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            // Initializes the necessary components 
            ProgressBarInitialize();
        }

        #region ProgressBar

        private void ProgressBarInitialize()
        {
            // Iniciates the value of the progress bar 
            prbEnergy.Value = TheAnimal.Energy;
            prbHealth.Value = TheAnimal.Health;
            prbHygene.Value = TheAnimal.Hygene;
            prbHappiness.Value = TheAnimal.Happiness;

            tmrProgressBar.Enabled = true;
            tmrProgressBar.Start();
            tmrProgressBar.Interval = 1000;
        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {
            if (prbHealth.Value != 0)
            {
                prbHealth.Value--;
            }
            if (prbEnergy.Value != 0)
            {
                prbEnergy.Value--;
            }
            if (prbHygene.Value != 0)
            {
                prbHygene.Value--;
            }
            if (prbHappiness.Value != 0)
            {
                prbHappiness.Value--;
            }
        }

        #endregion

        #region DropDownButtons

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            cmsForAnimalButton.Show(btnAnimal, new Point(0, btnAnimal.Height));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            cmsForInventoryButton.Show(btnInventory, new Point(0, btnInventory.Height));
        }

        private void btnGoOut_Click(object sender, EventArgs e)
        {
            cmsForGoOutButton.Show(btnGoOut, new Point(0, btnGoOut.Height));
        }

        #endregion

        #region OpenForms

        private void tsmStore_Click(object sender, EventArgs e)
        {
            VirtualAnimalStore store = new VirtualAnimalStore();
            store.ShowDialog(this);
        }

        private void tsmFood_Click(object sender, EventArgs e)
        {
            VirtualAnimalFood food = new VirtualAnimalFood();
            food.ShowDialog(this);
        }

        private void tsmMaterials_Click(object sender, EventArgs e)
        {
            VirtualAnimalMaterials materials = new VirtualAnimalMaterials();
            materials.ShowDialog(this);
        }

        #endregion


        private void VirtualAnimalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            int SavePrbHeath = prbHealth.Value;
            int SavePrbHappiness = prbHappiness.Value;
            int SavePrbHygene = prbHygene.Value;
            int SavePrbEnergy = prbEnergy.Value;

            tmrProgressBar.Enabled = false;

            this.TheAnimal.Animal_Save(SavePrbHeath, SavePrbHappiness, SavePrbHygene, SavePrbEnergy);

        }
    }
}