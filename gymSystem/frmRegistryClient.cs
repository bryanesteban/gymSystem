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
    public partial class frmRegistryClient : Form
    {
        public frmRegistryClient()
        {
            InitializeComponent();
        }

        funClient objFunClient = new funClient();

        private void RegistryClient_Load(object sender, EventArgs e)
        {
           objFunClient.chargeClient(dgvClient);
        }



        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            String IdClientDgv = "";

            if (this.dgvClient.SelectedRows.Count == 1)
            {
                if (this.dgvClient.CurrentRow.Cells[0].Value != null)
                {
                    IdClientDgv = this.dgvClient.CurrentRow.Cells[0].Value.ToString();
                    frmClientModify objClientModify = new frmClientModify(IdClientDgv);
                    objClientModify.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un fila valida!");
                    IdClientDgv = "";
                   
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato primero");
                IdClientDgv = "";
            }

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            
            String IdClientDgv = "";

            if (this.dgvClient.SelectedRows.Count == 1)
            {
                if (this.dgvClient.CurrentRow.Cells[0].Value != null)
                {
                    IdClientDgv = this.dgvClient.CurrentRow.Cells[0].Value.ToString();
                    String Resultado = objFunClient.DeleteClient(IdClientDgv);
                    MessageBox.Show(Resultado);
                    objFunClient.reChargeClient(dgvClient);

                }
                else
                {
                    MessageBox.Show("Seleccione un fila valida!");
                    IdClientDgv = "";

                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato primero");
                IdClientDgv = "";
            }


        }

        private void btnEntryClient_Click(object sender, EventArgs e)
        {
            frmClientEntry objClientEntry = new frmClientEntry(dgvClient);
            objClientEntry.Show();
        }

        private void txtIdentification_KeyDown(object sender, KeyEventArgs e)
        {
            String word = "%" + txtIdentification.Text + "%";
            objFunClient.searchClient(word, dgvClient);
        }
    }
}
