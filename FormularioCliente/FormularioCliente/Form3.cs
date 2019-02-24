using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCliente
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente();
            f.Show();
        }

        private void btnManipular_Click(object sender, EventArgs e)
        {
            frmClientesCadastrados f = new frmClientesCadastrados();
            f.Show();
        }
    }
}
