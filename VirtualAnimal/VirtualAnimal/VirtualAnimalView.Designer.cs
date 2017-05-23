namespace VirtualAnimal
{
    partial class VirtualAnimalView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxProgressBar = new System.Windows.Forms.GroupBox();
            this.prbHappiness = new System.Windows.Forms.ProgressBar();
            this.prbEnergy = new System.Windows.Forms.ProgressBar();
            this.prbHygene = new System.Windows.Forms.ProgressBar();
            this.prbHealth = new System.Windows.Forms.ProgressBar();
            this.lblHappiness = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblHygene = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.cmsForAnimalButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNap = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsForInventoryButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsForGoOutButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWalk = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwForProgressBar = new System.ComponentModel.BackgroundWorker();
            this.tmrProgressBar = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimalAnimations = new System.Windows.Forms.Timer(this.components);
            this.pbxAnimalAnimation = new System.Windows.Forms.PictureBox();
            this.lblGift = new System.Windows.Forms.Label();
            this.pbxSmileyFace = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxProgressBar.SuspendLayout();
            this.cmsForAnimalButton.SuspendLayout();
            this.cmsForInventoryButton.SuspendLayout();
            this.cmsForGoOutButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimalAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmileyFace)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProgressBar
            // 
            this.gbxProgressBar.Controls.Add(this.prbHappiness);
            this.gbxProgressBar.Controls.Add(this.prbEnergy);
            this.gbxProgressBar.Controls.Add(this.prbHygene);
            this.gbxProgressBar.Controls.Add(this.prbHealth);
            this.gbxProgressBar.Controls.Add(this.lblHappiness);
            this.gbxProgressBar.Controls.Add(this.lblEnergy);
            this.gbxProgressBar.Controls.Add(this.lblHygene);
            this.gbxProgressBar.Controls.Add(this.lblHealth);
            this.gbxProgressBar.Location = new System.Drawing.Point(12, 144);
            this.gbxProgressBar.Name = "gbxProgressBar";
            this.gbxProgressBar.Size = new System.Drawing.Size(200, 156);
            this.gbxProgressBar.TabIndex = 0;
            this.gbxProgressBar.TabStop = false;
            // 
            // prbHappiness
            // 
            this.prbHappiness.Location = new System.Drawing.Point(81, 119);
            this.prbHappiness.Name = "prbHappiness";
            this.prbHappiness.Size = new System.Drawing.Size(112, 23);
            this.prbHappiness.TabIndex = 7;
            // 
            // prbEnergy
            // 
            this.prbEnergy.Location = new System.Drawing.Point(81, 83);
            this.prbEnergy.Name = "prbEnergy";
            this.prbEnergy.Size = new System.Drawing.Size(112, 23);
            this.prbEnergy.TabIndex = 6;
            // 
            // prbHygene
            // 
            this.prbHygene.Location = new System.Drawing.Point(81, 47);
            this.prbHygene.Name = "prbHygene";
            this.prbHygene.Size = new System.Drawing.Size(112, 23);
            this.prbHygene.TabIndex = 5;
            // 
            // prbHealth
            // 
            this.prbHealth.Location = new System.Drawing.Point(81, 16);
            this.prbHealth.Name = "prbHealth";
            this.prbHealth.Size = new System.Drawing.Size(112, 23);
            this.prbHealth.TabIndex = 4;
            // 
            // lblHappiness
            // 
            this.lblHappiness.AutoSize = true;
            this.lblHappiness.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappiness.Location = new System.Drawing.Point(35, 124);
            this.lblHappiness.Name = "lblHappiness";
            this.lblHappiness.Size = new System.Drawing.Size(40, 18);
            this.lblHappiness.TabIndex = 3;
            this.lblHappiness.Text = "Joie";
            this.lblHappiness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.Location = new System.Drawing.Point(6, 88);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(69, 18);
            this.lblEnergy.TabIndex = 2;
            this.lblEnergy.Text = "Energie";
            this.lblEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHygene
            // 
            this.lblHygene.AutoSize = true;
            this.lblHygene.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHygene.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHygene.Location = new System.Drawing.Point(1, 52);
            this.lblHygene.Name = "lblHygene";
            this.lblHygene.Size = new System.Drawing.Size(74, 18);
            this.lblHygene.TabIndex = 1;
            this.lblHygene.Text = "Hygiène";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHealth.Location = new System.Drawing.Point(20, 21);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(55, 18);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "Santé";
            // 
            // btnAnimal
            // 
            this.btnAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.Location = new System.Drawing.Point(12, 315);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(112, 30);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(234, 315);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(112, 30);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventaire";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnGoOut
            // 
            this.btnGoOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoOut.Location = new System.Drawing.Point(456, 315);
            this.btnGoOut.Name = "btnGoOut";
            this.btnGoOut.Size = new System.Drawing.Size(112, 30);
            this.btnGoOut.TabIndex = 4;
            this.btnGoOut.Text = "Activités";
            this.btnGoOut.UseVisualStyleBackColor = true;
            this.btnGoOut.Click += new System.EventHandler(this.btnGoOut_Click);
            // 
            // cmsForAnimalButton
            // 
            this.cmsForAnimalButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsForAnimalButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPet,
            this.tsmSleep,
            this.tsmNap});
            this.cmsForAnimalButton.Name = "cmsForAnimalButton";
            this.cmsForAnimalButton.Size = new System.Drawing.Size(148, 70);
            // 
            // tsmPet
            // 
            this.tsmPet.Name = "tsmPet";
            this.tsmPet.Size = new System.Drawing.Size(147, 22);
            this.tsmPet.Text = "Caresser";
            this.tsmPet.Click += new System.EventHandler(this.tsmPet_Click);
            // 
            // tsmSleep
            // 
            this.tsmSleep.Name = "tsmSleep";
            this.tsmSleep.Size = new System.Drawing.Size(147, 22);
            this.tsmSleep.Text = "Dormir";
            this.tsmSleep.Click += new System.EventHandler(this.tsmSleep_Click);
            // 
            // tsmNap
            // 
            this.tsmNap.Name = "tsmNap";
            this.tsmNap.Size = new System.Drawing.Size(147, 22);
            this.tsmNap.Text = "Sieste";
            this.tsmNap.Click += new System.EventHandler(this.tsmNap_Click);
            // 
            // cmsForInventoryButton
            // 
            this.cmsForInventoryButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsForInventoryButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFood,
            this.tsmMaterials});
            this.cmsForInventoryButton.Name = "cmsForAnimaButton";
            this.cmsForInventoryButton.Size = new System.Drawing.Size(157, 48);
            // 
            // tsmFood
            // 
            this.tsmFood.Name = "tsmFood";
            this.tsmFood.Size = new System.Drawing.Size(156, 22);
            this.tsmFood.Text = "Aliments";
            this.tsmFood.Click += new System.EventHandler(this.tsmFood_Click);
            // 
            // tsmMaterials
            // 
            this.tsmMaterials.Name = "tsmMaterials";
            this.tsmMaterials.Size = new System.Drawing.Size(156, 22);
            this.tsmMaterials.Text = "Matériaux";
            this.tsmMaterials.Click += new System.EventHandler(this.tsmMaterials_Click);
            // 
            // cmsForGoOutButton
            // 
            this.cmsForGoOutButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsForGoOutButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStore,
            this.tsmWalk});
            this.cmsForGoOutButton.Name = "cmsForGoOutButton";
            this.cmsForGoOutButton.Size = new System.Drawing.Size(168, 48);
            // 
            // tsmStore
            // 
            this.tsmStore.Name = "tsmStore";
            this.tsmStore.Size = new System.Drawing.Size(167, 22);
            this.tsmStore.Text = "Magasin";
            this.tsmStore.Click += new System.EventHandler(this.tsmStore_Click);
            // 
            // tsmWalk
            // 
            this.tsmWalk.Name = "tsmWalk";
            this.tsmWalk.Size = new System.Drawing.Size(167, 22);
            this.tsmWalk.Text = "Promenade";
            this.tsmWalk.Click += new System.EventHandler(this.tsmWalk_Click);
            // 
            // tmrProgressBar
            // 
            this.tmrProgressBar.Tick += new System.EventHandler(this.tmrProgressBar_Tick);
            // 
            // tmrAnimalAnimations
            // 
            this.tmrAnimalAnimations.Tick += new System.EventHandler(this.tmrAnimalAnimations_Tick);
            // 
            // pbxAnimalAnimation
            // 
            this.pbxAnimalAnimation.Location = new System.Drawing.Point(352, 187);
            this.pbxAnimalAnimation.Name = "pbxAnimalAnimation";
            this.pbxAnimalAnimation.Size = new System.Drawing.Size(100, 99);
            this.pbxAnimalAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAnimalAnimation.TabIndex = 8;
            this.pbxAnimalAnimation.TabStop = false;
            // 
            // lblGift
            // 
            this.lblGift.AutoSize = true;
            this.lblGift.BackColor = System.Drawing.Color.Transparent;
            this.lblGift.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGift.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGift.Location = new System.Drawing.Point(498, 19);
            this.lblGift.Name = "lblGift";
            this.lblGift.Size = new System.Drawing.Size(0, 25);
            this.lblGift.TabIndex = 8;
            // 
            // pbxSmileyFace
            // 
            this.pbxSmileyFace.Location = new System.Drawing.Point(50, 12);
            this.pbxSmileyFace.Name = "pbxSmileyFace";
            this.pbxSmileyFace.Size = new System.Drawing.Size(120, 120);
            this.pbxSmileyFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSmileyFace.TabIndex = 9;
            this.pbxSmileyFace.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(234, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 30);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Commencer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(204, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(165, 27);
            this.tbxName.TabIndex = 10;
            this.tbxName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(161, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(275, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Rentrez le nom de votre animal:";
            this.lblName.Visible = false;
            // 
            // VirtualAnimalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.pbxSmileyFace);
            this.Controls.Add(this.lblGift);
            this.Controls.Add(this.pbxAnimalAnimation);
            this.Controls.Add(this.btnGoOut);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.gbxProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VirtualAnimalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal virtuel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VirtualAnimalView_FormClosing);
            this.Load += new System.EventHandler(this.VirtualAnimalView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VirtualAnimalView_Paint);
            this.gbxProgressBar.ResumeLayout(false);
            this.gbxProgressBar.PerformLayout();
            this.cmsForAnimalButton.ResumeLayout(false);
            this.cmsForInventoryButton.ResumeLayout(false);
            this.cmsForGoOutButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimalAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmileyFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProgressBar;
        private System.Windows.Forms.ProgressBar prbHappiness;
        private System.Windows.Forms.ProgressBar prbEnergy;
        private System.Windows.Forms.ProgressBar prbHygene;
        private System.Windows.Forms.ProgressBar prbHealth;
        private System.Windows.Forms.Label lblHappiness;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblHygene;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnGoOut;
        private System.Windows.Forms.ContextMenuStrip cmsForAnimalButton;
        private System.Windows.Forms.ToolStripMenuItem tsmPet;
        private System.Windows.Forms.ToolStripMenuItem tsmSleep;
        private System.Windows.Forms.ToolStripMenuItem tsmNap;
        private System.Windows.Forms.ContextMenuStrip cmsForInventoryButton;
        private System.Windows.Forms.ToolStripMenuItem tsmFood;
        private System.Windows.Forms.ToolStripMenuItem tsmMaterials;
        private System.Windows.Forms.ContextMenuStrip cmsForGoOutButton;
        private System.Windows.Forms.ToolStripMenuItem tsmStore;
        private System.Windows.Forms.ToolStripMenuItem tsmWalk;
        private System.ComponentModel.BackgroundWorker bgwForProgressBar;
        private System.Windows.Forms.Timer tmrProgressBar;
        private System.Windows.Forms.Timer tmrAnimalAnimations;
        private System.Windows.Forms.PictureBox pbxAnimalAnimation;
        private System.Windows.Forms.Label lblGift;
        private System.Windows.Forms.PictureBox pbxSmileyFace;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
    }
}

