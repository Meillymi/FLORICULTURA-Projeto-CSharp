using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmRelatorios : Form
    {
        ConectaBanco con = new ConectaBanco();
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            Estilo.Arredondar(btnMenuInicio, 22);
            Estilo.Arredondar(btnMenuProdutos, 22);
            Estilo.Arredondar(btnMenuClientes, 22);
            Estilo.Arredondar(btnMenuPedidos, 22);
            Estilo.Arredondar(btnMenuRelatorios, 22);
            Estilo.Arredondar(btnMenuSair, 22);
            Estilo.Arredondar(btnGerar, 18);
            DataTable cats = con.listaCategorias();
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Todas");
            foreach (DataRow row in cats.Rows)
            {
                cmbCategoria.Items.Add(row["flor_categoria"].ToString());
            }
            cmbCategoria.Tag = cats;
            cmbCategoria.SelectedIndex = 0;

            dgvRelatorio.Columns.Add("colData", "Data");
            dgvRelatorio.Columns.Add("colCliente", "Cliente");
            dgvRelatorio.Columns.Add("colTotal", "Total");
            Estilo.EstilizarGrid(dgvRelatorio);
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

        private void btnMenuPedidos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmPedidos());
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (dtpDe.Value.Date > dtpAte.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a final.");
                return;
            }

            DataTable dt;
            if (cmbCategoria.SelectedIndex == 0)
            {
                dt = con.listaPedidos(dtpDe.Value, dtpAte.Value);
            }
            else
            {
                DataTable cats = con.listaCategorias();
                int idCat = Convert.ToInt32(cats.Rows[cmbCategoria.SelectedIndex - 1]["idcategorias"]);
                dt = con.listaPedidosPorCategoria(dtpDe.Value, dtpAte.Value, idCat);
            }
            dgvRelatorio.Rows.Clear();
            decimal total = 0;
            int qtdPedidos = 0;
            foreach (DataRow row in dt.Rows)
            {
                dgvRelatorio.Rows.Add(
                    Convert.ToDateTime(row["pedido_data"]).ToString("dd/MM/yyyy"),
                    row["cliente_nome"],
                    Convert.ToDecimal(row["pedido_precototal"]).ToString("C")
                );
                total += Convert.ToDecimal(row["pedido_precototal"]);
                qtdPedidos++;
            }
        }

    }
}
