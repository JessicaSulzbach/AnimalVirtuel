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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualAnimalMaterials));
            this.btnMaterialsUse = new System.Windows.Forms.Button();
            this.btnMaterialsSell = new System.Windows.Forms.Button();
            this.btnMaterialsBack = new System.Windows.Forms.Button();
            this.tlpMaterials = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnMaterialsUse
            // 
            this.btnMaterialsUse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsUse.Location = new System.Drawing.Point(12, 185);
            this.btnMaterialsUse.Name = "btnMaterialsUse";
            this.btnMaterialsUse.Size = new System.Drawing.Size(112, 30);
            this.btnMaterialsUse.TabIndex = 1;
            this.btnMaterialsUse.Text = "Utiliser";
            this.btnMaterialsUse.UseVisualStyleBackColor = true;
            this.btnMaterialsUse.Click += new System.EventHandler(this.btnMaterialsUse_Click);
            // 
            // btnMaterialsSell
            // 
            this.btnMaterialsSell.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsSell.Location = new System.Drawing.Point(150, 185);
            this.btnMaterialsSell.Name = "btnMaterialsSell";
            this.btnMaterialsSell.Size = new System.Drawing.Size(112, 30);
            this.btnMaterialsSell.TabIndex = 2;
            this.btnMaterialsSell.Text = "Vendre";
            this.btnMaterialsSell.UseVisualStyleBackColor = true;
            this.btnMaterialsSell.Click += new System.EventHandler(this.btnMaterialsSell_Click);
            // 
            // btnMaterialsBack
            // 
            this.btnMaterialsBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsBack.Location = new System.Drawing.Point(12, 221);
            this.btnMaterialsBack.Name = "btnMaterialsBack";
            this.btnMaterialsBack.Size = new System.Drawing.Size(250, 30);
            this.btnMaterialsBack.TabIndex = 3;
            this.btnMaterialsBack.Text = "Retour";
            this.btnMaterialsBack.UseVisualStyleBackColor = true;
            this.btnMaterialsBack.Click += new System.EventHandler(this.btnMaterialsBack_Click);
            // 
            // tlpMaterials
            // 
            this.tlpMaterials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpMaterials.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpMaterials.ColumnCount = 2;
            this.tlpMaterials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpMaterials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMaterials.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMaterials.Location = new System.Drawing.Point(12, 12);
            this.tlpMaterials.Name = "tlpMaterials";
            this.tlpMaterials.RowCount = 5;
            this.tlpMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMaterials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMaterials.Size = new System.Drawing.Size(250, 167);
            this.tlpMaterials.TabIndex = 6;
            // 
            // VirtualAnimalMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 263);
            this.Controls.Add(this.btnMaterialsUse);
            this.Controls.Add(this.btnMaterialsBack);
            this.Controls.Add(this.tlpMaterials);
            this.Controls.Add(this.btnMaterialsSell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VirtualAnimalMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire : Matériaux";
            this.Load += new System.EventHandler(this.VirtualAnimalMaterials_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterialsUse;
        private System.Windows.Forms.Button btnMaterialsSell;
        private System.Windows.Forms.Button btnMaterialsBack;
        private System.Windows.Forms.TableLayoutPanel tlpMaterials;
    }
}