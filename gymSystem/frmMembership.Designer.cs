namespace gymSystem
{
    partial class frmMembership
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
            this.plUser = new System.Windows.Forms.Panel();
            this.dgvMembership = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnDeleteMembership = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddMembership = new System.Windows.Forms.Button();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtValuetoSearch = new System.Windows.Forms.TextBox();
            this.lblClientList = new System.Windows.Forms.Label();
            this.plUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembership)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plUser
            // 
            this.plUser.Controls.Add(this.dgvMembership);
            this.plUser.Location = new System.Drawing.Point(12, 112);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(519, 428);
            this.plUser.TabIndex = 0;
            // 
            // dgvMembership
            // 
            this.dgvMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembership.Location = new System.Drawing.Point(3, 3);
            this.dgvMembership.Name = "dgvMembership";
            this.dgvMembership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembership.Size = new System.Drawing.Size(513, 422);
            this.dgvMembership.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(9, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(537, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 388);
            this.panel1.TabIndex = 1;
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyClient.Location = new System.Drawing.Point(91, 50);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(100, 30);
            this.btnModifyClient.TabIndex = 23;
            this.btnModifyClient.Text = "Modificar";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click_1);
            // 
            // btnDeleteMembership
            // 
            this.btnDeleteMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMembership.Location = new System.Drawing.Point(91, 86);
            this.btnDeleteMembership.Name = "btnDeleteMembership";
            this.btnDeleteMembership.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteMembership.TabIndex = 24;
            this.btnDeleteMembership.Text = "Eliminar";
            this.btnDeleteMembership.UseVisualStyleBackColor = true;
            this.btnDeleteMembership.Click += new System.EventHandler(this.btnDeleteMembership_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddMembership);
            this.panel2.Controls.Add(this.btnModifyClient);
            this.panel2.Controls.Add(this.btnDeleteMembership);
            this.panel2.Location = new System.Drawing.Point(537, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 134);
            this.panel2.TabIndex = 25;
            // 
            // btnAddMembership
            // 
            this.btnAddMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembership.Location = new System.Drawing.Point(91, 14);
            this.btnAddMembership.Name = "btnAddMembership";
            this.btnAddMembership.Size = new System.Drawing.Size(100, 30);
            this.btnAddMembership.TabIndex = 25;
            this.btnAddMembership.Text = "Agregar";
            this.btnAddMembership.UseVisualStyleBackColor = true;
            this.btnAddMembership.Click += new System.EventHandler(this.btnAddMembership_Click);
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(12, 72);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(63, 20);
            this.lblIdentification.TabIndex = 27;
            this.lblIdentification.Text = "Buscar:";
            // 
            // txtValuetoSearch
            // 
            this.txtValuetoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuetoSearch.Location = new System.Drawing.Point(104, 72);
            this.txtValuetoSearch.Name = "txtValuetoSearch";
            this.txtValuetoSearch.Size = new System.Drawing.Size(150, 22);
            this.txtValuetoSearch.TabIndex = 26;
            this.txtValuetoSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValuetoSearch_KeyDown);
            // 
            // lblClientList
            // 
            this.lblClientList.AutoSize = true;
            this.lblClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientList.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientList.Location = new System.Drawing.Point(10, 12);
            this.lblClientList.Name = "lblClientList";
            this.lblClientList.Size = new System.Drawing.Size(129, 25);
            this.lblClientList.TabIndex = 28;
            this.lblClientList.Text = "Membresias";
            // 
            // frmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(814, 552);
            this.Controls.Add(this.lblClientList);
            this.Controls.Add(this.lblIdentification);
            this.Controls.Add(this.txtValuetoSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plUser);
            this.Name = "frmMembership";
            this.Text = "Membresia";
            this.plUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembership)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plUser;
        private System.Windows.Forms.DataGridView dgvMembership;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnDeleteMembership;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMembership;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtValuetoSearch;
        private System.Windows.Forms.Label lblClientList;
    }
}