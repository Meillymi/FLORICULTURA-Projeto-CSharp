namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmMenu
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
            this.lblOla = new System.Windows.Forms.Label();
            this.btnCardProduto = new System.Windows.Forms.Button();
            this.btnCardClientes = new System.Windows.Forms.Button();
            this.btnCardPedido = new System.Windows.Forms.Button();
            this.btnCardRelatorios = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTopo.SuspendLayout();
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
            this.btnMenuInicio.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.btnMenuInicio.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicio.FlatAppearance.BorderSize = 0;
            this.btnMenuInicio.UseVisualStyleBackColor = false;
            this.btnMenuInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInicio.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
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
            this.btnMenuPedidos.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuPedidos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnMenuPedidos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPedidos.FlatAppearance.BorderSize = 0;
            this.btnMenuPedidos.UseVisualStyleBackColor = false;
            this.btnMenuPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPedidos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMenuPedidos.Click += new System.EventHandler(this.btnMenuPedidos_Click);
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
            this.lblTitulo.Text = "Início";
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
            // lblOla
            //
            this.lblOla.Location = new System.Drawing.Point(232, 96);
            this.lblOla.Size = new System.Drawing.Size(600, 28);
            this.lblOla.Name = "lblOla";
            this.lblOla.TabIndex = 11;
            this.lblOla.Text = "Olá! O que vamos fazer hoje?";
            this.lblOla.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblOla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOla.AutoSize = false;
            //
            // btnCardProduto
            //
            this.btnCardProduto.Location = new System.Drawing.Point(232, 140);
            this.btnCardProduto.Size = new System.Drawing.Size(330, 150);
            this.btnCardProduto.Name = "btnCardProduto";
            this.btnCardProduto.TabIndex = 12;
            this.btnCardProduto.Text = "Cadastrar produto";
            this.btnCardProduto.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCardProduto.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.btnCardProduto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCardProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardProduto.FlatAppearance.BorderSize = 2;
            this.btnCardProduto.UseVisualStyleBackColor = false;
            this.btnCardProduto.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F4A9C0");
            this.btnCardProduto.Click += new System.EventHandler(this.btnCardProduto_Click);
            //
            // btnCardClientes
            //
            this.btnCardClientes.Location = new System.Drawing.Point(582, 140);
            this.btnCardClientes.Size = new System.Drawing.Size(330, 150);
            this.btnCardClientes.Name = "btnCardClientes";
            this.btnCardClientes.TabIndex = 13;
            this.btnCardClientes.Text = "Clientes";
            this.btnCardClientes.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCardClientes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.btnCardClientes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCardClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardClientes.FlatAppearance.BorderSize = 2;
            this.btnCardClientes.UseVisualStyleBackColor = false;
            this.btnCardClientes.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F4A9C0");
            this.btnCardClientes.Click += new System.EventHandler(this.btnCardClientes_Click);
            //
            // btnCardPedido
            //
            this.btnCardPedido.Location = new System.Drawing.Point(232, 310);
            this.btnCardPedido.Size = new System.Drawing.Size(330, 150);
            this.btnCardPedido.Name = "btnCardPedido";
            this.btnCardPedido.TabIndex = 14;
            this.btnCardPedido.Text = "Novo pedido";
            this.btnCardPedido.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCardPedido.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.btnCardPedido.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCardPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPedido.FlatAppearance.BorderSize = 2;
            this.btnCardPedido.UseVisualStyleBackColor = false;
            this.btnCardPedido.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F4A9C0");
            this.btnCardPedido.Click += new System.EventHandler(this.btnCardPedido_Click);
            //
            // btnCardRelatorios
            //
            this.btnCardRelatorios.Location = new System.Drawing.Point(582, 310);
            this.btnCardRelatorios.Size = new System.Drawing.Size(330, 150);
            this.btnCardRelatorios.Name = "btnCardRelatorios";
            this.btnCardRelatorios.TabIndex = 15;
            this.btnCardRelatorios.Text = "Relatórios";
            this.btnCardRelatorios.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCardRelatorios.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.btnCardRelatorios.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCardRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardRelatorios.FlatAppearance.BorderSize = 2;
            this.btnCardRelatorios.UseVisualStyleBackColor = false;
            this.btnCardRelatorios.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#F4A9C0");
            this.btnCardRelatorios.Click += new System.EventHandler(this.btnCardRelatorios_Click);
            //
            // FrmMenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.btnCardProduto);
            this.Controls.Add(this.btnCardClientes);
            this.Controls.Add(this.btnCardPedido);
            this.Controls.Add(this.btnCardRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTopo.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Button btnCardProduto;
        private System.Windows.Forms.Button btnCardClientes;
        private System.Windows.Forms.Button btnCardPedido;
        private System.Windows.Forms.Button btnCardRelatorios;
    }
}
