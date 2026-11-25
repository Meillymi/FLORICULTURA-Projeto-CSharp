namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmProdutos
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCad = new System.Windows.Forms.TabPage();
            this.tabBusca = new System.Windows.Forms.TabPage();
            this.tabAlt = new System.Windows.Forms.TabPage();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblDica = new System.Windows.Forms.Label();
            this.lblNomeAlt = new System.Windows.Forms.Label();
            this.txtNomeAlt = new System.Windows.Forms.TextBox();
            this.lblCategoriaAlt = new System.Windows.Forms.Label();
            this.cmbCategoriaAlt = new System.Windows.Forms.ComboBox();
            this.lblPrecoAlt = new System.Windows.Forms.Label();
            this.txtPrecoAlt = new System.Windows.Forms.TextBox();
            this.lblEstoqueAlt = new System.Windows.Forms.Label();
            this.txtEstoqueAlt = new System.Windows.Forms.TextBox();
            this.lblImagemAlt = new System.Windows.Forms.Label();
            this.picAlt = new System.Windows.Forms.PictureBox();
            this.btnEscolherImagemAlt = new System.Windows.Forms.Button();
            this.lblCaminhoAlt = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnConfirmarAlteracao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlt)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabCad.SuspendLayout();
            this.tabBusca.SuspendLayout();
            this.tabAlt.SuspendLayout();
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
            this.btnMenuProdutos.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.btnMenuProdutos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuProdutos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProdutos.FlatAppearance.BorderSize = 0;
            this.btnMenuProdutos.UseVisualStyleBackColor = false;
            this.btnMenuProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProdutos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
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
            this.lblTitulo.Text = "Produtos";
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
            // tabs
            //
            this.tabs.Controls.Add(this.tabCad);
            this.tabs.Controls.Add(this.tabBusca);
            this.tabs.Controls.Add(this.tabAlt);
            this.tabs.Location = new System.Drawing.Point(216, 88);
            this.tabs.Size = new System.Drawing.Size(728, 476);
            this.tabs.Name = "tabs";
            this.tabs.TabIndex = 11;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabs.ItemSize = new System.Drawing.Size(130, 34);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.SelectedIndex = 0;
            //
            // tabCad
            //
            this.tabCad.Controls.Add(this.lblNome);
            this.tabCad.Controls.Add(this.txtNome);
            this.tabCad.Controls.Add(this.lblCategoria);
            this.tabCad.Controls.Add(this.cmbCategoria);
            this.tabCad.Controls.Add(this.lblPreco);
            this.tabCad.Controls.Add(this.txtPreco);
            this.tabCad.Controls.Add(this.lblEstoque);
            this.tabCad.Controls.Add(this.txtEstoque);
            this.tabCad.Controls.Add(this.lblImagem);
            this.tabCad.Controls.Add(this.picProduto);
            this.tabCad.Controls.Add(this.btnEscolherImagem);
            this.tabCad.Controls.Add(this.lblCaminho);
            this.tabCad.Controls.Add(this.btnAddCategoria);
            this.tabCad.Controls.Add(this.btnCadastrar);
            this.tabCad.Name = "tabCad";
            this.tabCad.TabIndex = 12;
            this.tabCad.Text = "Cadastrar";
            this.tabCad.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.tabCad.UseVisualStyleBackColor = false;
            //
            // tabBusca
            //
            this.tabBusca.Controls.Add(this.txtBuscar);
            this.tabBusca.Controls.Add(this.btnBuscar);
            this.tabBusca.Controls.Add(this.dgvProdutos);
            this.tabBusca.Controls.Add(this.lblDica);
            this.tabBusca.Name = "tabBusca";
            this.tabBusca.TabIndex = 13;
            this.tabBusca.Text = "Buscar";
            this.tabBusca.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.tabBusca.UseVisualStyleBackColor = false;
            //
            // tabAlt
            //
            this.tabAlt.Controls.Add(this.lblNomeAlt);
            this.tabAlt.Controls.Add(this.txtNomeAlt);
            this.tabAlt.Controls.Add(this.lblCategoriaAlt);
            this.tabAlt.Controls.Add(this.cmbCategoriaAlt);
            this.tabAlt.Controls.Add(this.lblPrecoAlt);
            this.tabAlt.Controls.Add(this.txtPrecoAlt);
            this.tabAlt.Controls.Add(this.lblEstoqueAlt);
            this.tabAlt.Controls.Add(this.txtEstoqueAlt);
            this.tabAlt.Controls.Add(this.lblImagemAlt);
            this.tabAlt.Controls.Add(this.picAlt);
            this.tabAlt.Controls.Add(this.btnEscolherImagemAlt);
            this.tabAlt.Controls.Add(this.lblCaminhoAlt);
            this.tabAlt.Controls.Add(this.lblAviso);
            this.tabAlt.Controls.Add(this.btnConfirmarAlteracao);
            this.tabAlt.Name = "tabAlt";
            this.tabAlt.TabIndex = 14;
            this.tabAlt.Text = "Alterar";
            this.tabAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.tabAlt.UseVisualStyleBackColor = false;
            //
            // lblNome
            //
            this.lblNome.Location = new System.Drawing.Point(16, 12);
            this.lblNome.Size = new System.Drawing.Size(300, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            this.lblNome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNome.AutoSize = false;
            //
            // txtNome
            //
            this.txtNome.Location = new System.Drawing.Point(16, 32);
            this.txtNome.Size = new System.Drawing.Size(300, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.TabIndex = 16;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblCategoria
            //
            this.lblCategoria.Location = new System.Drawing.Point(16, 72);
            this.lblCategoria.Size = new System.Drawing.Size(300, 18);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.AutoSize = false;
            //
            // cmbCategoria
            //
            this.cmbCategoria.Location = new System.Drawing.Point(16, 92);
            this.cmbCategoria.Size = new System.Drawing.Size(256, 28);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.TabIndex = 18;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            //
            // lblPreco
            //
            this.lblPreco.Location = new System.Drawing.Point(16, 132);
            this.lblPreco.Size = new System.Drawing.Size(140, 18);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.TabIndex = 19;
            this.lblPreco.Text = "Preço (R$)";
            this.lblPreco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPreco.AutoSize = false;
            //
            // txtPreco
            //
            this.txtPreco.Location = new System.Drawing.Point(16, 152);
            this.txtPreco.Size = new System.Drawing.Size(144, 27);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.TabIndex = 20;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblEstoque
            //
            this.lblEstoque.Location = new System.Drawing.Point(172, 132);
            this.lblEstoque.Size = new System.Drawing.Size(140, 18);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.TabIndex = 21;
            this.lblEstoque.Text = "Estoque";
            this.lblEstoque.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstoque.AutoSize = false;
            //
            // txtEstoque
            //
            this.txtEstoque.Location = new System.Drawing.Point(172, 152);
            this.txtEstoque.Size = new System.Drawing.Size(144, 27);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.TabIndex = 22;
            this.txtEstoque.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblImagem
            //
            this.lblImagem.Location = new System.Drawing.Point(16, 192);
            this.lblImagem.Size = new System.Drawing.Size(300, 18);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.TabIndex = 23;
            this.lblImagem.Text = "Imagem do produto";
            this.lblImagem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblImagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImagem.AutoSize = false;
            //
            // picProduto
            //
            this.picProduto.Location = new System.Drawing.Point(16, 214);
            this.picProduto.Size = new System.Drawing.Size(100, 100);
            this.picProduto.Name = "picProduto";
            this.picProduto.TabIndex = 24;
            this.picProduto.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabStop = false;
            //
            // btnEscolherImagem
            //
            this.btnEscolherImagem.Location = new System.Drawing.Point(128, 214);
            this.btnEscolherImagem.Size = new System.Drawing.Size(150, 34);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.TabIndex = 25;
            this.btnEscolherImagem.Text = "Escolher imagem";
            this.btnEscolherImagem.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnEscolherImagem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnEscolherImagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEscolherImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherImagem.FlatAppearance.BorderSize = 2;
            this.btnEscolherImagem.UseVisualStyleBackColor = false;
            this.btnEscolherImagem.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            //
            // lblCaminho
            //
            this.lblCaminho.Location = new System.Drawing.Point(128, 256);
            this.lblCaminho.Size = new System.Drawing.Size(190, 36);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.TabIndex = 26;
            this.lblCaminho.Text = "Nenhuma imagem";
            this.lblCaminho.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCaminho.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCaminho.AutoSize = false;
            //
            // btnAddCategoria
            //
            this.btnAddCategoria.Location = new System.Drawing.Point(280, 91);
            this.btnAddCategoria.Size = new System.Drawing.Size(36, 30);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.TabIndex = 27;
            this.btnAddCategoria.Text = "+";
            this.btnAddCategoria.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnAddCategoria.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnAddCategoria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoria.FlatAppearance.BorderSize = 0;
            this.btnAddCategoria.UseVisualStyleBackColor = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            //
            // btnCadastrar
            //
            this.btnCadastrar.Location = new System.Drawing.Point(16, 340);
            this.btnCadastrar.Size = new System.Drawing.Size(300, 44);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnCadastrar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            //
            // txtBuscar
            //
            this.txtBuscar.Location = new System.Drawing.Point(16, 16);
            this.txtBuscar.Size = new System.Drawing.Size(420, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TabIndex = 29;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(448, 12);
            this.btnBuscar.Size = new System.Drawing.Size(120, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnBuscar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // dgvProdutos
            //
            this.dgvProdutos.Location = new System.Drawing.Point(16, 60);
            this.dgvProdutos.Size = new System.Drawing.Size(688, 340);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.TabIndex = 31;
            this.dgvProdutos.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            //
            // lblDica
            //
            this.lblDica.Location = new System.Drawing.Point(16, 404);
            this.lblDica.Size = new System.Drawing.Size(688, 18);
            this.lblDica.Name = "lblDica";
            this.lblDica.TabIndex = 32;
            this.lblDica.Text = "Dê dois cliques em um produto para alterá-lo.";
            this.lblDica.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDica.AutoSize = false;
            //
            // lblNomeAlt
            //
            this.lblNomeAlt.Location = new System.Drawing.Point(16, 12);
            this.lblNomeAlt.Size = new System.Drawing.Size(300, 18);
            this.lblNomeAlt.Name = "lblNomeAlt";
            this.lblNomeAlt.TabIndex = 33;
            this.lblNomeAlt.Text = "Nome";
            this.lblNomeAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblNomeAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeAlt.AutoSize = false;
            //
            // txtNomeAlt
            //
            this.txtNomeAlt.Location = new System.Drawing.Point(16, 32);
            this.txtNomeAlt.Size = new System.Drawing.Size(300, 27);
            this.txtNomeAlt.Name = "txtNomeAlt";
            this.txtNomeAlt.TabIndex = 34;
            this.txtNomeAlt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNomeAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblCategoriaAlt
            //
            this.lblCategoriaAlt.Location = new System.Drawing.Point(16, 72);
            this.lblCategoriaAlt.Size = new System.Drawing.Size(300, 18);
            this.lblCategoriaAlt.Name = "lblCategoriaAlt";
            this.lblCategoriaAlt.TabIndex = 35;
            this.lblCategoriaAlt.Text = "Categoria";
            this.lblCategoriaAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCategoriaAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaAlt.AutoSize = false;
            //
            // cmbCategoriaAlt
            //
            this.cmbCategoriaAlt.Location = new System.Drawing.Point(16, 92);
            this.cmbCategoriaAlt.Size = new System.Drawing.Size(300, 28);
            this.cmbCategoriaAlt.Name = "cmbCategoriaAlt";
            this.cmbCategoriaAlt.TabIndex = 36;
            this.cmbCategoriaAlt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoriaAlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaAlt.FormattingEnabled = true;
            //
            // lblPrecoAlt
            //
            this.lblPrecoAlt.Location = new System.Drawing.Point(16, 132);
            this.lblPrecoAlt.Size = new System.Drawing.Size(140, 18);
            this.lblPrecoAlt.Name = "lblPrecoAlt";
            this.lblPrecoAlt.TabIndex = 37;
            this.lblPrecoAlt.Text = "Preço (R$)";
            this.lblPrecoAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblPrecoAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecoAlt.AutoSize = false;
            //
            // txtPrecoAlt
            //
            this.txtPrecoAlt.Location = new System.Drawing.Point(16, 152);
            this.txtPrecoAlt.Size = new System.Drawing.Size(144, 27);
            this.txtPrecoAlt.Name = "txtPrecoAlt";
            this.txtPrecoAlt.TabIndex = 38;
            this.txtPrecoAlt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrecoAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblEstoqueAlt
            //
            this.lblEstoqueAlt.Location = new System.Drawing.Point(172, 132);
            this.lblEstoqueAlt.Size = new System.Drawing.Size(140, 18);
            this.lblEstoqueAlt.Name = "lblEstoqueAlt";
            this.lblEstoqueAlt.TabIndex = 39;
            this.lblEstoqueAlt.Text = "Estoque";
            this.lblEstoqueAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblEstoqueAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstoqueAlt.AutoSize = false;
            //
            // txtEstoqueAlt
            //
            this.txtEstoqueAlt.Location = new System.Drawing.Point(172, 152);
            this.txtEstoqueAlt.Size = new System.Drawing.Size(144, 27);
            this.txtEstoqueAlt.Name = "txtEstoqueAlt";
            this.txtEstoqueAlt.TabIndex = 40;
            this.txtEstoqueAlt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEstoqueAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblImagemAlt
            //
            this.lblImagemAlt.Location = new System.Drawing.Point(16, 192);
            this.lblImagemAlt.Size = new System.Drawing.Size(300, 18);
            this.lblImagemAlt.Name = "lblImagemAlt";
            this.lblImagemAlt.TabIndex = 41;
            this.lblImagemAlt.Text = "Imagem do produto";
            this.lblImagemAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblImagemAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImagemAlt.AutoSize = false;
            //
            // picAlt
            //
            this.picAlt.Location = new System.Drawing.Point(16, 214);
            this.picAlt.Size = new System.Drawing.Size(100, 100);
            this.picAlt.Name = "picAlt";
            this.picAlt.TabIndex = 42;
            this.picAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.picAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlt.TabStop = false;
            //
            // btnEscolherImagemAlt
            //
            this.btnEscolherImagemAlt.Location = new System.Drawing.Point(128, 214);
            this.btnEscolherImagemAlt.Size = new System.Drawing.Size(150, 34);
            this.btnEscolherImagemAlt.Name = "btnEscolherImagemAlt";
            this.btnEscolherImagemAlt.TabIndex = 43;
            this.btnEscolherImagemAlt.Text = "Escolher imagem";
            this.btnEscolherImagemAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnEscolherImagemAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnEscolherImagemAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEscolherImagemAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherImagemAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherImagemAlt.FlatAppearance.BorderSize = 2;
            this.btnEscolherImagemAlt.UseVisualStyleBackColor = false;
            this.btnEscolherImagemAlt.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnEscolherImagemAlt.Click += new System.EventHandler(this.btnEscolherImagemAlt_Click);
            //
            // lblCaminhoAlt
            //
            this.lblCaminhoAlt.Location = new System.Drawing.Point(128, 256);
            this.lblCaminhoAlt.Size = new System.Drawing.Size(190, 36);
            this.lblCaminhoAlt.Name = "lblCaminhoAlt";
            this.lblCaminhoAlt.TabIndex = 44;
            this.lblCaminhoAlt.Text = "Nenhuma imagem";
            this.lblCaminhoAlt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCaminhoAlt.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCaminhoAlt.AutoSize = false;
            //
            // lblAviso
            //
            this.lblAviso.Location = new System.Drawing.Point(340, 12);
            this.lblAviso.Size = new System.Drawing.Size(340, 60);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.TabIndex = 45;
            this.lblAviso.Text = "Escolha o produto na aba Buscar (dois cliques) para alterar aqui.";
            this.lblAviso.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAviso.AutoSize = false;
            //
            // btnConfirmarAlteracao
            //
            this.btnConfirmarAlteracao.Location = new System.Drawing.Point(16, 340);
            this.btnConfirmarAlteracao.Size = new System.Drawing.Size(300, 44);
            this.btnConfirmarAlteracao.Name = "btnConfirmarAlteracao";
            this.btnConfirmarAlteracao.TabIndex = 46;
            this.btnConfirmarAlteracao.Text = "Confirmar alteração";
            this.btnConfirmarAlteracao.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnConfirmarAlteracao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnConfirmarAlteracao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmarAlteracao.UseVisualStyleBackColor = false;
            this.btnConfirmarAlteracao.Click += new System.EventHandler(this.btnConfirmarAlteracao_Click);
            //
            // FrmProdutos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTopo.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabCad.ResumeLayout(false);
            this.tabBusca.ResumeLayout(false);
            this.tabAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlt)).EndInit();
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
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCad;
        private System.Windows.Forms.TabPage tabBusca;
        private System.Windows.Forms.TabPage tabAlt;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label lblNomeAlt;
        private System.Windows.Forms.TextBox txtNomeAlt;
        private System.Windows.Forms.Label lblCategoriaAlt;
        private System.Windows.Forms.ComboBox cmbCategoriaAlt;
        private System.Windows.Forms.Label lblPrecoAlt;
        private System.Windows.Forms.TextBox txtPrecoAlt;
        private System.Windows.Forms.Label lblEstoqueAlt;
        private System.Windows.Forms.TextBox txtEstoqueAlt;
        private System.Windows.Forms.Label lblImagemAlt;
        private System.Windows.Forms.PictureBox picAlt;
        private System.Windows.Forms.Button btnEscolherImagemAlt;
        private System.Windows.Forms.Label lblCaminhoAlt;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnConfirmarAlteracao;
    }
}
