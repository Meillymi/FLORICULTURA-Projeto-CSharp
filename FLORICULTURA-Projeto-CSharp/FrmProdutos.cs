using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmProdutos : Form
    {
        ConectaBanco con = new ConectaBanco();
        string caminhoImagem = "";
        string caminhoImagemAlt = "";
        DataGridViewRow linhaAlterar = null;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
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
            Estilo.Arredondar(btnAddCategoria, 15);
            Estilo.Arredondar(btnEscolherImagem, 17);
            Estilo.Arredondar(btnEscolherImagemAlt, 17);
            
            dgvProdutos.Columns.Add("colId", "Id");
            dgvProdutos.Columns.Add("colNome", "Nome");
            dgvProdutos.Columns.Add("colCategoria", "Categoria");
            dgvProdutos.Columns.Add("colPreco", "Preço");
            dgvProdutos.Columns.Add("colEstoque", "Estoque");
            dgvProdutos.Columns.Add("colImagem", "Imagem");
            dgvProdutos.Columns["colId"].Visible = false;
            dgvProdutos.Columns["colImagem"].Visible = false;
            Estilo.EstilizarGrid(dgvProdutos);
            CarregarCategorias();
            CarregarProdutos();
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmMenu());
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmClientes());
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

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            using (FrmAddCategoria f = new FrmAddCategoria())

                if (f.ShowDialog() == DialogResult.OK)
            {
                int novoId = con.insereCategoria(f.Nome);
                if (novoId > 0)
                {
                    CarregarCategorias();
                    cmbCategoria.SelectedValue = novoId;
                }
            }
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    caminhoImagem = ofd.FileName;
                    picProduto.Image = Estilo.CarregarImagem(caminhoImagem);
                    lblCaminho.Text = Path.GetFileName(caminhoImagem);
                }
            }
        }

        private void btnEscolherImagemAlt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    caminhoImagemAlt = ofd.FileName;
                    picAlt.Image = Estilo.CarregarImagem(caminhoImagemAlt);
                    lblCaminhoAlt.Text = Path.GetFileName(caminhoImagemAlt);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            decimal preco;
            int estoque;
            if (txtNome.Text.Trim() == "" || cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha o nome e escolha a categoria.");
                return;
            }
            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Digite um preço válido.");
                txtPreco.Focus();
                return;
            }
            if (!int.TryParse(txtEstoque.Text, out estoque))
            {
                MessageBox.Show("Digite um número válido no estoque.");
                txtEstoque.Focus();
                return;
            }
            string imagemSalva = caminhoImagem == "" ? "" : Estilo.CopiarImagem(caminhoImagem);
            int idCat = Convert.ToInt32(cmbCategoria.SelectedValue);
            int novoId = con.insereFlor(txtNome.Text.Trim(), idCat, (double)preco, estoque, imagemSalva);
            if (novoId > 0)
            {
                dgvProdutos.Rows.Add(novoId, txtNome.Text.Trim(), cmbCategoria.Text, preco.ToString("C"), estoque, imagemSalva);
                MessageBox.Show("Produto cadastrado!");
                txtNome.Clear();
                txtPreco.Clear();
                txtEstoque.Clear();
                cmbCategoria.SelectedIndex = -1;
                picProduto.Image = null;
                caminhoImagem = "";
                lblCaminho.Text = "Nenhuma imagem";
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produto.");
            }
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProdutos.CurrentCell = null;
            string texto = txtBuscar.Text.Trim().ToLower();
            foreach (DataGridViewRow r in dgvProdutos.Rows)
            {
                r.Visible = Convert.ToString(r.Cells["colNome"].Value).ToLower().Contains(texto);
            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            linhaAlterar = dgvProdutos.Rows[e.RowIndex];
            txtNomeAlt.Text = Convert.ToString(linhaAlterar.Cells["colNome"].Value);
            cmbCategoriaAlt.Text = Convert.ToString(linhaAlterar.Cells["colCategoria"].Value);
            txtPrecoAlt.Text = Convert.ToString(linhaAlterar.Cells["colPreco"].Value).Replace("R$", "").Trim();
            txtEstoqueAlt.Text = Convert.ToString(linhaAlterar.Cells["colEstoque"].Value);
            caminhoImagemAlt = Convert.ToString(linhaAlterar.Cells["colImagem"].Value);
            picAlt.Image = Estilo.CarregarImagem(caminhoImagemAlt);
            lblCaminhoAlt.Text = caminhoImagemAlt == "" ? "Nenhuma imagem" : Path.GetFileName(caminhoImagemAlt);
            tabs.SelectedTab = tabAlt;
        }

        private void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {
            if (linhaAlterar == null)
            {
                MessageBox.Show("Escolha um produto na aba Buscar.");
                return;
            }
            decimal preco;
            int estoque;
            if (txtNomeAlt.Text.Trim() == "" || cmbCategoriaAlt.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha o nome e escolha a categoria.");
                return;
            }
            if (!decimal.TryParse(txtPrecoAlt.Text, out preco))
            {
                MessageBox.Show("Digite um preço válido.");
                txtPrecoAlt.Focus();
                return;
            }
            if (!int.TryParse(txtEstoqueAlt.Text, out estoque))
            {
                MessageBox.Show("Digite um número válido no estoque.");
                txtEstoqueAlt.Focus();
                return;
            }

            int id = Convert.ToInt32(linhaAlterar.Cells["colId"].Value);
            int idCat = Convert.ToInt32(cmbCategoriaAlt.SelectedValue);
            string imagem = caminhoImagemAlt == "" ? "" : Estilo.CopiarImagem(caminhoImagemAlt);
            bool ok = con.alteraFlor(id, txtNomeAlt.Text.Trim(), idCat, (double)preco, estoque, imagem);
            if (ok)
            {
                linhaAlterar.Cells["colNome"].Value = txtNomeAlt.Text.Trim();
                linhaAlterar.Cells["colCategoria"].Value = cmbCategoriaAlt.Text;
                linhaAlterar.Cells["colPreco"].Value = preco.ToString("C");
                linhaAlterar.Cells["colEstoque"].Value = estoque;
                linhaAlterar.Cells["colImagem"].Value = imagem;
                MessageBox.Show("Produto alterado!");
                tabs.SelectedTab = tabBusca;
            }
            else { MessageBox.Show("Erro ao alterar produto."); }
        }
        private void CarregarCategorias()
        {
            DataTable dt = con.listaCategorias();
            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "flor_categoria";
            cmbCategoria.ValueMember = "idcategorias";
            cmbCategoriaAlt.DataSource = new DataTable();
            DataTable dt2 = con.listaCategorias();
            cmbCategoriaAlt.DataSource = dt2;
            cmbCategoriaAlt.DisplayMember = "flor_categoria";
            cmbCategoriaAlt.ValueMember = "idcategorias";
        }

        private void CarregarProdutos()
        {
            DataTable dt = con.listaFlores();
            dgvProdutos.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvProdutos.Rows.Add(
                    row["idFlores"],
                    row["flor_nome"],
                    row["flor_categoria"],
                    Convert.ToDouble(row["flor_preco"]).ToString("C"),
                    row["flor_estoque"],
                    row["flor_imagem"]
                );
            }
        }


    }
}
