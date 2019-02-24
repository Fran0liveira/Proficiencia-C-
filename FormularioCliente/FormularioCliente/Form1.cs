using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioCliente.Modelos;
using FormularioCliente.DAO;

namespace FormularioCliente
{
    public partial class frmCliente : Form
    {
        int id;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente();
                obj.Nome = txtNome.Text;
                obj.Rg = txtRg.Text;
                obj.Cpf = txtCpf.Text;
                obj.Residencial = txtResidencial.Text;
                obj.Celular = txtCelular.Text;
                if(rbMasculino.Checked == true)
                {
                    obj.Sexo = rbMasculino.Text;
                }
                else if (rbFeminino.Checked == true)
                {
                    obj.Sexo = rbFeminino.Text;
                }

                ClienteDAO clientedao = new ClienteDAO();
                id = clientedao.InserirCliente(obj);

                txtCodigo.Text = Convert.ToString(id);
                Limpar();


            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(od.FileName);
                pbImagem.Image = bm;
            }
            
            
        }

        private void btnLimparImg_Click(object sender, EventArgs e)
        {
            pbImagem.Image = null;
        }
        private void Limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtResidencial.Clear();
            txtCelular.Clear();
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
        }
    }
}
