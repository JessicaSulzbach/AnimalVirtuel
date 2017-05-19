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

        #region Variables
        private Animal _theAnimal;
        private DataRecovery _saveOrRecover;
        private Inventory _theInventory;
        private int time;
        private int numImage;
        private string animName;
        #endregion

        #region Properties
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

        internal Inventory TheInventory
        {
            get { return _theInventory; }
            set { _theInventory = value; }
        }
        #endregion

        #region Constructor
        public VirtualAnimalView()
        {
            InitializeComponent();

            TheAnimal = new Animal();
            SaveOrRecover = new DataRecovery();
            TheInventory = new Inventory();

            time =0;
            numImage = 0;
            animName = "";
        }
        #endregion

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            // Initializes the necessary components 
            ProgressBarInitialize();
        }

        #region ProgressBar
        private void ProgressBarInitialize()
        {
            // Iniciates the value of the progress bar 
            UpdateProgressBar();

            tmrProgressBar.Enabled = true;
            tmrProgressBar.Start();
            tmrProgressBar.Interval = 1000;
        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {
            if (TheAnimal.Health != 0)
            {
                TheAnimal.Health--;
            }
            if (TheAnimal.Hygene != 0)
            {
                TheAnimal.Hygene--;
            }

            if (TheAnimal.Energy != 0)
            {
                TheAnimal.Energy--;
            }
            if (TheAnimal.Happiness != 0)
            {
                TheAnimal.Happiness--;
            }

            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            prbEnergy.Value = TheAnimal.Energy;

            prbHappiness.Value = TheAnimal.Happiness;

            prbHealth.Value = TheAnimal.Health;

            prbHygene.Value = TheAnimal.Hygene;
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
            VirtualAnimalFood food = new VirtualAnimalFood(TheInventory);
            food.ShowDialog(this);
            TheAnimal.Animations(TheInventory.Product);
            UpdateProgressBar();
            AnimationsInitialize();
        }

        private void tsmMaterials_Click(object sender, EventArgs e)
        {
            VirtualAnimalMaterials materials = new VirtualAnimalMaterials(TheInventory);
            materials.ShowDialog(this);
        }

        #endregion

        private void tsmPet_Click(object sender, EventArgs e)
        {
            TheAnimal.Animations("Happy");
            UpdateProgressBar();
        }

        private void tsmSleep_Click(object sender, EventArgs e)
        {
            //time = 0;
            //numImage = 0;
            animName = "Sleep";
            TheAnimal.Animations(animName);
            UpdateProgressBar();
            AnimationsInitialize();
        }

        private void tsmNap_Click(object sender, EventArgs e)
        {
            TheAnimal.Animations("Nap");
            UpdateProgressBar();
        }

        #region Animations
        private void AnimationsInitialize()
        {
            tmrAnimalAnimations.Enabled = true;
            tmrAnimalAnimations.Start();
            tmrAnimalAnimations.Interval = 500;
        }

        private void updateAnim(int numImage)
        {
            this.pbxAnimalAnimation.Image = TheAnimal.Anim[numImage];
        }

        private void tmrAnimalAnimations_Tick(object sender, EventArgs e)
        {
            if (TheInventory.Product == "Eat")
            {
                if (time <= 10)
                {
                    if (numImage == 0)
                    {
                        updateAnim(numImage);
                        numImage = 1;
                        time++;
                    }
                    else
                    {
                        updateAnim(numImage);
                        numImage = 0;
                        time++;
                    }
                }
                else
                {
                    pbxAnimalAnimation.Image = null;
                    tmrAnimalAnimations.Stop();
                    time = 0;
                }
            }
            else if (animName == "Sleep" || animName == "Nap")
            {
                if (time <= 16)
                {
                    if(numImage!=17)
                    {
                        updateAnim(numImage);
                        time++;
                        numImage++;
                    }
                }
                else
                {
                    pbxAnimalAnimation.Image = null;
                    tmrAnimalAnimations.Stop();
                    time = 0;
                }
            }
        }
        #endregion

        private void VirtualAnimalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrProgressBar.Enabled = false;

            this.TheAnimal.Animal_Save(TheAnimal.Health, TheAnimal.Hygene, TheAnimal.Energy, TheAnimal.Happiness);
        }
    }
}