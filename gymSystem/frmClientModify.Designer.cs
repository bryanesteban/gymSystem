namespace gymSystem
{
    partial class frmClientModify
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
            this.lblClientModify = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.btnCancelModifyClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientModify
            // 
            this.lblClientModify.AutoSize = true;
            this.lblClientModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientModify.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientModify.Location = new System.Drawing.Point(12, 21);
            this.lblClientModify.Name = "lblClientModify";
            this.lblClientModify.Size = new System.Drawing.Size(173, 25);
            this.lblClientModify.TabIndex = 18;
            this.lblClientModify.Text = "Modificar Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblSecondName);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.dateBorn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMiddleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblIdentification);
            this.panel1.Controls.Add(this.txtIdentification);
            this.panel1.Controls.Add(this.btnCancelModifyClient);
            this.panel1.Controls.Add(this.btnModifyClient);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 371);
            this.panel1.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(17, 178);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 37;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(155, 176);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 36;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(326, 133);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 35;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(497, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 34;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecondName.Location = new System.Drawing.Point(324, 92);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(138, 20);
            this.lblSecondName.TabIndex = 33;
            this.lblSecondName.Text = "Segundo Nombre:";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(497, 90);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(150, 22);
            this.txtSecondName.TabIndex = 32;
            // 
            // dateBorn
            // 
            this.dateBorn.CustomFormat = "yyyy/MM/dd";
            this.dateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBorn.Location = new System.Drawing.Point(497, 178);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(117, 20);
            this.dateBorn.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(324, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha de Nacimiento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(324, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(497, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido Materno :";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(155, 131);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(150, 22);
            this.txtMiddleName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Apellido Paterno :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(155, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 22);
            this.txtLastName.TabIndex = 24;
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentification.Location = new System.Drawing.Point(20, 48);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(67, 20);
            this.lblIdentification.TabIndex = 23;
            this.lblIdentification.Text = "Cedula :";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.Location = new System.Drawing.Point(155, 48);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(150, 22);
            this.txtIdentification.TabIndex = 22;
            // 
            // btnCancelModifyClient
            // 
            this.btnCancelModifyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelModifyClient.Location = new System.Drawing.Point(378, 296);
            this.btnCancelModifyClient.Name = "btnCancelModifyClient";
            this.btnCancelModifyClient.Size = new System.Drawing.Size(100, 30);
            this.btnCancelModifyClient.TabIndex = 15;
            this.btnCancelModifyClient.Text = "Cancelar";
            this.btnCancelModifyClient.UseVisualStyleBackColor = true;
            this.btnCancelModifyClient.Click += new System.EventHandler(this.btnCancelModifyClient_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyClient.Location = new System.Drawing.Point(205, 296);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(100, 30);
            this.btnModifyClient.TabIndex = 14;
            this.btnModifyClient.Text = "Guardar";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            this.btnModifyClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnModifyClient_KeyPress);
            // 
            // frmClientModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(704, 468);
            this.Controls.Add(this.lblClientModify);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientModify";
            this.Text = "Modificar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientModify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelModifyClient;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtIdentification;
    }
}