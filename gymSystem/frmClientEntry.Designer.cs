namespace gymSystem
{
    partial class frmClientEntry
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
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.btnCancelSaveClient = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.dateRegistry = new System.Windows.Forms.DateTimePicker();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblClientEntry = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdentification
            // 
            this.txtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.Location = new System.Drawing.Point(155, 41);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(150, 22);
            this.txtIdentification.TabIndex = 0;
            this.txtIdentification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentification_KeyPress);
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(20, 41);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(67, 20);
            this.lblIdentification.TabIndex = 1;
            this.lblIdentification.Text = "Cedula :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblSecondName);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.btnCancelSaveClient);
            this.panel1.Controls.Add(this.btnSaveClient);
            this.panel1.Controls.Add(this.dateRegistry);
            this.panel1.Controls.Add(this.dateBorn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMiddleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblIdentification);
            this.panel1.Controls.Add(this.txtIdentification);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 371);
            this.panel1.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(17, 171);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(155, 169);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 20;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(326, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(497, 126);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecondName.Location = new System.Drawing.Point(324, 85);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(138, 20);
            this.lblSecondName.TabIndex = 17;
            this.lblSecondName.Text = "Segundo Nombre:";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(497, 83);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(150, 22);
            this.txtSecondName.TabIndex = 16;
            // 
            // btnCancelSaveClient
            // 
            this.btnCancelSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSaveClient.Location = new System.Drawing.Point(378, 296);
            this.btnCancelSaveClient.Name = "btnCancelSaveClient";
            this.btnCancelSaveClient.Size = new System.Drawing.Size(100, 30);
            this.btnCancelSaveClient.TabIndex = 15;
            this.btnCancelSaveClient.Text = "Cancelar";
            this.btnCancelSaveClient.UseVisualStyleBackColor = true;
            this.btnCancelSaveClient.Click += new System.EventHandler(this.btnCancelSaveClient_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(205, 296);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(100, 30);
            this.btnSaveClient.TabIndex = 14;
            this.btnSaveClient.Text = "Guardar";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // dateRegistry
            // 
            this.dateRegistry.Checked = false;
            this.dateRegistry.CustomFormat = "yyyy/MM/dd";
            this.dateRegistry.Enabled = false;
            this.dateRegistry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegistry.Location = new System.Drawing.Point(188, 219);
            this.dateRegistry.Name = "dateRegistry";
            this.dateRegistry.Size = new System.Drawing.Size(117, 20);
            this.dateRegistry.TabIndex = 13;
            // 
            // dateBorn
            // 
            this.dateBorn.Checked = false;
            this.dateBorn.CustomFormat = "yyyy/MM/dd";
            this.dateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBorn.Location = new System.Drawing.Point(497, 171);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(117, 20);
            this.dateBorn.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(17, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Inscripcion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(324, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Nacimiento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(324, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(497, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Materno :";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(155, 124);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(150, 22);
            this.txtMiddleName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido Paterno :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(155, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblClientEntry
            // 
            this.lblClientEntry.AutoSize = true;
            this.lblClientEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientEntry.Location = new System.Drawing.Point(12, 27);
            this.lblClientEntry.Name = "lblClientEntry";
            this.lblClientEntry.Size = new System.Drawing.Size(186, 25);
            this.lblClientEntry.TabIndex = 16;
            this.lblClientEntry.Text = "Ingreso de Cliente";
            // 
            // frmClientEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(704, 468);
            this.Controls.Add(this.lblClientEntry);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientEntry";
            this.Text = "Guardar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateRegistry;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnCancelSaveClient;
        private System.Windows.Forms.Label lblClientEntry;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPhone;
    }
}