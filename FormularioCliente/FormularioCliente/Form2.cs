using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioCliente.Banco;
using System.Data.SqlClient;
using FormularioCliente.DAO;
using FormularioCliente.Modelos;

namespace FormularioCliente
{
    public partial class frmClientesCadastrados : Form
    {
        public frmClientesCadastrados()
        {
            InitializeComponent();
            PopularTabela();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente obj = new Cliente();
                obj.Codigo = Convert.ToInt32(dgClientes.CurrentRow.Cells[0].Value.ToString());
                ClienteDAO clientedao = new ClienteDAO();
                clientedao.deletarCliente(obj);

                PopularTabela();
            }
            
        }
        private void PopularTabela()
        {
            using (SqlConnection sqlCon = new SqlConnection(FactoryConnection.SQLConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from cliente", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgClientes.DataSource = dtbl;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Tem certeza que deseja alterar este cliente?", "Confirmação de alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente obj = new Cliente();
                obj.Codigo = Convert.ToInt32(dgClientes.CurrentRow.Cells[0].Value.ToString());
                obj.Nome = dgClientes.CurrentRow.Cells[1].Value.ToString();
                obj.Rg = dgClientes.CurrentRow.Cells[2].Value.ToString();
                obj.Cpf = dgClientes.CurrentRow.Cells[3].Value.ToString();
                obj.Residencial = dgClientes.CurrentRow.Cells[4].Value.ToString();
                obj.Celular = dgClientes.CurrentRow.Cells[5].Value.ToString();
                obj.Sexo = dgClientes.CurrentRow.Cells[6].Value.ToString();

                ClienteDAO clientedao = new ClienteDAO();
                clientedao.alterarCliente(obj);
                PopularTabela();
            }
        }
    }
}
