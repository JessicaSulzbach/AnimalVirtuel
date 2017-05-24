namespace BinairyCards
{
    partial class BinairyCardView
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
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModeManuel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModeAutomatique = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumOfCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTwoCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThreeCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFourCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFiveCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSixCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSevenCards = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxCards = new System.Windows.Forms.GroupBox();
            this.gbxBinaryValue = new System.Windows.Forms.GroupBox();
            this.gbxCalculations = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tmrAutomatic = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.mspMenu.SuspendLayout();
            this.gbxCalculations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(865, 24);
            this.mspMenu.TabIndex = 8;
            this.mspMenu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 22);
            this.tsmiExit.Text = "Quitter";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModeManuel,
            this.tsmiModeAutomatique,
            this.tsmiNumOfCards,
            this.tsmiShowAll,
            this.tsmiHideAll});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // tsmiModeManuel
            // 
            this.tsmiModeManuel.Name = "tsmiModeManuel";
            this.tsmiModeManuel.Size = new System.Drawing.Size(206, 22);
            this.tsmiModeManuel.Text = "Mode manuel";
            this.tsmiModeManuel.Click += new System.EventHandler(this.tsmiModeManuel_Click);
            // 
            // tsmiModeAutomatique
            // 
            this.tsmiModeAutomatique.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUp,
            this.tmsiDown});
            this.tsmiModeAutomatique.Name = "tsmiModeAutomatique";
            this.tsmiModeAutomatique.Size = new System.Drawing.Size(206, 22);
            this.tsmiModeAutomatique.Text = "Mode automatique";
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(152, 22);
            this.tsmiUp.Text = "Croissant";
            this.tsmiUp.Click += new System.EventHandler(this.tsmiUp_Click);
            // 
            // tmsiDown
            // 
            this.tmsiDown.Name = "tmsiDown";
            this.tmsiDown.Size = new System.Drawing.Size(152, 22);
            this.tmsiDown.Text = "Decroissant";
            this.tmsiDown.Click += new System.EventHandler(this.tmsiDown_Click);
            // 
            // tsmiNumOfCards
            // 
            this.tsmiNumOfCards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTwoCards,
            this.tsmiThreeCards,
            this.tsmiFourCards,
            this.tsmiFiveCards,
            this.tsmiSixCards,
            this.tsmiSevenCards,
            this.toolStripMenuItem8});
            this.tsmiNumOfCards.Name = "tsmiNumOfCards";
            this.tsmiNumOfCards.Size = new System.Drawing.Size(206, 22);
            this.tsmiNumOfCards.Text = "Nombre de carte";
            // 
            // tsmiTwoCards
            // 
            this.tsmiTwoCards.Name = "tsmiTwoCards";
            this.tsmiTwoCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiTwoCards.Text = "2";
            this.tsmiTwoCards.Click += new System.EventHandler(this.tsmiTwoCards_Click);
            // 
            // tsmiThreeCards
            // 
            this.tsmiThreeCards.Name = "tsmiThreeCards";
            this.tsmiThreeCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiThreeCards.Text = "3";
            this.tsmiThreeCards.Click += new System.EventHandler(this.tsmiThreeCards_Click);
            // 
            // tsmiFourCards
            // 
            this.tsmiFourCards.Name = "tsmiFourCards";
            this.tsmiFourCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiFourCards.Text = "4";
            this.tsmiFourCards.Click += new System.EventHandler(this.tsmiFourCards_Click);
            // 
            // tsmiFiveCards
            // 
            this.tsmiFiveCards.Name = "tsmiFiveCards";
            this.tsmiFiveCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiFiveCards.Text = "5";
            this.tsmiFiveCards.Click += new System.EventHandler(this.tsmiFiveCards_Click);
            // 
            // tsmiSixCards
            // 
            this.tsmiSixCards.Name = "tsmiSixCards";
            this.tsmiSixCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiSixCards.Text = "6";
            this.tsmiSixCards.Click += new System.EventHandler(this.tsmiSixCards_Click);
            // 
            // tsmiSevenCards
            // 
            this.tsmiSevenCards.Name = "tsmiSevenCards";
            this.tsmiSevenCards.Size = new System.Drawing.Size(80, 22);
            this.tsmiSevenCards.Text = "7";
            this.tsmiSevenCards.Click += new System.EventHandler(this.tsmiSevenCards_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem8.Text = "8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // tsmiShowAll
            // 
            this.tsmiShowAll.Name = "tsmiShowAll";
            this.tsmiShowAll.Size = new System.Drawing.Size(206, 22);
            this.tsmiShowAll.Text = "Retourner toutes les cartes";
            this.tsmiShowAll.Click += new System.EventHandler(this.tsmiShowAll_Click);
            // 
            // tsmiHideAll
            // 
            this.tsmiHideAll.Name = "tsmiHideAll";
            this.tsmiHideAll.Size = new System.Drawing.Size(206, 22);
            this.tsmiHideAll.Text = "Cacher toutes les cartes";
            this.tsmiHideAll.Click += new System.EventHandler(this.tsmiHideAll_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // gbxCards
            // 
            this.gbxCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCards.Location = new System.Drawing.Point(12, 115);
            this.gbxCards.Name = "gbxCards";
            this.gbxCards.Size = new System.Drawing.Size(841, 169);
            this.gbxCards.TabIndex = 12;
            this.gbxCards.TabStop = false;
            this.gbxCards.Text = "Cartes binaires";
            // 
            // gbxBinaryValue
            // 
            this.gbxBinaryValue.Location = new System.Drawing.Point(12, 27);
            this.gbxBinaryValue.Name = "gbxBinaryValue";
            this.gbxBinaryValue.Size = new System.Drawing.Size(841, 82);
            this.gbxBinaryValue.TabIndex = 13;
            this.gbxBinaryValue.TabStop = false;
            this.gbxBinaryValue.Text = "Nombre binaire correspondant";
            // 
            // gbxCalculations
            // 
            this.gbxCalculations.Controls.Add(this.groupBox1);
            this.gbxCalculations.Location = new System.Drawing.Point(8, 290);
            this.gbxCalculations.Name = "gbxCalculations";
            this.gbxCalculations.Size = new System.Drawing.Size(845, 83);
            this.gbxCalculations.TabIndex = 14;
            this.gbxCalculations.TabStop = false;
            this.gbxCalculations.Text = "Calcul de la valeur décimal";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcul de la valeur décimal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(8, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 83);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat du calcul";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(401, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(4, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(845, 83);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calcul de la valeur décimal";
            // 
            // tmrAutomatic
            // 
            this.tmrAutomatic.Tick += new System.EventHandler(this.tmrAutomatic_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMode
            // 
            this.tsslMode.Name = "tsslMode";
            this.tsslMode.Size = new System.Drawing.Size(70, 17);
            this.tsslMode.Text = "Mode manuel";
            // 
            // BinairyCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxCalculations);
            this.Controls.Add(this.gbxBinaryValue);
            this.Controls.Add(this.gbxCards);
            this.Controls.Add(this.mspMenu);
            this.Name = "BinairyCardView";
            this.Text = "Form1";
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.gbxCalculations.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeManuel;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeAutomatique;
        private System.Windows.Forms.ToolStripMenuItem tsmiUp;
        private System.Windows.Forms.ToolStripMenuItem tmsiDown;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxCards;
        private System.Windows.Forms.GroupBox gbxBinaryValue;
        private System.Windows.Forms.GroupBox gbxCalculations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer tmrAutomatic;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumOfCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiTwoCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiThreeCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiFourCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiFiveCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiSixCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiSevenCards;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiHideAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMode;
    }
}

