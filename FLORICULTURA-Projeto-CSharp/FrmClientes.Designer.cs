namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmClientes
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
            pnlMenu = new Panel();
            lblMarca = new Label();
            btnMenuInicio = new Button();
            btnMenuProdutos = new Button();
            btnMenuClientes = new Button();
            btnMenuPedidos = new Button();
            btnMenuRelatorios = new Button();
            btnMenuSair = new Button();
            pnlTopo = new Panel();
            lblTitulo = new Label();
            lblFechar = new Label();
            tabs = new TabControl();
            tabCad = new TabPage();
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            tabBusca = new TabPage();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvClientes = new DataGridView();
            lblDica = new Label();
            tabAlt = new TabPage();
            lblNomeAlt = new Label();
            txtNomeAlt = new TextBox();
            lblTelefoneAlt = new Label();
            txtTelefoneAlt = new TextBox();
            lblEmailAlt = new Label();
            txtEmailAlt = new TextBox();
            lblEnderecoAlt = new Label();
            txtEnderecoAlt = new TextBox();
            lblAviso = new Label();
            btnConfirmarAlteracao = new Button();
            pnlMenu.SuspendLayout();
            pnlTopo.SuspendLayout();
            tabs.SuspendLayout();
            tabCad.SuspendLayout();
            tabBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabAlt.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(184, 59, 97);
            pnlMenu.Controls.Add(lblMarca);
            pnlMenu.Controls.Add(btnMenuInicio);
            pnlMenu.Controls.Add(btnMenuProdutos);
            pnlMenu.Controls.Add(btnMenuClientes);
            pnlMenu.Controls.Add(btnMenuPedidos);
            pnlMenu.Controls.Add(btnMenuRelatorios);
            pnlMenu.Controls.Add(btnMenuSair);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(229, 773);
            pnlMenu.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.Font = new Font("Georgia", 14F, FontStyle.Bold | FontStyle.Italic);
            lblMarca.ForeColor = Color.FromArgb(255, 243, 247);
            lblMarca.Location = new Point(21, 27);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(194, 48);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Floricultura";
            lblMarca.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMenuInicio
            // 
            btnMenuInicio.BackColor = Color.FromArgb(184, 59, 97);
            btnMenuInicio.Cursor = Cursors.Hand;
            btnMenuInicio.FlatAppearance.BorderSize = 0;
            btnMenuInicio.FlatStyle = FlatStyle.Flat;
            btnMenuInicio.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuInicio.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuInicio.Location = new Point(16, 112);
            btnMenuInicio.Margin = new Padding(3, 4, 3, 4);
            btnMenuInicio.Name = "btnMenuInicio";
            btnMenuInicio.Padding = new Padding(21, 0, 0, 0);
            btnMenuInicio.Size = new Size(197, 59);
            btnMenuInicio.TabIndex = 2;
            btnMenuInicio.Text = "Início";
            btnMenuInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInicio.UseVisualStyleBackColor = false;
            btnMenuInicio.Click += btnMenuInicio_Click;
            // 
            // btnMenuProdutos
            // 
            btnMenuProdutos.BackColor = Color.FromArgb(184, 59, 97);
            btnMenuProdutos.Cursor = Cursors.Hand;
            btnMenuProdutos.FlatAppearance.BorderSize = 0;
            btnMenuProdutos.FlatStyle = FlatStyle.Flat;
            btnMenuProdutos.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuProdutos.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuProdutos.Location = new Point(16, 176);
            btnMenuProdutos.Margin = new Padding(3, 4, 3, 4);
            btnMenuProdutos.Name = "btnMenuProdutos";
            btnMenuProdutos.Padding = new Padding(21, 0, 0, 0);
            btnMenuProdutos.Size = new Size(197, 59);
            btnMenuProdutos.TabIndex = 3;
            btnMenuProdutos.Text = "Produtos";
            btnMenuProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProdutos.UseVisualStyleBackColor = false;
            btnMenuProdutos.Click += btnMenuProdutos_Click;
            // 
            // btnMenuClientes
            // 
            btnMenuClientes.BackColor = Color.FromArgb(255, 243, 247);
            btnMenuClientes.Cursor = Cursors.Hand;
            btnMenuClientes.FlatAppearance.BorderSize = 0;
            btnMenuClientes.FlatStyle = FlatStyle.Flat;
            btnMenuClientes.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuClientes.ForeColor = Color.FromArgb(184, 59, 97);
            btnMenuClientes.Location = new Point(16, 240);
            btnMenuClientes.Margin = new Padding(3, 4, 3, 4);
            btnMenuClientes.Name = "btnMenuClientes";
            btnMenuClientes.Padding = new Padding(21, 0, 0, 0);
            btnMenuClientes.Size = new Size(197, 59);
            btnMenuClientes.TabIndex = 4;
            btnMenuClientes.Text = "Clientes";
            btnMenuClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuClientes.UseVisualStyleBackColor = false;
            btnMenuClientes.Click += btnMenuClientes_Click;
            // 
            // btnMenuPedidos
            // 
            btnMenuPedidos.BackColor = Color.FromArgb(184, 59, 97);
            btnMenuPedidos.Cursor = Cursors.Hand;
            btnMenuPedidos.FlatAppearance.BorderSize = 0;
            btnMenuPedidos.FlatStyle = FlatStyle.Flat;
            btnMenuPedidos.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuPedidos.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuPedidos.Location = new Point(16, 304);
            btnMenuPedidos.Margin = new Padding(3, 4, 3, 4);
            btnMenuPedidos.Name = "btnMenuPedidos";
            btnMenuPedidos.Padding = new Padding(21, 0, 0, 0);
            btnMenuPedidos.Size = new Size(197, 59);
            btnMenuPedidos.TabIndex = 5;
            btnMenuPedidos.Text = "Pedidos";
            btnMenuPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPedidos.UseVisualStyleBackColor = false;
            btnMenuPedidos.Click += btnMenuPedidos_Click;
            // 
            // btnMenuRelatorios
            // 
            btnMenuRelatorios.BackColor = Color.FromArgb(184, 59, 97);
            btnMenuRelatorios.Cursor = Cursors.Hand;
            btnMenuRelatorios.FlatAppearance.BorderSize = 0;
            btnMenuRelatorios.FlatStyle = FlatStyle.Flat;
            btnMenuRelatorios.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuRelatorios.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuRelatorios.Location = new Point(16, 368);
            btnMenuRelatorios.Margin = new Padding(3, 4, 3, 4);
            btnMenuRelatorios.Name = "btnMenuRelatorios";
            btnMenuRelatorios.Padding = new Padding(21, 0, 0, 0);
            btnMenuRelatorios.Size = new Size(197, 59);
            btnMenuRelatorios.TabIndex = 6;
            btnMenuRelatorios.Text = "Relatórios";
            btnMenuRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuRelatorios.UseVisualStyleBackColor = false;
            btnMenuRelatorios.Click += btnMenuRelatorios_Click;
            // 
            // btnMenuSair
            // 
            btnMenuSair.BackColor = Color.FromArgb(184, 59, 97);
            btnMenuSair.Cursor = Cursors.Hand;
            btnMenuSair.FlatAppearance.BorderSize = 0;
            btnMenuSair.FlatStyle = FlatStyle.Flat;
            btnMenuSair.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuSair.ForeColor = Color.FromArgb(255, 255, 255);
            btnMenuSair.Location = new Point(16, 688);
            btnMenuSair.Margin = new Padding(3, 4, 3, 4);
            btnMenuSair.Name = "btnMenuSair";
            btnMenuSair.Padding = new Padding(21, 0, 0, 0);
            btnMenuSair.Size = new Size(197, 59);
            btnMenuSair.TabIndex = 7;
            btnMenuSair.Text = "Sair";
            btnMenuSair.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSair.UseVisualStyleBackColor = false;
            btnMenuSair.Click += btnMenuSair_Click;
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(249, 198, 214);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblFechar);
            pnlTopo.Location = new Point(229, 0);
            pnlTopo.Margin = new Padding(3, 4, 3, 4);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(869, 96);
            pnlTopo.TabIndex = 8;
            pnlTopo.MouseDown += pnlTopo_MouseDown;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.ForeColor = Color.FromArgb(122, 45, 74);
            lblTitulo.Location = new Point(27, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(571, 53);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.MouseDown += pnlTopo_MouseDown;
            // 
            // lblFechar
            // 
            lblFechar.Cursor = Cursors.Hand;
            lblFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFechar.ForeColor = Color.FromArgb(122, 45, 74);
            lblFechar.Location = new Point(818, 27);
            lblFechar.Name = "lblFechar";
            lblFechar.Size = new Size(37, 43);
            lblFechar.TabIndex = 10;
            lblFechar.Text = "X";
            lblFechar.TextAlign = ContentAlignment.MiddleCenter;
            lblFechar.Click += lblFechar_Click;
            // 
            // tabs
            // 
            tabs.Appearance = TabAppearance.Buttons;
            tabs.Controls.Add(tabCad);
            tabs.Controls.Add(tabBusca);
            tabs.Controls.Add(tabAlt);
            tabs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabs.ItemSize = new Size(130, 34);
            tabs.Location = new Point(247, 117);
            tabs.Margin = new Padding(3, 4, 3, 4);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(832, 635);
            tabs.SizeMode = TabSizeMode.Fixed;
            tabs.TabIndex = 11;
            // 
            // tabCad
            // 
            tabCad.BackColor = Color.FromArgb(255, 243, 247);
            tabCad.Controls.Add(lblNome);
            tabCad.Controls.Add(txtNome);
            tabCad.Controls.Add(lblTelefone);
            tabCad.Controls.Add(txtTelefone);
            tabCad.Controls.Add(lblEmail);
            tabCad.Controls.Add(txtEmail);
            tabCad.Controls.Add(lblEndereco);
            tabCad.Controls.Add(txtEndereco);
            tabCad.Controls.Add(btnCadastrar);
            tabCad.Location = new Point(4, 38);
            tabCad.Margin = new Padding(3, 4, 3, 4);
            tabCad.Name = "tabCad";
            tabCad.Size = new Size(824, 593);
            tabCad.TabIndex = 12;
            tabCad.Text = "Cadastrar";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(122, 45, 74);
            lblNome.Location = new Point(18, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(343, 24);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(18, 43);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(343, 32);
            txtNome.TabIndex = 16;
            // 
            // lblTelefone
            // 
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(122, 45, 74);
            lblTelefone.Location = new Point(18, 96);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(343, 24);
            lblTelefone.TabIndex = 17;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Segoe UI", 11F);
            txtTelefone.Location = new Point(18, 123);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(343, 32);
            txtTelefone.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(122, 45, 74);
            lblEmail.Location = new Point(18, 176);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(343, 24);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(18, 203);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(343, 32);
            txtEmail.TabIndex = 20;
            // 
            // lblEndereco
            // 
            lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndereco.ForeColor = Color.FromArgb(122, 45, 74);
            lblEndereco.Location = new Point(18, 256);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(343, 24);
            lblEndereco.TabIndex = 21;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 11F);
            txtEndereco.Location = new Point(18, 283);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(343, 32);
            txtEndereco.TabIndex = 22;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(184, 59, 97);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.FromArgb(255, 255, 255);
            btnCadastrar.Location = new Point(18, 347);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(343, 59);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tabBusca
            // 
            tabBusca.BackColor = Color.FromArgb(255, 243, 247);
            tabBusca.Controls.Add(txtBuscar);
            tabBusca.Controls.Add(btnBuscar);
            tabBusca.Controls.Add(dgvClientes);
            tabBusca.Controls.Add(lblDica);
            tabBusca.Location = new Point(4, 38);
            tabBusca.Margin = new Padding(3, 4, 3, 4);
            tabBusca.Name = "tabBusca";
            tabBusca.Size = new Size(824, 593);
            tabBusca.TabIndex = 13;
            tabBusca.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(18, 21);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(480, 32);
            txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(184, 59, 97);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(255, 255, 255);
            btnBuscar.Location = new Point(512, 16);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 45);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.Location = new Point(18, 80);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(786, 453);
            dgvClientes.TabIndex = 26;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // lblDica
            // 
            lblDica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDica.ForeColor = Color.FromArgb(122, 45, 74);
            lblDica.Location = new Point(18, 539);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(786, 24);
            lblDica.TabIndex = 27;
            lblDica.Text = "Dê dois cliques em um cliente para alterá-lo.";
            // 
            // tabAlt
            // 
            tabAlt.BackColor = Color.FromArgb(255, 243, 247);
            tabAlt.Controls.Add(lblNomeAlt);
            tabAlt.Controls.Add(txtNomeAlt);
            tabAlt.Controls.Add(lblTelefoneAlt);
            tabAlt.Controls.Add(txtTelefoneAlt);
            tabAlt.Controls.Add(lblEmailAlt);
            tabAlt.Controls.Add(txtEmailAlt);
            tabAlt.Controls.Add(lblEnderecoAlt);
            tabAlt.Controls.Add(txtEnderecoAlt);
            tabAlt.Controls.Add(lblAviso);
            tabAlt.Controls.Add(btnConfirmarAlteracao);
            tabAlt.Location = new Point(4, 38);
            tabAlt.Margin = new Padding(3, 4, 3, 4);
            tabAlt.Name = "tabAlt";
            tabAlt.Size = new Size(824, 593);
            tabAlt.TabIndex = 14;
            tabAlt.Text = "Alterar";
            // 
            // lblNomeAlt
            // 
            lblNomeAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNomeAlt.ForeColor = Color.FromArgb(122, 45, 74);
            lblNomeAlt.Location = new Point(18, 16);
            lblNomeAlt.Name = "lblNomeAlt";
            lblNomeAlt.Size = new Size(343, 24);
            lblNomeAlt.TabIndex = 28;
            lblNomeAlt.Text = "Nome";
            // 
            // txtNomeAlt
            // 
            txtNomeAlt.BorderStyle = BorderStyle.FixedSingle;
            txtNomeAlt.Font = new Font("Segoe UI", 11F);
            txtNomeAlt.Location = new Point(18, 43);
            txtNomeAlt.Margin = new Padding(3, 4, 3, 4);
            txtNomeAlt.Name = "txtNomeAlt";
            txtNomeAlt.Size = new Size(343, 32);
            txtNomeAlt.TabIndex = 29;
            // 
            // lblTelefoneAlt
            // 
            lblTelefoneAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefoneAlt.ForeColor = Color.FromArgb(122, 45, 74);
            lblTelefoneAlt.Location = new Point(18, 96);
            lblTelefoneAlt.Name = "lblTelefoneAlt";
            lblTelefoneAlt.Size = new Size(343, 24);
            lblTelefoneAlt.TabIndex = 30;
            lblTelefoneAlt.Text = "Telefone";
            // 
            // txtTelefoneAlt
            // 
            txtTelefoneAlt.BorderStyle = BorderStyle.FixedSingle;
            txtTelefoneAlt.Font = new Font("Segoe UI", 11F);
            txtTelefoneAlt.Location = new Point(18, 123);
            txtTelefoneAlt.Margin = new Padding(3, 4, 3, 4);
            txtTelefoneAlt.Name = "txtTelefoneAlt";
            txtTelefoneAlt.Size = new Size(343, 32);
            txtTelefoneAlt.TabIndex = 31;
            // 
            // lblEmailAlt
            // 
            lblEmailAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailAlt.ForeColor = Color.FromArgb(122, 45, 74);
            lblEmailAlt.Location = new Point(18, 176);
            lblEmailAlt.Name = "lblEmailAlt";
            lblEmailAlt.Size = new Size(343, 24);
            lblEmailAlt.TabIndex = 32;
            lblEmailAlt.Text = "E-mail";
            // 
            // txtEmailAlt
            // 
            txtEmailAlt.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAlt.Font = new Font("Segoe UI", 11F);
            txtEmailAlt.Location = new Point(18, 203);
            txtEmailAlt.Margin = new Padding(3, 4, 3, 4);
            txtEmailAlt.Name = "txtEmailAlt";
            txtEmailAlt.Size = new Size(343, 32);
            txtEmailAlt.TabIndex = 33;
            // 
            // lblEnderecoAlt
            // 
            lblEnderecoAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnderecoAlt.ForeColor = Color.FromArgb(122, 45, 74);
            lblEnderecoAlt.Location = new Point(18, 256);
            lblEnderecoAlt.Name = "lblEnderecoAlt";
            lblEnderecoAlt.Size = new Size(343, 24);
            lblEnderecoAlt.TabIndex = 34;
            lblEnderecoAlt.Text = "Endereço";
            // 
            // txtEnderecoAlt
            // 
            txtEnderecoAlt.BorderStyle = BorderStyle.FixedSingle;
            txtEnderecoAlt.Font = new Font("Segoe UI", 11F);
            txtEnderecoAlt.Location = new Point(18, 283);
            txtEnderecoAlt.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoAlt.Name = "txtEnderecoAlt";
            txtEnderecoAlt.Size = new Size(343, 32);
            txtEnderecoAlt.TabIndex = 35;
            // 
            // lblAviso
            // 
            lblAviso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAviso.ForeColor = Color.FromArgb(122, 45, 74);
            lblAviso.Location = new Point(389, 16);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(389, 80);
            lblAviso.TabIndex = 36;
            lblAviso.Text = "Escolha o cliente na aba Buscar (dois cliques) para alterar aqui.";
            // 
            // btnConfirmarAlteracao
            // 
            btnConfirmarAlteracao.BackColor = Color.FromArgb(184, 59, 97);
            btnConfirmarAlteracao.Cursor = Cursors.Hand;
            btnConfirmarAlteracao.FlatAppearance.BorderSize = 0;
            btnConfirmarAlteracao.FlatStyle = FlatStyle.Flat;
            btnConfirmarAlteracao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirmarAlteracao.ForeColor = Color.FromArgb(255, 255, 255);
            btnConfirmarAlteracao.Location = new Point(18, 347);
            btnConfirmarAlteracao.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarAlteracao.Name = "btnConfirmarAlteracao";
            btnConfirmarAlteracao.Size = new Size(343, 59);
            btnConfirmarAlteracao.TabIndex = 37;
            btnConfirmarAlteracao.Text = "Confirmar alteração";
            btnConfirmarAlteracao.UseVisualStyleBackColor = false;
            btnConfirmarAlteracao.Click += btnConfirmarAlteracao_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 243, 247);
            ClientSize = new Size(1097, 773);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTopo);
            Controls.Add(tabs);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += FrmClientes_Load;
            pnlMenu.ResumeLayout(false);
            pnlTopo.ResumeLayout(false);
            tabs.ResumeLayout(false);
            tabCad.ResumeLayout(false);
            tabCad.PerformLayout();
            tabBusca.ResumeLayout(false);
            tabBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabAlt.ResumeLayout(false);
            tabAlt.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label lblNomeAlt;
        private System.Windows.Forms.TextBox txtNomeAlt;
        private System.Windows.Forms.Label lblTelefoneAlt;
        private System.Windows.Forms.TextBox txtTelefoneAlt;
        private System.Windows.Forms.Label lblEmailAlt;
        private System.Windows.Forms.TextBox txtEmailAlt;
        private System.Windows.Forms.Label lblEnderecoAlt;
        private System.Windows.Forms.TextBox txtEnderecoAlt;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnConfirmarAlteracao;
    }
}
