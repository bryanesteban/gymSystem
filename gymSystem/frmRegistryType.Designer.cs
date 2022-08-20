namespace gymSystem
{
    partial class frmRegistryType
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
            this.dgvTypeMembership = new System.Windows.Forms.DataGridView();
            this.btnModifyType = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnInsertType = new System.Windows.Forms.Button();
            this.pnDataGridClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeMembership)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDataGridClients
            // 
            this.pnDataGridClients.Controls.Add(this.dgvTypeMembership);
            this.pnDataGridClients.Location = new System.Drawing.Point(13, 103);
            this.pnDataGridClients.Name = "pnDataGridClients";
            this.pnDataGridClients.Size = new System.Drawing.Size(472, 414);
            this.pnDataGridClients.TabIndex = 23;
            // 
            // dgvTypeMembership
            // 
            this.dgvTypeMembership.AllowUserToAddRows = false;
            this.dgvTypeMembership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTypeMembership.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTypeMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTypeMembership.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypeMembership.Location = new System.Drawing.Point(5, 3);
            this.dgvTypeMembership.Name = "dgvTypeMembership";
            this.dgvTypeMembership.ReadOnly = true;
            this.dgvTypeMembership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeMembership.Size = new System.Drawing.Size(464, 405);
            this.dgvTypeMembership.TabIndex = 0;
            // 
            // btnModifyType
            // 
            this.btnModifyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyType.Location = new System.Drawing.Point(382, 31);
            this.btnModifyType.Name = "btnModifyType";
            this.btnModifyType.Size = new System.Drawing.Size(100, 30);
            this.btnModifyType.TabIndex = 24;
            this.btnModifyType.Text = "Modificar";
            this.btnModifyType.UseVisualStyleBackColor = true;
            this.btnModifyType.Click += new System.EventHandler(this.btnModifyType_Click);
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteType.Location = new System.Drawing.Point(382, 67);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteType.TabIndex = 25;
            this.btnDeleteType.Text = "Eliminar";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnInsertType
            // 
            this.btnInsertType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertType.Location = new System.Drawing.Point(18, 31);
            this.btnInsertType.Name = "btnInsertType";
            this.btnInsertType.Size = new System.Drawing.Size(100, 30);
            this.btnInsertType.TabIndex = 26;
            this.btnInsertType.Text = "Insertar";
            this.btnInsertType.UseVisualStyleBackColor = true;
            this.btnInsertType.Click += new System.EventHandler(this.btnInsertType_Click);
            // 
            // frmRegistryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(497, 526);
            this.Controls.Add(this.btnInsertType);
            this.Controls.Add(this.pnDataGridClients);
            this.Controls.Add(this.btnModifyType);
            this.Controls.Add(this.btnDeleteType);
            this.Name = "frmRegistryType";
            this.Text = "Registro de Membresias";
            this.Load += new System.EventHandler(this.frmRegistryType_Load);
            this.pnDataGridClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeMembership)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDataGridClients;
        private System.Windows.Forms.DataGridView dgvTypeMembership;
        private System.Windows.Forms.Button btnModifyType;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnInsertType;
    }
}