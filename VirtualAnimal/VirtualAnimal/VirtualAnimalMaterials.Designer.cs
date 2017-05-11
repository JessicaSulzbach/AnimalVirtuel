namespace VirtualAnimal
{
    partial class VirtualAnimalMaterials
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
            this.btnMaterialsUse = new System.Windows.Forms.Button();
            this.btnMaterialsSell = new System.Windows.Forms.Button();
            this.btnMaterialsBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterialsUse
            // 
            this.btnMaterialsUse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsUse.Location = new System.Drawing.Point(12, 184);
            this.btnMaterialsUse.Name = "btnMaterialsUse";
            this.btnMaterialsUse.Size = new System.Drawing.Size(112, 30);
            this.btnMaterialsUse.TabIndex = 1;
            this.btnMaterialsUse.Text = "Utiliser";
            this.btnMaterialsUse.UseVisualStyleBackColor = true;
            // 
            // btnMaterialsSell
            // 
            this.btnMaterialsSell.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsSell.Location = new System.Drawing.Point(150, 184);
            this.btnMaterialsSell.Name = "btnMaterialsSell";
            this.btnMaterialsSell.Size = new System.Drawing.Size(112, 30);
            this.btnMaterialsSell.TabIndex = 2;
            this.btnMaterialsSell.Text = "Vendre";
            this.btnMaterialsSell.UseVisualStyleBackColor = true;
            // 
            // btnMaterialsBack
            // 
            this.btnMaterialsBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsBack.Location = new System.Drawing.Point(12, 220);
            this.btnMaterialsBack.Name = "btnMaterialsBack";
            this.btnMaterialsBack.Size = new System.Drawing.Size(250, 30);
            this.btnMaterialsBack.TabIndex = 3;
            this.btnMaterialsBack.Text = "Retour";
            this.btnMaterialsBack.UseVisualStyleBackColor = true;
            this.btnMaterialsBack.Click += new System.EventHandler(this.btnMaterialsBack_Click);
            // 
            // VirtualAnimalMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 263);
            this.Controls.Add(this.btnMaterialsBack);
            this.Controls.Add(this.btnMaterialsSell);
            this.Controls.Add(this.btnMaterialsUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VirtualAnimalMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire : Matériaux";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterialsUse;
        private System.Windows.Forms.Button btnMaterialsSell;
        private System.Windows.Forms.Button btnMaterialsBack;
    }
}