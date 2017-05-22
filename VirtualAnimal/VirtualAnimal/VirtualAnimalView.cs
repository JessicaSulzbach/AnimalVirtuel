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
        private string animName;
        private Image background;
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

        public Image Background
        {
            get { return background; }
            set { background = value; }
        }
        #endregion

        #region Constructor
        public VirtualAnimalView()
        {
            InitializeComponent();

            DoubleBuffered = true;

            pbxAnimalAnimation.BackColor = Color.Transparent;
            Background = Properties.Resources.BackgroundHome;

            TheAnimal = new Animal();
            SaveOrRecover = new DataRecovery();
            TheInventory = new Inventory();

            time = 0;
            TheAnimal.NumImage = 0;
            animName = "";
        }
        #endregion

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            // Initializes the necessary components 
            ProgressBarInitialize();
            AnimationsInitialize();

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
            if (TheAnimal.Health > 0)
            {
                TheAnimal.Health--;
            }
            if (TheAnimal.Hygene > 0)
            {
                TheAnimal.Hygene--;
            }

            if (TheAnimal.Energy > 0)
            {
                TheAnimal.Energy--;
            }
            if (TheAnimal.Happiness > 0)
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

        private void tsmPet_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Happy";
            TheAnimal.Animations("Happy");
            UpdateProgressBar();
        }

        private void tsmSleep_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Sleep";
            TheAnimal.Animations(animName);
            UpdateProgressBar();

        }

        private void tsmNap_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Sleep";
            TheAnimal.Animations("Nap");
            UpdateProgressBar();
        }

        private void tsmWalk_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Walk";
            TheAnimal.Animations(animName);
            UpdateProgressBar();
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
            TheAnimal.Animations(TheInventory.Product);
            UpdateProgressBar();
            AnimationsInitialize();
        }

        #endregion

        #region Animations
        private void AnimationsInitialize()
        {
            tmrAnimalAnimations.Enabled = true;
            tmrAnimalAnimations.Start();
            tmrAnimalAnimations.Interval = 150;
        }

        private void updateAnim(int numImage)
        {
            this.pbxAnimalAnimation.Image = TheAnimal.Anim[numImage];
        }

        private void tmrAnimalAnimations_Tick(object sender, EventArgs e)
        {
            if (animName == "Happy" || TheInventory.Product == "Happy")
            {
                if (time <= 8)
                {
                    if (TheAnimal.NumImage <= 8)
                    {
                        updateAnim(TheAnimal.NumImage);
                        time++;
                        TheAnimal.NumImage++;
                    }
                }
                else
                {
                    time = 0;
                    TheAnimal.Animations("Idle");
                    animName = "Idle";
                    TheInventory.Product = "Idle";
                }
            }
            else if (animName == "Sleep" || animName == "Nap")
            {
                if (time <= 18)
                {
                    if (TheAnimal.NumImage <= 18)
                    {
                        updateAnim(TheAnimal.NumImage);
                        time++;
                        TheAnimal.NumImage++;
                    }
                }
                else
                {
                    time = 0;
                    TheAnimal.Animations("Idle");
                    animName = "Idle";
                }
            }
            else if (animName == "Walk")
            {
                if (time <= 20)
                {
                    if (TheAnimal.NumImage == 0)
                    {
                        TheAnimal.NumImage = 1;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                    else
                    {
                        TheAnimal.NumImage = 0;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                }
                else
                {
                    time = 0;
                    TheAnimal.Animations("Idle");
                    animName = "Idle";
                }
            }
            else if (TheInventory.Product == "Eat")
            {
                if (time <= 10)
                {
                    if (TheAnimal.NumImage == 0)
                    {
                        TheAnimal.NumImage = 1;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                    else
                    {
                        TheAnimal.NumImage = 0;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                }
                else
                {
                    time = 0;
                    TheAnimal.Animations("Idle");
                    TheInventory.Product = "Idle";
                }
            }
            else if (TheInventory.Product == "Shower")
            {
                Background = Properties.Resources.ShowerBackground;
                if (time <= 14)
                {
                    if (TheAnimal.NumImage <= 7)
                    {
                        updateAnim(TheAnimal.NumImage);
                        time++;
                        TheAnimal.NumImage++;
                    }
                    else
                    {
                        TheAnimal.NumImage = 0;
                    }
                }
                else
                {
                    time = 0;
                    Background = Properties.Resources.BackgroundHome;
                    TheAnimal.Animations("Idle");
                    TheInventory.Product = "Idle";

                }
                this.Refresh();
            }
            else if (TheInventory.Product == "Brush")
            {
                if (time <= 10)
                {
                    if (TheAnimal.NumImage == 0)
                    {
                        TheAnimal.NumImage = 1;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                    else
                    {
                        TheAnimal.NumImage = 0;
                        updateAnim(TheAnimal.NumImage);
                        time++;
                    }
                }
                else
                {
                    time = 0;
                    TheAnimal.Animations("Idle");
                    TheInventory.Product = "Idle";
                }
            }
            else if (animName == "Idle" || TheInventory.Product == "Idle")
            {
                if (TheAnimal.NumImage <= 1)
                {
                    updateAnim(TheAnimal.NumImage);
                    TheAnimal.NumImage++;
                }
                else
                {
                    updateAnim(TheAnimal.NumImage);
                    TheAnimal.NumImage = 0;
                }

            }
        }

        private void VirtualAnimalView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Background, 218, 12);
        }
        #endregion

        private void VirtualAnimalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrProgressBar.Enabled = false;

            this.TheAnimal.Animal_Save(TheAnimal.Health, TheAnimal.Hygene, TheAnimal.Energy, TheAnimal.Happiness);
        }
    }
}