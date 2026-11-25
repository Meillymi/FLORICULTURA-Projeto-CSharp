namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmRelatorios
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
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1 = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2 = new System.Windows.Forms.Label();
            this.lblQtdPedidos = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3 = new System.Windows.Forms.Label();
            this.lblMaisVendido = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
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
            this.btnMenuRelatorios.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.btnMenuRelatorios.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnMenuRelatorios.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRelatorios.FlatAppearance.BorderSize = 0;
            this.btnMenuRelatorios.UseVisualStyleBackColor = false;
            this.btnMenuRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRelatorios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
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
            this.lblTitulo.Text = "Relatórios";
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
            // lblDe
            //
            this.lblDe.Location = new System.Drawing.Point(216, 88);
            this.lblDe.Size = new System.Drawing.Size(130, 18);
            this.lblDe.Name = "lblDe";
            this.lblDe.TabIndex = 11;
            this.lblDe.Text = "De";
            this.lblDe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDe.AutoSize = false;
            //
            // dtpDe
            //
            this.dtpDe.Location = new System.Drawing.Point(216, 110);
            this.dtpDe.Size = new System.Drawing.Size(130, 27);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.TabIndex = 12;
            this.dtpDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            //
            // lblAte
            //
            this.lblAte.Location = new System.Drawing.Point(360, 88);
            this.lblAte.Size = new System.Drawing.Size(130, 18);
            this.lblAte.Name = "lblAte";
            this.lblAte.TabIndex = 13;
            this.lblAte.Text = "Até";
            this.lblAte.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAte.AutoSize = false;
            //
            // dtpAte
            //
            this.dtpAte.Location = new System.Drawing.Point(360, 110);
            this.dtpAte.Size = new System.Drawing.Size(130, 27);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.TabIndex = 14;
            this.dtpAte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            //
            // lblCategoria
            //
            this.lblCategoria.Location = new System.Drawing.Point(504, 88);
            this.lblCategoria.Size = new System.Drawing.Size(170, 18);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.AutoSize = false;
            //
            // cmbCategoria
            //
            this.cmbCategoria.Location = new System.Drawing.Point(504, 110);
            this.cmbCategoria.Size = new System.Drawing.Size(170, 28);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.TabIndex = 16;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            //
            // btnGerar
            //
            this.btnGerar.Location = new System.Drawing.Point(690, 106);
            this.btnGerar.Size = new System.Drawing.Size(160, 36);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.TabIndex = 17;
            this.btnGerar.Text = "Gerar relatório";
            this.btnGerar.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnGerar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            //
            // pnlCard1
            //
            this.pnlCard1.Controls.Add(this.lblCard1);
            this.pnlCard1.Controls.Add(this.lblTotalVendas);
            this.pnlCard1.Location = new System.Drawing.Point(216, 160);
            this.pnlCard1.Size = new System.Drawing.Size(226, 84);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.TabIndex = 18;
            this.pnlCard1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblCard1
            //
            this.lblCard1.Location = new System.Drawing.Point(12, 10);
            this.lblCard1.Size = new System.Drawing.Size(200, 18);
            this.lblCard1.Name = "lblCard1";
            this.lblCard1.TabIndex = 19;
            this.lblCard1.Text = "Total de vendas";
            this.lblCard1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard1.AutoSize = false;
            //
            // lblTotalVendas
            //
            this.lblTotalVendas.Location = new System.Drawing.Point(12, 34);
            this.lblTotalVendas.Size = new System.Drawing.Size(200, 36);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.TabIndex = 20;
            this.lblTotalVendas.Text = "R$ 0,00";
            this.lblTotalVendas.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.lblTotalVendas.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTotalVendas.AutoSize = false;
            //
            // pnlCard2
            //
            this.pnlCard2.Controls.Add(this.lblCard2);
            this.pnlCard2.Controls.Add(this.lblQtdPedidos);
            this.pnlCard2.Location = new System.Drawing.Point(458, 160);
            this.pnlCard2.Size = new System.Drawing.Size(226, 84);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.TabIndex = 21;
            this.pnlCard2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblCard2
            //
            this.lblCard2.Location = new System.Drawing.Point(12, 10);
            this.lblCard2.Size = new System.Drawing.Size(200, 18);
            this.lblCard2.Name = "lblCard2";
            this.lblCard2.TabIndex = 22;
            this.lblCard2.Text = "Pedidos";
            this.lblCard2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCard2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard2.AutoSize = false;
            //
            // lblQtdPedidos
            //
            this.lblQtdPedidos.Location = new System.Drawing.Point(12, 34);
            this.lblQtdPedidos.Size = new System.Drawing.Size(200, 36);
            this.lblQtdPedidos.Name = "lblQtdPedidos";
            this.lblQtdPedidos.TabIndex = 23;
            this.lblQtdPedidos.Text = "0";
            this.lblQtdPedidos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.lblQtdPedidos.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblQtdPedidos.AutoSize = false;
            //
            // pnlCard3
            //
            this.pnlCard3.Controls.Add(this.lblCard3);
            this.pnlCard3.Controls.Add(this.lblMaisVendido);
            this.pnlCard3.Location = new System.Drawing.Point(700, 160);
            this.pnlCard3.Size = new System.Drawing.Size(226, 84);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.TabIndex = 24;
            this.pnlCard3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // lblCard3
            //
            this.lblCard3.Location = new System.Drawing.Point(12, 10);
            this.lblCard3.Size = new System.Drawing.Size(200, 18);
            this.lblCard3.Name = "lblCard3";
            this.lblCard3.TabIndex = 25;
            this.lblCard3.Text = "Mais vendido";
            this.lblCard3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblCard3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard3.AutoSize = false;
            //
            // lblMaisVendido
            //
            this.lblMaisVendido.Location = new System.Drawing.Point(12, 34);
            this.lblMaisVendido.Size = new System.Drawing.Size(200, 36);
            this.lblMaisVendido.Name = "lblMaisVendido";
            this.lblMaisVendido.TabIndex = 26;
            this.lblMaisVendido.Text = "—";
            this.lblMaisVendido.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.lblMaisVendido.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMaisVendido.AutoSize = false;
            //
            // dgvRelatorio
            //
            this.dgvRelatorio.Location = new System.Drawing.Point(216, 264);
            this.dgvRelatorio.Size = new System.Drawing.Size(728, 296);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.TabIndex = 27;
            this.dgvRelatorio.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //
            // FrmRelatorios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.pnlCard1);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.dgvRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTopo.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
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
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2;
        private System.Windows.Forms.Label lblQtdPedidos;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3;
        private System.Windows.Forms.Label lblMaisVendido;
        private System.Windows.Forms.DataGridView dgvRelatorio;
    }
}
