namespace gymSystem
{
    partial class frmMembershipModify
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTypeMembership = new System.Windows.Forms.ComboBox();
            this.lblTypeMembership = new System.Windows.Forms.Label();
            this.plClient = new System.Windows.Forms.Panel();
            this.txtIdentificationClient = new System.Windows.Forms.TextBox();
            this.txtLastNameClient = new System.Windows.Forms.TextBox();
            this.txtNamesClient = new System.Windows.Forms.TextBox();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClientEntry = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(237, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Location = new System.Drawing.Point(98, 472);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(100, 30);
            this.btnAgree.TabIndex = 33;
            this.btnAgree.Text = "Aceptar";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAbono);
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Location = new System.Drawing.Point(17, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 100);
            this.panel2.TabIndex = 32;
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(237, 47);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(150, 22);
            this.txtAbono.TabIndex = 21;
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayment.Location = new System.Drawing.Point(17, 47);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(64, 20);
            this.lblPayment.TabIndex = 22;
            this.lblPayment.Text = "Abono :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTypeMembership);
            this.panel1.Controls.Add(this.lblTypeMembership);
            this.panel1.Location = new System.Drawing.Point(17, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 113);
            this.panel1.TabIndex = 31;
            // 
            // cmbTypeMembership
            // 
            this.cmbTypeMembership.FormattingEnabled = true;
            this.cmbTypeMembership.Location = new System.Drawing.Point(237, 47);
            this.cmbTypeMembership.Name = "cmbTypeMembership";
            this.cmbTypeMembership.Size = new System.Drawing.Size(150, 21);
            this.cmbTypeMembership.TabIndex = 21;
            // 
            // lblTypeMembership
            // 
            this.lblTypeMembership.AutoSize = true;
            this.lblTypeMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMembership.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTypeMembership.Location = new System.Drawing.Point(21, 45);
            this.lblTypeMembership.Name = "lblTypeMembership";
            this.lblTypeMembership.Size = new System.Drawing.Size(147, 20);
            this.lblTypeMembership.TabIndex = 20;
            this.lblTypeMembership.Text = "Tipo de Membresia:";
            // 
            // plClient
            // 
            this.plClient.Controls.Add(this.txtIdentificationClient);
            this.plClient.Controls.Add(this.txtLastNameClient);
            this.plClient.Controls.Add(this.txtNamesClient);
            this.plClient.Controls.Add(this.lblIdentification);
            this.plClient.Controls.Add(this.btnAddNewUser);
            this.plClient.Controls.Add(this.label2);
            this.plClient.Controls.Add(this.label3);
            this.plClient.Location = new System.Drawing.Point(17, 48);
            this.plClient.Name = "plClient";
            this.plClient.Size = new System.Drawing.Size(408, 140);
            this.plClient.TabIndex = 30;
            // 
            // txtIdentificationClient
            // 
            this.txtIdentificationClient.Enabled = false;
            this.txtIdentificationClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificationClient.Location = new System.Drawing.Point(104, 73);
            this.txtIdentificationClient.Name = "txtIdentificationClient";
            this.txtIdentificationClient.Size = new System.Drawing.Size(150, 22);
            this.txtIdentificationClient.TabIndex = 30;
            // 
            // txtLastNameClient
            // 
            this.txtLastNameClient.Enabled = false;
            this.txtLastNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameClient.Location = new System.Drawing.Point(104, 39);
            this.txtLastNameClient.Name = "txtLastNameClient";
            this.txtLastNameClient.Size = new System.Drawing.Size(192, 22);
            this.txtLastNameClient.TabIndex = 29;
            // 
            // txtNamesClient
            // 
            this.txtNamesClient.Enabled = false;
            this.txtNamesClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamesClient.Location = new System.Drawing.Point(104, 6);
            this.txtNamesClient.Name = "txtNamesClient";
            this.txtNamesClient.Size = new System.Drawing.Size(192, 22);
            this.txtNamesClient.TabIndex = 28;
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(17, 75);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(67, 20);
            this.lblIdentification.TabIndex = 27;
            this.lblIdentification.Text = "Cedula :";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(287, 97);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(100, 30);
            this.btnAddNewUser.TabIndex = 26;
            this.btnAddNewUser.Text = "Agregar";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellidos :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres :";
            // 
            // lblClientEntry
            // 
            this.lblClientEntry.AutoSize = true;
            this.lblClientEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientEntry.Location = new System.Drawing.Point(12, 20);
            this.lblClientEntry.Name = "lblClientEntry";
            this.lblClientEntry.Size = new System.Drawing.Size(212, 25);
            this.lblClientEntry.TabIndex = 29;
            this.lblClientEntry.Text = "Modificar Membresia";
            // 
            // frmMembershipModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(437, 523);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plClient);
            this.Controls.Add(this.lblClientEntry);
            this.Name = "frmMembershipModify";
            this.Text = "Modificar Membresia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plClient.ResumeLayout(false);
            this.plClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTypeMembership;
        private System.Windows.Forms.Label lblTypeMembership;
        private System.Windows.Forms.Panel plClient;
        private System.Windows.Forms.TextBox txtIdentificationClient;
        private System.Windows.Forms.TextBox txtLastNameClient;
        private System.Windows.Forms.TextBox txtNamesClient;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClientEntry;
    }
}