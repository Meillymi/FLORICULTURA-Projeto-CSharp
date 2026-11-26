using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmClientes : Form
    {
        DataGridViewRow linhaAlterar = null;
        ConectaBanco con = new ConectaBanco();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Estilo.Arredondar(btnMenuInicio, 22);
            Estilo.Arredondar(btnMenuProdutos, 22);
            Estilo.Arredondar(btnMenuClientes, 22);
            Estilo.Arredondar(btnMenuPedidos, 22);
            Estilo.Arredondar(btnMenuRelatorios, 22);
            Estilo.Arredondar(btnMenuSair, 22);
            Estilo.Arredondar(btnCadastrar, 22);
            Estilo.Arredondar(btnConfirmarAlteracao, 22);
            Estilo.Arredondar(btnBuscar, 17);
            dgvClientes.Columns.Add("colId", "Id");
            dgvClientes.Columns.Add("colNome", "Nome");
            dgvClientes.Columns.Add("colTelefone", "Telefone");
            dgvClientes.Columns.Add("colEmail", "E-mail");
            dgvClientes.Columns.Add("colEndereco", "Endereço");
            dgvClientes.Columns["colId"].Visible = false;
            Estilo.EstilizarGrid(dgvClientes);
            CarregarClientes();
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmMenu());
        }

        private void btnMenuProdutos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmProdutos());
        }

        private void btnMenuPedidos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmPedidos());
        }

        private void btnMenuRelatorios_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmRelatorios());
        }

        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            Estilo.Arrastar(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int novoId = con.insereCliente(
                txtNome.Text.Trim(),
                txtTelefone.Text.Trim(),
                txtEmail.Text.Trim(),
                txtEndereco.Text.Trim()
            );
            if (novoId > 0)
            {
                dgvClientes.Rows.Add(novoId, txtNome.Text.Trim(),
                    txtTelefone.Text.Trim(), txtEmail.Text.Trim(), txtEndereco.Text.Trim());
                MessageBox.Show("Cliente cadastrado!");
                txtNome.Clear(); txtTelefone.Clear(); txtEmail.Clear(); txtEndereco.Clear();
                txtNome.Focus();
            }
            else
                MessageBox.Show("Erro ao cadastrar cliente.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.CurrentCell = null;
            string texto = txtBuscar.Text.Trim().ToLower();
            foreach (DataGridViewRow r in dgvClientes.Rows)
            {
                r.Visible = Convert.ToString(r.Cells["colNome"].Value).ToLower().Contains(texto);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            linhaAlterar = dgvClientes.Rows[e.RowIndex];
            txtNomeAlt.Text = Convert.ToString(linhaAlterar.Cells["colNome"].Value);
            txtTelefoneAlt.Text = Convert.ToString(linhaAlterar.Cells["colTelefone"].Value);
            txtEmailAlt.Text = Convert.ToString(linhaAlterar.Cells["colEmail"].Value);
            txtEnderecoAlt.Text = Convert.ToString(linhaAlterar.Cells["colEndereco"].Value);
            tabs.SelectedTab = tabAlt;
        }

        private void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {
            if (linhaAlterar == null)
            {
                MessageBox.Show("Escolha um cliente na aba Buscar.");
                return;
            }
            if (txtNomeAlt.Text.Trim() == "" || txtTelefoneAlt.Text.Trim() == "")
            {
                MessageBox.Show("Preencha pelo menos o nome e o telefone.");
                return;
            }
            
            int id = Convert.ToInt32(linhaAlterar.Cells["colId"].Value);
            bool ok = con.alteraCliente(id,
                txtNomeAlt.Text.Trim(),
                txtTelefoneAlt.Text.Trim(),
                txtEmailAlt.Text.Trim(),
                txtEnderecoAlt.Text.Trim()
            );
            if (ok)
            {
                linhaAlterar.Cells["colNome"].Value = txtNomeAlt.Text.Trim();
                linhaAlterar.Cells["colTelefone"].Value = txtTelefoneAlt.Text.Trim();
                linhaAlterar.Cells["colEmail"].Value = txtEmailAlt.Text.Trim();
                linhaAlterar.Cells["colEndereco"].Value = txtEnderecoAlt.Text.Trim();
                MessageBox.Show("Cliente alterado!");
                tabs.SelectedTab = tabBusca;
            }
            else
                MessageBox.Show("Erro ao alterar cliente.");
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {

        }
        private void CarregarClientes()
        {
            DataTable dt = con.listaClientes();
            dgvClientes.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvClientes.Rows.Add(
                    row["idclientes"],
                    row["cliente_nome"],
                    row["cliente_telefone"],
                    row["cliente_email"],
                    row["cliente_endereco"]
                );
            }
        }
    }
}
