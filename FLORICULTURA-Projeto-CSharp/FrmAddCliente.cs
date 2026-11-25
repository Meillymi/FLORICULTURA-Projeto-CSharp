using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {
            Estilo.Arredondar(btnSalvar, 20);
            Estilo.Arredondar(btnCancelar, 20);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome.");
                txtNome.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pnlTopoDlg_MouseDown(object sender, MouseEventArgs e)
        {
            Estilo.Arrastar(this);
        }

        public string Nome { get { return txtNome.Text.Trim(); } }
        public string Telefone { get { return txtTelefone.Text.Trim(); } }

    }
}
