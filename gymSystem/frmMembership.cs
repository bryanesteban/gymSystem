using gymSystem.Clases;
using gymSystem.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSystem
{
    public partial class frmMembership : Form
    {
        funMembership objfunMembership = new funMembership();
        public frmMembership()
        {
            InitializeComponent();
            objfunMembership.chargeMembership(dgvMembership);

        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            frmMembershipModify objMembershipModify = new frmMembershipModify();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            frmMembershipInsert objMembershipInsert = new frmMembershipInsert(dgvMembership);
            objMembershipInsert.Show();
        }

        private void txtValuetoSearch_KeyDown(object sender, KeyEventArgs e)
        {
            String word = "%" + txtValuetoSearch.Text + "%";
            objfunMembership.searchMembership(word, dgvMembership);
        }

        private void btnModifyClient_Click_1(object sender, EventArgs e)
        {
            String idMembershipDgv = "";
            
            if (this.dgvMembership.SelectedRows.Count == 1)
            {   
                    if (this.dgvMembership.CurrentRow.Cells[0].Value != null)
                    {

                        idMembershipDgv = this.dgvMembership.CurrentRow.Cells[0].Value.ToString();
                        csMembership membershipOfClient  = objfunMembership.foundOneMembership(idMembershipDgv.ToString());
                        if (DateTime.Compare(membershipOfClient.MEMFECHAINICIO1, DateTime.Now.Date) == 0){
                            frmMembershipModify objClientModify = new frmMembershipModify(dgvMembership, idMembershipDgv);
                            objClientModify.Show();
                            }
                        else
                        {
                        MessageBox.Show("Solo se puede realizar modificaciones en la fecha de Inicio del la membresia.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seleccione un fila valida!");
                        idMembershipDgv = "";

                    }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato primero");
                idMembershipDgv = "";
            }
        }

        private void btnDeleteMembership_Click(object sender, EventArgs e)
        {
            String idMembershipDgv = "";

            if (this.dgvMembership.SelectedRows.Count == 1)
            {
                if (this.dgvMembership.CurrentRow.Cells[0].Value != null)
                {

                    idMembershipDgv = this.dgvMembership.CurrentRow.Cells[0].Value.ToString();
                    csMembership membershipOfClient = objfunMembership.foundOneMembership(idMembershipDgv.ToString());
                    if (DateTime.Compare(membershipOfClient.MEMFECHAINICIO1, DateTime.Now.Date) == 0)
                    {
                        objfunMembership.DeleteMembership(idMembershipDgv,dgvMembership);
                    }
                    else
                    {
                        MessageBox.Show("Solo se puede eliminar Membresias el dia de la Inscripcion");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un fila valida!");
                    idMembershipDgv = "";

                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato primero");
                idMembershipDgv = "";
            }
        }
    }
}
