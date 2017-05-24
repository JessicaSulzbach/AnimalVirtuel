namespace VirtualAnimal
{
    partial class VirtualAnimalStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualAnimalStore));
            this.btnBuyAndBack = new System.Windows.Forms.Button();
            this.bntBack = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblWallet = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tlpStore = new System.Windows.Forms.TableLayoutPanel();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuyAndBack
            // 
            this.btnBuyAndBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyAndBack.Location = new System.Drawing.Point(318, 150);
            this.btnBuyAndBack.Name = "btnBuyAndBack";
            this.btnBuyAndBack.Size = new System.Drawing.Size(250, 30);
            this.btnBuyAndBack.TabIndex = 0;
            this.btnBuyAndBack.Text = "Acheter et rentrer";
            this.btnBuyAndBack.UseVisualStyleBackColor = true;
            this.btnBuyAndBack.Click += new System.EventHandler(this.btnBuyAndBack_Click);
            // 
            // bntBack
            // 
            this.bntBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBack.Location = new System.Drawing.Point(318, 253);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(250, 30);
            this.bntBack.TabIndex = 1;
            this.bntBack.Text = "Rentrer";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(318, 201);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(250, 30);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Acheter";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(315, 9);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(148, 18);
            this.lblWallet.TabIndex = 3;
            this.lblWallet.Text = "Porte monnaie :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(315, 74);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(104, 18);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Prix total : ";
            // 
            // tlpStore
            // 
            this.tlpStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpStore.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpStore.ColumnCount = 3;
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66666F));
            this.tlpStore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpStore.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpStore.Location = new System.Drawing.Point(12, 12);
            this.tlpStore.Name = "tlpStore";
            this.tlpStore.RowCount = 8;
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpStore.Size = new System.Drawing.Size(297, 275);
            this.tlpStore.TabIndex = 5;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(469, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 18);
            this.lblMoney.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(425, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 18);
            this.lblPrice.TabIndex = 8;
            // 
            // VirtualAnimalStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 299);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.tlpStore);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWallet);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.bntBack);
            this.Controls.Add(this.btnBuyAndBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VirtualAnimalStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Magasin";
            this.Load += new System.EventHandler(this.VirtualAnimalStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyAndBack;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tlpStore;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPrice;
    }
}