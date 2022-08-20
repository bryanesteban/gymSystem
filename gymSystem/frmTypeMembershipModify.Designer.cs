namespace gymSystem
{
    partial class frmTypeMembershipModify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelSaveMembershipType = new System.Windows.Forms.Button();
            this.btnSaveMemberShipType = new System.Windows.Forms.Button();
            this.lblNameMembership = new System.Windows.Forms.Label();
            this.txtNameMembership = new System.Windows.Forms.TextBox();
            this.lblPrize = new System.Windows.Forms.Label();
            this.txtPrizeMembership = new System.Windows.Forms.TextBox();
            this.lblQuantityofDays = new System.Windows.Forms.Label();
            this.txtQuantityOfDays = new System.Windows.Forms.TextBox();
            this.lblMembershipTypeModify = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelSaveMembershipType);
            this.panel1.Controls.Add(this.btnSaveMemberShipType);
            this.panel1.Controls.Add(this.lblNameMembership);
            this.panel1.Controls.Add(this.txtNameMembership);
            this.panel1.Controls.Add(this.lblPrize);
            this.panel1.Controls.Add(this.txtPrizeMembership);
            this.panel1.Controls.Add(this.lblQuantityofDays);
            this.panel1.Controls.Add(this.txtQuantityOfDays);
            this.panel1.Location = new System.Drawing.Point(11, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 371);
            this.panel1.TabIndex = 20;
            // 
            // btnCancelSaveMembershipType
            // 
            this.btnCancelSaveMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSaveMembershipType.Location = new System.Drawing.Point(250, 280);
            this.btnCancelSaveMembershipType.Name = "btnCancelSaveMembershipType";
            this.btnCancelSaveMembershipType.Size = new System.Drawing.Size(100, 30);
            this.btnCancelSaveMembershipType.TabIndex = 15;
            this.btnCancelSaveMembershipType.Text = "Cancelar";
            this.btnCancelSaveMembershipType.UseVisualStyleBackColor = true;
            this.btnCancelSaveMembershipType.Click += new System.EventHandler(this.btnCancelSaveMembershipType_Click);
            // 
            // btnSaveMemberShipType
            // 
            this.btnSaveMemberShipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMemberShipType.Location = new System.Drawing.Point(85, 280);
            this.btnSaveMemberShipType.Name = "btnSaveMemberShipType";
            this.btnSaveMemberShipType.Size = new System.Drawing.Size(100, 30);
            this.btnSaveMemberShipType.TabIndex = 14;
            this.btnSaveMemberShipType.Text = "Guardar";
            this.btnSaveMemberShipType.UseVisualStyleBackColor = true;
            this.btnSaveMemberShipType.Click += new System.EventHandler(this.btnSaveMemberShipType_Click);
            // 
            // lblNameMembership
            // 
            this.lblNameMembership.AutoSize = true;
            this.lblNameMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMembership.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameMembership.Location = new System.Drawing.Point(20, 41);
            this.lblNameMembership.Name = "lblNameMembership";
            this.lblNameMembership.Size = new System.Drawing.Size(177, 20);
            this.lblNameMembership.TabIndex = 7;
            this.lblNameMembership.Text = "Nombre  de membresia:";
            // 
            // txtNameMembership
            // 
            this.txtNameMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMembership.Location = new System.Drawing.Point(221, 41);
            this.txtNameMembership.Name = "txtNameMembership";
            this.txtNameMembership.Size = new System.Drawing.Size(150, 22);
            this.txtNameMembership.TabIndex = 6;
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrize.Location = new System.Drawing.Point(20, 155);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(161, 20);
            this.lblPrize.TabIndex = 5;
            this.lblPrize.Text = "Precio de Membresia:";
            // 
            // txtPrizeMembership
            // 
            this.txtPrizeMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeMembership.Location = new System.Drawing.Point(221, 155);
            this.txtPrizeMembership.Name = "txtPrizeMembership";
            this.txtPrizeMembership.Size = new System.Drawing.Size(150, 22);
            this.txtPrizeMembership.TabIndex = 4;
            this.txtPrizeMembership.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrizeMembership_KeyPress);
            // 
            // lblQuantityofDays
            // 
            this.lblQuantityofDays.AutoSize = true;
            this.lblQuantityofDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityofDays.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantityofDays.Location = new System.Drawing.Point(20, 100);
            this.lblQuantityofDays.Name = "lblQuantityofDays";
            this.lblQuantityofDays.Size = new System.Drawing.Size(139, 20);
            this.lblQuantityofDays.TabIndex = 3;
            this.lblQuantityofDays.Text = "Cantidad de Dias :";
            // 
            // txtQuantityOfDays
            // 
            this.txtQuantityOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityOfDays.Location = new System.Drawing.Point(221, 100);
            this.txtQuantityOfDays.Name = "txtQuantityOfDays";
            this.txtQuantityOfDays.Size = new System.Drawing.Size(150, 22);
            this.txtQuantityOfDays.TabIndex = 2;
            this.txtQuantityOfDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityOfDays_KeyPress);
            // 
            // lblMembershipTypeModify
            // 
            this.lblMembershipTypeModify.AutoSize = true;
            this.lblMembershipTypeModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipTypeModify.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMembershipTypeModify.Location = new System.Drawing.Point(11, 9);
            this.lblMembershipTypeModify.Name = "lblMembershipTypeModify";
            this.lblMembershipTypeModify.Size = new System.Drawing.Size(290, 25);
            this.lblMembershipTypeModify.TabIndex = 19;
            this.lblMembershipTypeModify.Text = "Modificar Tipo de Membresia";
            // 
            // frmTypeMembershipModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(497, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMembershipTypeModify);
            this.Name = "frmTypeMembershipModify";
            this.Text = "Modficar Tipo de Membresia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelSaveMembershipType;
        private System.Windows.Forms.Button btnSaveMemberShipType;
        private System.Windows.Forms.Label lblNameMembership;
        private System.Windows.Forms.TextBox txtNameMembership;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.TextBox txtPrizeMembership;
        private System.Windows.Forms.Label lblQuantityofDays;
        private System.Windows.Forms.TextBox txtQuantityOfDays;
        private System.Windows.Forms.Label lblMembershipTypeModify;
    }
}