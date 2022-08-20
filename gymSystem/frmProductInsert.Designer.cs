namespace gymSystem
{
    partial class frmProductInsert
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
            this.plClient = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.lblPrize = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.plClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // plClient
            // 
            this.plClient.Controls.Add(this.btnCancel);
            this.plClient.Controls.Add(this.txtPrize);
            this.plClient.Controls.Add(this.lblPrize);
            this.plClient.Controls.Add(this.txtCost);
            this.plClient.Controls.Add(this.lblCost);
            this.plClient.Controls.Add(this.txtSupplier);
            this.plClient.Controls.Add(this.txtBarCode);
            this.plClient.Controls.Add(this.txtNameProduct);
            this.plClient.Controls.Add(this.lblSupplier);
            this.plClient.Controls.Add(this.btnAddNewProduct);
            this.plClient.Controls.Add(this.lblBarCode);
            this.plClient.Controls.Add(this.lblName);
            this.plClient.Location = new System.Drawing.Point(10, 53);
            this.plClient.Name = "plClient";
            this.plClient.Size = new System.Drawing.Size(406, 311);
            this.plClient.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(219, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrize
            // 
            this.txtPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrize.Location = new System.Drawing.Point(197, 157);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(150, 22);
            this.txtPrize.TabIndex = 34;
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrize.Location = new System.Drawing.Point(17, 159);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(123, 20);
            this.lblPrize.TabIndex = 33;
            this.lblPrize.Text = "Valor de Venta :";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(197, 117);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(150, 22);
            this.txtCost.TabIndex = 32;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCost.Location = new System.Drawing.Point(17, 119);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(141, 20);
            this.lblCost.TabIndex = 31;
            this.lblCost.Text = "Costo de Compra :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(197, 81);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(150, 22);
            this.txtSupplier.TabIndex = 30;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(197, 47);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(192, 22);
            this.txtBarCode.TabIndex = 29;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(197, 14);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(192, 22);
            this.txtNameProduct.TabIndex = 28;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSupplier.Location = new System.Drawing.Point(17, 83);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(89, 20);
            this.lblSupplier.TabIndex = 27;
            this.lblSupplier.Text = "Proveedor :";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(84, 250);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddNewProduct.TabIndex = 26;
            this.btnAddNewProduct.Text = "Agregar";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBarCode.Location = new System.Drawing.Point(17, 49);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(136, 20);
            this.lblBarCode.TabIndex = 19;
            this.lblBarCode.Text = "Codigo de Barras:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(17, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Nombre :";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProduct.Location = new System.Drawing.Point(12, 9);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(205, 25);
            this.lblProduct.TabIndex = 29;
            this.lblProduct.Text = "Ingreso de Producto";
            // 
            // frmProductInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(428, 389);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.plClient);
            this.Name = "frmProductInsert";
            this.Text = "frmProduct";
            this.plClient.ResumeLayout(false);
            this.plClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plClient;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProduct;
    }
}