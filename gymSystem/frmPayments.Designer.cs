namespace gymSystem
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnDataGridClients = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnInsertPayment = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDoPayments = new System.Windows.Forms.Label();
            this.btnModifyPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.pnDataGridClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDataGridClients
            // 
            this.pnDataGridClients.Controls.Add(this.dgvPayments);
            this.pnDataGridClients.Location = new System.Drawing.Point(9, 125);
            this.pnDataGridClients.Name = "pnDataGridClients";
            this.pnDataGridClients.Size = new System.Drawing.Size(498, 414);
            this.pnDataGridClients.TabIndex = 27;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.Location = new System.Drawing.Point(3, 6);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(490, 405);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnInsertPayment
            // 
            this.btnInsertPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPayment.Location = new System.Drawing.Point(407, 16);
            this.btnInsertPayment.Name = "btnInsertPayment";
            this.btnInsertPayment.Size = new System.Drawing.Size(100, 30);
            this.btnInsertPayment.TabIndex = 28;
            this.btnInsertPayment.Text = "Hacer Pago";
            this.btnInsertPayment.UseVisualStyleBackColor = true;
            this.btnInsertPayment.Click += new System.EventHandler(this.btnInsertPayment_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(20, 61);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 20);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Buscar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(89, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblDoPayments
            // 
            this.lblDoPayments.AutoSize = true;
            this.lblDoPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoPayments.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoPayments.Location = new System.Drawing.Point(10, 9);
            this.lblDoPayments.Name = "lblDoPayments";
            this.lblDoPayments.Size = new System.Drawing.Size(73, 25);
            this.lblDoPayments.TabIndex = 30;
            this.lblDoPayments.Text = "Pagos";
            // 
            // btnModifyPayment
            // 
            this.btnModifyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPayment.Location = new System.Drawing.Point(407, 53);
            this.btnModifyPayment.Name = "btnModifyPayment";
            this.btnModifyPayment.Size = new System.Drawing.Size(100, 30);
            this.btnModifyPayment.TabIndex = 33;
            this.btnModifyPayment.Text = "Modificar";
            this.btnModifyPayment.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.Location = new System.Drawing.Point(407, 89);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(100, 30);
            this.btnDeletePayment.TabIndex = 34;
            this.btnDeletePayment.Text = "Eliminar";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(513, 545);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnModifyPayment);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblDoPayments);
            this.Controls.Add(this.pnDataGridClients);
            this.Controls.Add(this.btnInsertPayment);
            this.Name = "frmPayments";
            this.Text = "Pagos";
            this.pnDataGridClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDataGridClients;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnInsertPayment;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDoPayments;
        private System.Windows.Forms.Button btnModifyPayment;
        private System.Windows.Forms.Button btnDeletePayment;
    }
}