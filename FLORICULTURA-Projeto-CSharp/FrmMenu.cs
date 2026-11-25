using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Estilo.Arredondar(btnMenuInicio, 22);
            Estilo.Arredondar(btnMenuProdutos, 22);
            Estilo.Arredondar(btnMenuClientes, 22);
            Estilo.Arredondar(btnMenuPedidos, 22);
            Estilo.Arredondar(btnMenuRelatorios, 22);
            Estilo.Arredondar(btnMenuSair, 22);
            Estilo.Arredondar(btnCardProduto, 24);
            Estilo.Arredondar(btnCardClientes, 24);
            Estilo.Arredondar(btnCardPedido, 24);
            Estilo.Arredondar(btnCardRelatorios, 24);
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

        private void btnCardProduto_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmProdutos());
        }

        private void btnCardClientes_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmClientes());
        }

        private void btnCardPedido_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmPedidos());
        }

        private void btnCardRelatorios_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara(this, new FrmRelatorios());
        }

    }
}
