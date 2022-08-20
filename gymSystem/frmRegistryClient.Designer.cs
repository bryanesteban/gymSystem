namespace gymSystem
{
    partial class frmRegistryClient
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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.lblClientList = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEntryClient = new System.Windows.Forms.Button();
            this.pnDataGridClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDataGridClients
            // 
            this.pnDataGridClients.Controls.Add(this.dgvClient);
            this.pnDataGridClients.Location = new System.Drawing.Point(12, 148);
            this.pnDataGridClients.Name = "pnDataGridClients";
            this.pnDataGridClients.Size = new System.Drawing.Size(697, 423);
            this.pnDataGridClients.TabIndex = 0;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.Location = new System.Drawing.Point(0, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(694, 417);
            this.dgvClient.TabIndex = 0;
            // 
            // lblClientList
            // 
            this.lblClientList.AutoSize = true;
            this.lblClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientList.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientList.Location = new System.Drawing.Point(12, 19);
            this.lblClientList.Name = "lblClientList";
            this.lblClientList.Size = new System.Drawing.Size(202, 25);
            this.lblClientList.TabIndex = 17;
            this.lblClientList.Text = "Registro de clientes";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(13, 60);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(63, 20);
            this.lblIdentification.TabIndex = 19;
            this.lblIdentification.Text = "Buscar:";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.Location = new System.Drawing.Point(105, 60);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(150, 22);
            this.txtIdentification.TabIndex = 18;
            this.txtIdentification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentification_KeyDown);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyClient.Location = new System.Drawing.Point(575, 55);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(100, 30);
            this.btnModifyClient.TabIndex = 21;
            this.btnModifyClient.Text = "Modificar";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(575, 91);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteClient.TabIndex = 22;
            this.btnDeleteClient.Text = "Eliminar";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEntryClient
            // 
            this.btnEntryClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryClient.Location = new System.Drawing.Point(575, 18);
            this.btnEntryClient.Name = "btnEntryClient";
            this.btnEntryClient.Size = new System.Drawing.Size(100, 30);
            this.btnEntryClient.TabIndex = 23;
            this.btnEntryClient.Text = "Agregar";
            this.btnEntryClient.UseVisualStyleBackColor = true;
            this.btnEntryClient.Click += new System.EventHandler(this.btnEntryClient_Click);
            // 
            // frmRegistryClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(716, 581);
            this.Controls.Add(this.btnEntryClient);
            this.Controls.Add(this.btnModifyClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.lblIdentification);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.lblClientList);
            this.Controls.Add(this.pnDataGridClients);
            this.Name = "frmRegistryClient";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.RegistryClient_Load);
            this.pnDataGridClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDataGridClients;
        private System.Windows.Forms.Label lblClientList;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEntryClient;
    }
}