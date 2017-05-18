namespace VirtualAnimal
{
    partial class VirtualAnimalFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFoodUse = new System.Windows.Forms.Button();
            this.btnFoodSell = new System.Windows.Forms.Button();
            this.btnFoodBack = new System.Windows.Forms.Button();
            this.tlpFood = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnFoodUse
            // 
            this.btnFoodUse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodUse.Location = new System.Drawing.Point(12, 184);
            this.btnFoodUse.Name = "btnFoodUse";
            this.btnFoodUse.Size = new System.Drawing.Size(112, 30);
            this.btnFoodUse.TabIndex = 0;
            this.btnFoodUse.Text = "Utiliser";
            this.btnFoodUse.UseVisualStyleBackColor = true;
            this.btnFoodUse.Click += new System.EventHandler(this.btnFoodUse_Click);
            // 
            // btnFoodSell
            // 
            this.btnFoodSell.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodSell.Location = new System.Drawing.Point(150, 184);
            this.btnFoodSell.Name = "btnFoodSell";
            this.btnFoodSell.Size = new System.Drawing.Size(112, 30);
            this.btnFoodSell.TabIndex = 1;
            this.btnFoodSell.Text = "Vendre";
            this.btnFoodSell.UseVisualStyleBackColor = true;
            this.btnFoodSell.Click += new System.EventHandler(this.btnFoodSell_Click);
            // 
            // btnFoodBack
            // 
            this.btnFoodBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodBack.Location = new System.Drawing.Point(12, 220);
            this.btnFoodBack.Name = "btnFoodBack";
            this.btnFoodBack.Size = new System.Drawing.Size(250, 30);
            this.btnFoodBack.TabIndex = 2;
            this.btnFoodBack.Text = "Retour";
            this.btnFoodBack.UseVisualStyleBackColor = true;
            this.btnFoodBack.Click += new System.EventHandler(this.btnFoodBack_Click);
            // 
            // tlpFood
            // 
            this.tlpFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpFood.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpFood.ColumnCount = 2;
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFood.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpFood.Location = new System.Drawing.Point(11, 11);
            this.tlpFood.Name = "tlpFood";
            this.tlpFood.RowCount = 4;
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFood.Size = new System.Drawing.Size(250, 167);
            this.tlpFood.TabIndex = 7;
            // 
            // VirtualAnimalFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 263);
            this.Controls.Add(this.tlpFood);
            this.Controls.Add(this.btnFoodBack);
            this.Controls.Add(this.btnFoodSell);
            this.Controls.Add(this.btnFoodUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VirtualAnimalFood";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire : Aliments";
            this.Load += new System.EventHandler(this.VirtualAnimalFood_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFoodUse;
        private System.Windows.Forms.Button btnFoodSell;
        private System.Windows.Forms.Button btnFoodBack;
        private System.Windows.Forms.TableLayoutPanel tlpFood;
    }
}