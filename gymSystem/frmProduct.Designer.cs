namespace gymSystem
{
    partial class frmProduct
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.plUser = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblFindProduct = new System.Windows.Forms.Label();
            this.txtValuetoSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.plUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.btnModifyProduct);
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Location = new System.Drawing.Point(343, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 120);
            this.panel2.TabIndex = 26;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(47, 8);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(47, 44);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(100, 30);
            this.btnModifyProduct.TabIndex = 23;
            this.btnModifyProduct.Text = "Modificar";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(47, 80);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteProduct.TabIndex = 24;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // plUser
            // 
            this.plUser.Controls.Add(this.dgvProduct);
            this.plUser.Location = new System.Drawing.Point(12, 136);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(519, 404);
            this.plUser.TabIndex = 27;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(3, 6);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(513, 395);
            this.dgvProduct.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProduct.Location = new System.Drawing.Point(12, 24);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(109, 25);
            this.lblProduct.TabIndex = 31;
            this.lblProduct.Text = "Productos";
            // 
            // lblFindProduct
            // 
            this.lblFindProduct.AutoSize = true;
            this.lblFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFindProduct.Location = new System.Drawing.Point(14, 84);
            this.lblFindProduct.Name = "lblFindProduct";
            this.lblFindProduct.Size = new System.Drawing.Size(63, 20);
            this.lblFindProduct.TabIndex = 30;
            this.lblFindProduct.Text = "Buscar:";
            // 
            // txtValuetoSearch
            // 
            this.txtValuetoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuetoSearch.Location = new System.Drawing.Point(106, 84);
            this.txtValuetoSearch.Name = "txtValuetoSearch";
            this.txtValuetoSearch.Size = new System.Drawing.Size(150, 22);
            this.txtValuetoSearch.TabIndex = 29;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(540, 552);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblFindProduct);
            this.Controls.Add(this.txtValuetoSearch);
            this.Controls.Add(this.plUser);
            this.Controls.Add(this.panel2);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.panel2.ResumeLayout(false);
            this.plUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Panel plUser;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblFindProduct;
        private System.Windows.Forms.TextBox txtValuetoSearch;
    }
}