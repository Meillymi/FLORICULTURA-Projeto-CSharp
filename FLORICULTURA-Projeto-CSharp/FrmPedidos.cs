using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    public class ItemPedido
    {
        public string Nome;
        public decimal Preco;
        public int Qtd;
        public int IdFlor;
    }

    public partial class FrmPedidos : Form
    {
        ConectaBanco con = new ConectaBanco();
        List<ItemPedido> itens = new List<ItemPedido>();

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            Estilo.Arredondar(btnMenuInicio, 22);
            Estilo.Arredondar(btnMenuProdutos, 22);
            Estilo.Arredondar(btnMenuClientes, 22);
            Estilo.Arredondar(btnMenuPedidos, 22);
            Estilo.Arredondar(btnMenuRelatorios, 22);
            Estilo.Arredondar(btnMenuSair, 22);
            Estilo.Arredondar(btnFinalizar, 22);
            Estilo.Arredondar(btnAddCliente, 15);
            Estilo.Arredondar(btnRemover, 16);
            
            DataTable flores = con.listaFlores();
            foreach (DataRow row in flores.Rows)
            {
                AdicionarCartao(
                    row["idFlores"].ToString(),
                    row["flor_nome"].ToString(),
                    Convert.ToDouble(row["flor_preco"]),
                    row["flor_imagem"].ToString()
                );
            }
            DataTable clientes = con.listaClientes();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "cliente_nome";
            cmbCliente.ValueMember = "idclientes";
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmMenu());
        }

        private void btnMenuProdutos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmProdutos());
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmClientes());
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

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            using (FrmAddCliente f = new FrmAddCliente())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    int novoId = con.insereCliente(f.Nome, f.Telefone, "", "");
                    if (novoId > 0)
                    {
                        DataTable clientes = con.listaClientes();
                        cmbCliente.DataSource = clientes;
                        cmbCliente.DisplayMember = "cliente_nome";
                        cmbCliente.ValueMember = "idclientes";
                        cmbCliente.SelectedValue = novoId;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar cliente.");
                    }
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstItens.SelectedIndex < 0) return;
            ItemPedido item = itens[lstItens.SelectedIndex];
            if (item.Qtd > 1) item.Qtd--;
            else itens.Remove(item);
            AtualizarPedido();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha o cliente.");
                return;
            }
            if (itens.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto.");
                return;
            }
            
            int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            decimal totalDecimal = 0;

            foreach (ItemPedido i in itens) totalDecimal += i.Preco * i.Qtd;

            int idPedido = con.inserePedido(idCliente, (double)totalDecimal);

            if (idPedido > 0)
            {
                foreach (ItemPedido i in itens)
                    con.insereItemPedido(idPedido, i.IdFlor, (double)i.Preco, i.Qtd);
                MessageBox.Show("Pedido finalizado! 🌸");
                itens.Clear();
                AtualizarPedido();
            }
            else
                MessageBox.Show("Erro ao salvar o pedido.");
        }

        private void AdicionarCartao(string idFlor, string nome, double preco, string caminhoImagem)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 226);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(0, 0, 12, 12);

            PictureBox foto = new PictureBox();
            foto.Location = new Point(10, 10);
            foto.Size = new Size(178, 108);
            foto.SizeMode = PictureBoxSizeMode.Zoom;
            foto.BackColor = ColorTranslator.FromHtml("#FDE0E9");
            foto.Image = Estilo.CarregarImagem(caminhoImagem);

            Label lblNome = new Label();
            lblNome.Location = new Point(10, 126);
            lblNome.Size = new Size(178, 22);
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNome.ForeColor = ColorTranslator.FromHtml("#4A2B38");
            lblNome.Text = nome;

            Label lblPreco = new Label();
            lblPreco.Location = new Point(10, 150);
            lblPreco.Size = new Size(178, 20);
            lblPreco.ForeColor = ColorTranslator.FromHtml("#7A2D4A");
            lblPreco.Text = preco.ToString("C");

            Button btnAdd = new Button();
            btnAdd.Location = new Point(10, 178);
            btnAdd.Size = new Size(178, 34);
            btnAdd.Text = "Adicionar";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#B83B61");
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = ColorTranslator.FromHtml("#B83B61");
            btnAdd.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnAdd.Click += (s, e) => AdicionarItem(int.Parse(idFlor), nome, (decimal)preco);

            card.Controls.Add(foto);
            card.Controls.Add(lblNome);
            card.Controls.Add(lblPreco);
            card.Controls.Add(btnAdd);
            flpProdutos.Controls.Add(card);
            Estilo.Arredondar(btnAdd, 17);
        }

        private void AdicionarItem(int idFlor, string nome, decimal preco)
        {
            foreach (ItemPedido i in itens)
            {
                if (i.IdFlor == idFlor)
                {
                    i.Qtd++;
                    AtualizarPedido();
                    return;
                }
            }
            ItemPedido novo = new ItemPedido();
            novo.IdFlor = idFlor;
            novo.Nome = nome;
            novo.Preco = preco;
            novo.Qtd = 1;
            itens.Add(novo);
            AtualizarPedido();
        }

        private void AtualizarPedido()
        {
            lstItens.Items.Clear();
            decimal total = 0;
            foreach (ItemPedido i in itens)
            {
                lstItens.Items.Add(i.Qtd + "x " + i.Nome + "  " + (i.Preco * i.Qtd).ToString("C"));
                total += i.Preco * i.Qtd;
            }
            lblTotal.Text = "Total: " + total.ToString("C");
        }

    }
}
