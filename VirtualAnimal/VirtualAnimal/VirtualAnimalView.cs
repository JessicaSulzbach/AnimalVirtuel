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
        public VirtualAnimalView()
        {
            InitializeComponent();

            // To report progress from the background worker it has to be activated
            bgwForProgressBar.WorkerReportsProgress = true;

            // This event will be called when the worker starts
            bgwForProgressBar.DoWork += new DoWorkEventHandler(bgwForProgressBar_DoWork);

            // This event will be called when ReportProgress is called
            bgwForProgressBar.ProgressChanged += new ProgressChangedEventHandler(bgwForProgressBar_ProgressChanged);

        }

        private void VirtualAnimalView_Load(object sender, EventArgs e)
        {
            // Starts the background worker
            bgwForProgressBar.RunWorkerAsync();
            
            prbHealth.Value = 100;
        }

        private void bgwForProgressBar_DoWork(object sender, DoWorkEventArgs e)
        {
            bool DoItAgain = true;

            while(DoItAgain == true)
            {
                if (prbHealth.Value != 0)
                {
                    // Report progress to 'UI' thread
                    bgwForProgressBar.ReportProgress(prbHealth.Value - 1);

                    // Simulate long task (wait)
                    System.Threading.Thread.Sleep(100);
                }
            }     
        }

        private void bgwForProgressBar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            prbHealth.Value = e.ProgressPercentage;

        }

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

        private void tsmStore_Click(object sender, EventArgs e)
        {
            VirtualAnimalStore store = new VirtualAnimalStore();
            store.Show();
        }

    }
}

