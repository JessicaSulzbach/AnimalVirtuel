/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI
 * Name         : VirtualAnimalView
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
        // Background image
        private Image background;
        // Animation variables (time and animation name)
        private int time;
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

            // Transparent background for the animal pictureBox
            pbxAnimalAnimation.BackColor = Color.Transparent;
            // Set the home background image
            Background = Properties.Resources.BackgroundHome;

            // Iniciate class
            TheAnimal = new Animal();
            SaveOrRecover = new DataRecovery();
            TheInventory = new Inventory();

            // Reset the animation variables
            time = 0;
            TheAnimal.NumImage = 0;
            animName = "";
            TheInventory.Product = "";
        }
        #endregion

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            if (TheAnimal.Age == 0)
            {
                time = 0;
                TheInventory.RewriteNew();
                TheAnimal.NumImage = 0;
                animName = "Born";
                TheAnimal.Animations(animName);
                pbxAnimalAnimation.Location = new Point(234, 114);
                gbxProgressBar.Visible = false;
                pbxSmileyFace.Visible = false;
            }else
            {
                pbxAnimalAnimation.Location = new Point(352, 187);
                animName = "Idle";
                TheAnimal.Animations(animName);
            }

                // Iniciate the necessary components for ProgressBar and Animations (value and timer)
                AnimationsInitialize();
                ProgressBarInitialize();

        }

        #region ProgressBar
        /// <summary>
        /// Iniciates the progressBars value and timer
        /// </summary>
        private void ProgressBarInitialize()
        {
            // Iniciates the progressBars value
            UpdateProgressBar();

            // Iniciates the progressBars timer
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

            if (TheAnimal.Happiness <= 0 || TheAnimal.Health <= 0 || TheAnimal.Hygene <= 0 || TheAnimal.Energy <= 0)
            {
                animName = "Death";
                TheAnimal.NumImage = 0;
                time = 0;
                TheAnimal.Animations(animName);
                TheInventory.Product = "";
                tmrProgressBar.Stop();
            }
            
            // According to life levels the smiley image will change
            // Condition : The life levels have to be bigger than 50 and smaller then 69
            if ((TheAnimal.Happiness > 50 && TheAnimal.Happiness < 69) || (TheAnimal.Health > 50 && TheAnimal.Health < 69) || (TheAnimal.Hygene > 50 && TheAnimal.Hygene < 69) || (TheAnimal.Energy > 50 && TheAnimal.Energy < 69))
            {
                pbxSmileyFace.Image = Properties.Resources.MiddleFace;
            }
            // Condition : The life levels have to smaller than 20 or equal 20
            else if (TheAnimal.Happiness <= 20 || TheAnimal.Health <= 20 || TheAnimal.Hygene <= 20 || TheAnimal.Energy <= 20)
            {
                pbxSmileyFace.Image = Properties.Resources.SadFace;
            }
            // Condition : The life levels are high
            else
            {
                pbxSmileyFace.Image = Properties.Resources.HappyFace;
            }

            // Counts the aniamls age by seconde
            TheAnimal.Age++;

            // Updates the progressBar life levels
            UpdateProgressBar();
        }

        /// <summary>
        /// Updates the progressBar life levels with the life level values
        /// </summary>
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
            // Opens the contextMenuStrip under the button, giving the illusion of a dropdown button
            cmsForAnimalButton.Show(btnAnimal, new Point(0, btnAnimal.Height));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            // Opens the contextMenuStrip under the button, giving the illusion of a dropdown button
            cmsForInventoryButton.Show(btnInventory, new Point(0, btnInventory.Height));
        }

        private void btnGoOut_Click(object sender, EventArgs e)
        {
            // Opens the contextMenuStrip under the button, giving the illusion of a dropdown button
            cmsForGoOutButton.Show(btnGoOut, new Point(0, btnGoOut.Height));
        }

        /// <summary>
        /// Prepares the images and updates the life levels for animation HAPPY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmPet_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Happy";
            TheAnimal.Animations("Happy");
            UpdateProgressBar();
        }

        /// <summary>
        /// Prepares the images and updates the life levels for animation SLEEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSleep_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Sleep";
            TheAnimal.Animations(animName);
            UpdateProgressBar();

        }

        /// <summary>
        /// Prepares the images for animation SLEEP and updates the life levels for NAP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmNap_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Sleep";
            TheAnimal.Animations("Nap");
            UpdateProgressBar();
        }

        /// <summary>
        /// Prepares the images and updates the life levels for animation Walk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmWalk_Click(object sender, EventArgs e)
        {
            TheAnimal.NumImage = 0;
            animName = "Walk";
            TheInventory.Product = "";
            TheAnimal.Animations(animName);
            UpdateProgressBar();
        }
        #endregion

        #region OpenForms
        // Opens the store view as the child of VirtualAnimalView
        private void tsmStore_Click(object sender, EventArgs e)
        {
            VirtualAnimalStore store = new VirtualAnimalStore();
            store.ShowDialog(this);
        }

        // Opens the food view as the child of VirtualAnimalView
        private void tsmFood_Click(object sender, EventArgs e)
        {
            VirtualAnimalFood food = new VirtualAnimalFood(TheInventory);
            food.ShowDialog(this);

            // Iniciates the images and updates progressBar according to the Product use
            TheAnimal.Animations(TheInventory.Product);
            UpdateProgressBar();
        }

        // Opens the materials view as the child of VirtualAnimalView
        private void tsmMaterials_Click(object sender, EventArgs e)
        {
            VirtualAnimalMaterials materials = new VirtualAnimalMaterials(TheInventory);
            materials.ShowDialog(this);

            // Iniciates the images and updates progressBar according to the Product use
            TheAnimal.Animations(TheInventory.Product);
            UpdateProgressBar();
        }

        #endregion

        #region Animations
        private void AnimationsInitialize()
        {
            // Iniciates the animation timer
            tmrAnimalAnimations.Enabled = true;
            tmrAnimalAnimations.Start();
            tmrAnimalAnimations.Interval = 150;
        }

        /// <summary>
        /// Updates the image in the pictureBox
        /// </summary>
        /// <param name="numImage">The image number</param>
        private void updateAnim(int numImage)
        {
            this.pbxAnimalAnimation.Image = TheAnimal.Anim[numImage];
        }

        /// <summary>
        /// Every tick it checks for conditions. If conditions are true then a animation will start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Background = Properties.Resources.WalkBackground;
                lblGift.Visible = false;
                if (time <= 25)
                {
                    if (TheAnimal.Gifts.ContainsKey(time))
                    {
                        lblGift.Text = " + " + Convert.ToString(TheAnimal.Gifts[time]);
                        lblGift.Visible = true;
                        TheAnimal.Money += TheAnimal.Gifts[time];
                    }
                    if (time == 0)
                    {
                        pbxAnimalAnimation.Location = new Point(218, 165);
                    }
                    if (TheAnimal.NumImage == 0)
                    {
                        TheAnimal.NumImage = 1;
                        updateAnim(TheAnimal.NumImage);
                    }
                    else
                    {
                        TheAnimal.NumImage = 0;
                        updateAnim(TheAnimal.NumImage);
                    }
                    time++;
                    pbxAnimalAnimation.Left += 10;
                }
                else
                {
                    time = 0;
                    Background = Properties.Resources.BackgroundHome;
                    pbxAnimalAnimation.Location = new Point(352, 187);
                    TheAnimal.Animations("Idle");
                    animName = "Idle";
                }
                this.Refresh();
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
            else if (animName == "Death")
            {
                if (time <= 4)
                {
                    if (TheAnimal.NumImage <= 4)
                    {
                        updateAnim(TheAnimal.NumImage);
                        time++;
                        TheAnimal.NumImage++;
                    }
                }
                else
                {
                    animName = "";
                    string playerClass = "";
                    if(this.TheAnimal.Age <= 599)
                    {
                        playerClass = "Il faut fair plus d'effort!";
                    }
                    else if(this.TheAnimal.Age >= 600 && this.TheAnimal.Age <=1099)
                    {
                        playerClass = "Il y a une marge d'améliorations!";
                    }
                    else if (this.TheAnimal.Age >= 1100 && this.TheAnimal.Age <= 1699)
                    {
                        playerClass = "Bien jouer!";
                    }
                    else if (this.TheAnimal.Age >= 1700 && this.TheAnimal.Age <= 2299)
                    {
                        playerClass = "Excellent!";
                    }
                    else if (this.TheAnimal.Age >= 2300)
                    {
                        playerClass = "Incroyable!!";
                    }

                    MessageBox.Show("R.I.P " + this.TheAnimal.Name+ "..." + playerClass, "Game over", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    time = 0;
                    TheAnimal.Age = 0;
                    TheInventory.RewriteNew();
                    TheAnimal.NumImage = 0;
                    animName = "Born";
                    TheAnimal.Animations(animName);
                    pbxAnimalAnimation.Location = new Point(234, 114);
                    gbxProgressBar.Visible = false;
                    pbxSmileyFace.Visible = false;
                }
            }
            else if (animName == "Born")
            {
                Background = Properties.Resources.background;
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
                    lblName.Visible = true;
                    tbxName.Visible = true;
                    btnStart.Visible = true; 
                }
                this.Refresh();
            }
        }

        private void VirtualAnimalView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Background, 218, 12, 350, 297);
        }
        #endregion

        private void VirtualAnimalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrProgressBar.Enabled = false;

            this.TheAnimal.AnimalSave(TheAnimal.Health);
            this.TheAnimal.AnimalSave(TheAnimal.Hygene);
            this.TheAnimal.AnimalSave(TheAnimal.Energy);
            this.TheAnimal.AnimalSave(TheAnimal.Happiness);
            this.TheAnimal.AnimalSave(Convert.ToInt32(TheAnimal.Money));

            TheAnimal.SaveOrRecover.FirstTime = true;
            this.TheAnimal.SaveOrRecover.FileWritter("Animal_Age_Name.txt", TheAnimal.Name);
            this.TheAnimal.SaveOrRecover.FileWritter("Animal_Age_Name.txt", Convert.ToString(TheAnimal.Age));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TheAnimal.Name = tbxName.Text;
            tbxName.Text = "";

            TheAnimal.SaveOrRecover.FirstTime = true;
            TheAnimal.SaveOrRecover.FileWritter("Animal_Age_Name.txt", TheAnimal.Name);
            TheAnimal.SaveOrRecover.FileWritter("Animal_Age_Name.txt", Convert.ToString(0));

            lblName.Visible = false;
            tbxName.Visible = false;
            btnStart.Visible = false;
            gbxProgressBar.Visible = true;
            pbxSmileyFace.Visible = true;

            background = Properties.Resources.BackgroundHome;
            pbxAnimalAnimation.Location = new Point(353, 165);
            this.Refresh();
            animName = "Idle";
            TheAnimal.Animations(animName);
            AnimationsInitialize();
            ProgressBarInitialize();
        }
    }
}