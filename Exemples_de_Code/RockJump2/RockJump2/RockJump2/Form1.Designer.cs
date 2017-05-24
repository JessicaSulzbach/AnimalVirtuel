namespace RockJump2
{
    partial class RockJump2
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
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pibPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score : ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(254, 431);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(451, 39);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Appuyer sur la barre espace";
            // 
            // pibPlayer
            // 
            this.pibPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pibPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibPlayer.Location = new System.Drawing.Point(60, 330);
            this.pibPlayer.Name = "pibPlayer";
            this.pibPlayer.Size = new System.Drawing.Size(70, 50);
            this.pibPlayer.TabIndex = 0;
            this.pibPlayer.TabStop = false;
            // 
            // RockJump2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 500);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pibPlayer);
            this.Name = "RockJump2";
            this.Text = "RockJump";
            this.Load += new System.EventHandler(this.RockJump2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RockJump2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RockJump2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pibPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox pibPlayer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStart;
    }
}

