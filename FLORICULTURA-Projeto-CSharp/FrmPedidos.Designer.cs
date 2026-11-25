namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnMenuInicio = new System.Windows.Forms.Button();
            this.btnMenuProdutos = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnMenuPedidos = new System.Windows.Forms.Button();
            this.btnMenuRelatorios = new System.Windows.Forms.Button();
            this.btnMenuSair = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.flpProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.lblPedidoTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.flpProdutos.SuspendLayout();
            this.pnlPedido.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.Controls.Add(this.lblMarca);
            this.pnlMenu.Controls.Add(this.btnMenuInicio);
            this.pnlMenu.Controls.Add(this.btnMenuProdutos);
            this.pnlMenu.Controls.Add(this.btnMenuClientes);
            this.pnlMenu.Controls.Add(this.btnMenuPedidos);
            this.pnlMenu.Controls.Add(this.btnMenuRelatorios);
            this.pnlMenu.Controls.Add(this.btnMenuSair);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Size = new System.Drawing.Size(200, 580);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            //
            // lblMarca
            //
            this.lblMarca.Location = new System.Drawing.Point(18, 20);
            this.lblMarca.Size = new System.Drawing.Size(170, 36);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Floricultura";
            this.lblMarca.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.lblMarca.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMarca.AutoSize = false;
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnMenuInicio
            //
            this.btnMenuInicio.Location = new System.Drawing.Point(14, 84);
            this.btnMenuInicio.Size = new System.Drawing.Size(172, 44);
            this.btnMenuInicio.Name = "btnMenuInicio";
            this.btnMenuInicio.TabIndex = 2;
            this.btnMenuInicio.Text = "Início";
            this.btnMenuInicio.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuInicio.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicio.FlatAppearance.BorderSize = 0;
            this.btnMenuInicio.UseVisualStyleBackColor = false;
            this.btnMenuInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInicio.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuInicio.Click += new System.EventHandler(this.btnMenuInicio_Click);
            //
            // btnMenuProdutos
            //
            this.btnMenuProdutos.Location = new System.Drawing.Point(14, 132);
            this.btnMenuProdutos.Size = new System.Drawing.Size(172, 44);
            this.btnMenuProdutos.Name = "btnMenuProdutos";
            this.btnMenuProdutos.TabIndex = 3;
            this.btnMenuProdutos.Text = "Produtos";
            this.btnMenuProdutos.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuProdutos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuProdutos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProdutos.FlatAppearance.BorderSize = 0;
            this.btnMenuProdutos.UseVisualStyleBackColor = false;
            this.btnMenuProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProdutos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuProdutos.Click += new System.EventHandler(this.btnMenuProdutos_Click);
            //
            // btnMenuClientes
            //
            this.btnMenuClientes.Location = new System.Drawing.Point(14, 180);
            this.btnMenuClientes.Size = new System.Drawing.Size(172, 44);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.TabIndex = 4;
            this.btnMenuClientes.Text = "Clientes";
            this.btnMenuClientes.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuClientes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuClientes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.UseVisualStyleBackColor = false;
            this.btnMenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            //
            // btnMenuPedidos
            //
            this.btnMenuPedidos.Location = new System.Drawing.Point(14, 228);
            this.btnMenuPedidos.Size = new System.Drawing.Size(172, 44);
            this.btnMenuPedidos.Name = "btnMenuPedidos";
            this.btnMenuPedidos.TabIndex = 5;
            this.btnMenuPedidos.Text = "Pedidos";
            this.btnMenuPedidos.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.btnMenuPedidos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuPedidos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPedidos.FlatAppearance.BorderSize = 0;
            this.btnMenuPedidos.UseVisualStyleBackColor = false;
            this.btnMenuPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPedidos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            //
            // btnMenuRelatorios
            //
            this.btnMenuRelatorios.Location = new System.Drawing.Point(14, 276);
            this.btnMenuRelatorios.Size = new System.Drawing.Size(172, 44);
            this.btnMenuRelatorios.Name = "btnMenuRelatorios";
            this.btnMenuRelatorios.TabIndex = 6;
            this.btnMenuRelatorios.Text = "Relatórios";
            this.btnMenuRelatorios.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuRelatorios.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuRelatorios.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRelatorios.FlatAppearance.BorderSize = 0;
            this.btnMenuRelatorios.UseVisualStyleBackColor = false;
            this.btnMenuRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRelatorios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuRelatorios.Click += new System.EventHandler(this.btnMenuRelatorios_Click);
            //
            // btnMenuSair
            //
            this.btnMenuSair.Location = new System.Drawing.Point(14, 516);
            this.btnMenuSair.Size = new System.Drawing.Size(172, 44);
            this.btnMenuSair.Name = "btnMenuSair";
            this.btnMenuSair.TabIndex = 7;
            this.btnMenuSair.Text = "Sair";
            this.btnMenuSair.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuSair.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuSair.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSair.FlatAppearance.BorderSize = 0;
            this.btnMenuSair.UseVisualStyleBackColor = false;
            this.btnMenuSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSair.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuSair.Click += new System.EventHandler(this.btnMenuSair_Click);
            //
            // pnlTopo
            //
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblFechar);
            this.pnlTopo.Location = new System.Drawing.Point(200, 0);
            this.pnlTopo.Size = new System.Drawing.Size(760, 72);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.TabIndex = 8;
            this.pnlTopo.BackColor = System.Drawing.ColorTranslator.FromHtml("#F9C6D6");
            this.pnlTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopo_MouseDown);
            //
            // lblTitulo
            //
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Pedidos";
            this.lblTitulo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopo_MouseDown);
            //
            // lblFechar
            //
            this.lblFechar.Location = new System.Drawing.Point(716, 20);
            this.lblFechar.Size = new System.Drawing.Size(32, 32);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.TabIndex = 10;
            this.lblFechar.Text = "X";
            this.lblFechar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechar.AutoSize = false;
            this.lblFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            //
            // flpProdutos
            //
            this.flpProdutos.Location = new System.Drawing.Point(216, 88);
            this.flpProdutos.Size = new System.Drawing.Size(450, 472);
            this.flpProdutos.Name = "flpProdutos";
            this.flpProdutos.TabIndex = 11;
            this.flpProdutos.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.flpProdutos.AutoScroll = true;
            //
            // pnlPedido
            //
            this.pnlPedido.Controls.Add(this.lblPedidoTitulo);
            this.pnlPedido.Controls.Add(this.lblCliente);
            this.pnlPedido.Controls.Add(this.cmbCliente);
            this.pnlPedido.Controls.Add(this.btnAddCliente);
            this.pnlPedido.Controls.Add(this.lstItens);
            this.pnlPedido.Controls.Add(this.btnRemover);
            this.pnlPedido.Controls.Add(this.lblTotal);
            this.pnlPedido.Controls.Add(this.btnFinalizar);
            this.pnlPedido.Location = new System.Drawing.Point(684, 88);
            this.pnlPedido.Size = new System.Drawing.Size(260, 472);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.TabIndex = 12;
            this.pnlPedido.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.pnlPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblPedidoTitulo
            //
            this.lblPedidoTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblPedidoTitulo.Size = new System.Drawing.Size(236, 30);
            this.lblPedidoTitulo.Name = "lblPedidoTitulo";
            this.lblPedidoTitulo.TabIndex = 13;
            this.lblPedidoTitulo.Text = "Pedido atual";
            this.lblPedidoTitulo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.lblPedidoTitulo.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPedidoTitulo.AutoSize = false;
            //
            // lblCliente
            //
            this.lblCliente.Location = new System.Drawing.Point(12, 50);
            this.lblCliente.Size = new System.Drawing.Size(236, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.AutoSize = false;
            //
            // cmbCliente
            //
            this.cmbCliente.Location = new System.Drawing.Point(12, 72);
            this.cmbCliente.Size = new System.Drawing.Size(176, 28);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.TabIndex = 15;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            //
            // btnAddCliente
            //
            this.btnAddCliente.Location = new System.Drawing.Point(196, 71);
            this.btnAddCliente.Size = new System.Drawing.Size(36, 30);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.TabIndex = 16;
            this.btnAddCliente.Text = "+";
            this.btnAddCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnAddCliente.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnAddCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            //
            // lstItens
            //
            this.lstItens.Location = new System.Drawing.Point(12, 116);
            this.lstItens.Size = new System.Drawing.Size(234, 200);
            this.lstItens.Name = "lstItens";
            this.lstItens.TabIndex = 17;
            this.lstItens.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 19;
            //
            // btnRemover
            //
            this.btnRemover.Location = new System.Drawing.Point(12, 324);
            this.btnRemover.Size = new System.Drawing.Size(234, 32);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.TabIndex = 18;
            this.btnRemover.Text = "Remover item selecionado";
            this.btnRemover.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnRemover.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            //
            // lblTotal
            //
            this.lblTotal.Location = new System.Drawing.Point(12, 370);
            this.lblTotal.Size = new System.Drawing.Size(234, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: R$ 0,00";
            this.lblTotal.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.AutoSize = false;
            //
            // btnFinalizar
            //
            this.btnFinalizar.Location = new System.Drawing.Point(12, 412);
            this.btnFinalizar.Size = new System.Drawing.Size(234, 44);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar pedido";
            this.btnFinalizar.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnFinalizar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            //
            // FrmPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.flpProdutos);
            this.Controls.Add(this.pnlPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTopo.ResumeLayout(false);
            this.flpProdutos.ResumeLayout(false);
            this.pnlPedido.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnMenuInicio;
        private System.Windows.Forms.Button btnMenuProdutos;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnMenuPedidos;
        private System.Windows.Forms.Button btnMenuRelatorios;
        private System.Windows.Forms.Button btnMenuSair;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.FlowLayoutPanel flpProdutos;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label lblPedidoTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
