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
        Animal TheAnimal = new Animal();

        public VirtualAnimalView()
        {
            InitializeComponent();

            ProgressBarInitialize();
        }

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            // Starts the background worker
            bgwForProgressBar.RunWorkerAsync();

            // Iniciates the value of the progress bar 
            prbEnergy.Value = TheAnimal.Energy;
            prbHealth.Value = TheAnimal.Health;
            prbHygene.Value = TheAnimal.Hygene;
            prbHappiness.Value = TheAnimal.Happiness;
            
        }

        #region ProgressBarTimer

        private void ProgressBarInitialize()
        {
            // To report progress from the background worker it has to be activated
            bgwForProgressBar.WorkerReportsProgress = true;
            // This event will be called when the worker starts
            bgwForProgressBar.DoWork += new DoWorkEventHandler(bgwForProgressBar_DoWork);
            // This event will be called when ReportProgress is called
            bgwForProgressBar.ProgressChanged += new ProgressChangedEventHandler(bgwForProgressBar_ProgressChanged);
        }

        private void bgwForProgressBar_DoWork(object sender, DoWorkEventArgs e)
        {
            // Always true
            bool DoItAgain = true;

            while(DoItAgain == true)
            {
                if (prbHealth.Value != 0)
                {
                    // Report progress to 'UI' thread
                    bgwForProgressBar.ReportProgress(prbHealth.Value - 1); 
                }
                if (prbEnergy.Value != 0)
                {
                    // Report progress to 'UI' thread
                     bgwForProgressBar.ReportProgress(prbEnergy.Value - 1); 
                }
                if (prbHygene.Value != 0)
                {
                    // Report progress to 'UI' thread
                    bgwForProgressBar.ReportProgress(prbHygene.Value - 1);  
                }
                if (prbHappiness.Value != 0)
                {
                    // Report progress to 'UI' thread
                    bgwForProgressBar.ReportProgress(prbHappiness.Value - 1);  
                }

                // Simulate long task (wait)
                System.Threading.Thread.Sleep(500);
            }     
        }

        private void bgwForProgressBar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            prbHealth.Value = e.ProgressPercentage;
            prbHappiness.Value = e.ProgressPercentage;
            prbHygene.Value = e.ProgressPercentage;
            prbEnergy.Value = e.ProgressPercentage;
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
    }
}

