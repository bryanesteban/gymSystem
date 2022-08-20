using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gymSystem
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private String codeClient = "";
        String codUser = null; 

        DataSet resultClients = new DataSet();
        DataView filterClient;

        csAddUser objAddUser = new csAddUser();

        public string CodeClient { get => codeClient; set => codeClient = value; }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

            objAddUser.fillClient(dgvClientAdd);
        }

        private void txtValuetoSearch_KeyUp(object sender, KeyEventArgs e)
        {
            String word = "%" + txtValuetoSearch.Text + "%";
            objAddUser.searchClient(word, dgvClientAdd);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            

            if (this.dgvClientAdd.SelectedRows.Count == 1)
            {
                if (this.dgvClientAdd.CurrentRow.Cells[0].Value != null)
                {
                    btnAddUser.DialogResult = DialogResult.OK;
                    CodeClient = this.dgvClientAdd.CurrentRow.Cells[0].Value.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un fila valida!");
                    codeClient = "";
                    btnAddUser.DialogResult = DialogResult.None;
                }
                
            } 
            else
            {
                MessageBox.Show("Debe seleccionar un dato primero");
                codeClient = "";
                btnAddUser.DialogResult = DialogResult.None;
            }
            
        }
    }
}
