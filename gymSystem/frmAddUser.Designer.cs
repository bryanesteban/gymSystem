namespace gymSystem
{
    partial class frmAddUser
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtValuetoSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientAdd = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(399, 242);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 30);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(12, 22);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(63, 20);
            this.lblIdentification.TabIndex = 22;
            this.lblIdentification.Text = "Buscar:";
            // 
            // txtValuetoSearch
            // 
            this.txtValuetoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuetoSearch.Location = new System.Drawing.Point(104, 22);
            this.txtValuetoSearch.Name = "txtValuetoSearch";
            this.txtValuetoSearch.Size = new System.Drawing.Size(150, 22);
            this.txtValuetoSearch.TabIndex = 21;
            this.txtValuetoSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValuetoSearch_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientAdd);
            this.panel1.Location = new System.Drawing.Point(16, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 186);
            this.panel1.TabIndex = 25;
            // 
            // dgvClientAdd
            // 
            this.dgvClientAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientAdd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvClientAdd.Name = "dgvClientAdd";
            this.dgvClientAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientAdd.Size = new System.Drawing.Size(477, 180);
            this.dgvClientAdd.TabIndex = 0;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(520, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblIdentification);
            this.Controls.Add(this.txtValuetoSearch);
            this.Name = "frmAddUser";
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtValuetoSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientAdd;
    }
}