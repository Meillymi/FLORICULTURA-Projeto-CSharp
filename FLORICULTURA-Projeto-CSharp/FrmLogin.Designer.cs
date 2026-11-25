namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlTopo = new Panel();
            lblFechar = new Label();
            lblLoja = new Label();
            picFlor = new PictureBox();
            lblBemVindo = new Label();
            lblSub = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnAcessar = new Button();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlor).BeginInit();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(244, 169, 192);
            pnlTopo.Controls.Add(lblFechar);
            pnlTopo.Controls.Add(lblLoja);
            pnlTopo.Controls.Add(picFlor);
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(480, 196);
            pnlTopo.TabIndex = 0;
            pnlTopo.MouseDown += pnlTopo_MouseDown;
            // 
            // lblFechar
            // 
            lblFechar.Cursor = Cursors.Hand;
            lblFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFechar.ForeColor = Color.FromArgb(122, 45, 74);
            lblFechar.Location = new Point(440, 8);
            lblFechar.Name = "lblFechar";
            lblFechar.Size = new Size(32, 32);
            lblFechar.TabIndex = 0;
            lblFechar.Text = "X";
            lblFechar.TextAlign = ContentAlignment.MiddleCenter;
            lblFechar.Click += lblFechar_Click;
            // 
            // lblLoja
            // 
            lblLoja.Font = new Font("Georgia", 20F, FontStyle.Bold | FontStyle.Italic);
            lblLoja.ForeColor = Color.FromArgb(122, 45, 74);
            lblLoja.Location = new Point(0, 128);
            lblLoja.Name = "lblLoja";
            lblLoja.Size = new Size(480, 44);
            lblLoja.TabIndex = 1;
            lblLoja.Text = "Floricultura";
            lblLoja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picFlor
            // 
            picFlor.BackColor = Color.Transparent;
            picFlor.Image = (Image)resources.GetObject("picFlor.Image");
            picFlor.Location = new Point(194, 26);
            picFlor.Name = "picFlor";
            picFlor.Size = new Size(92, 92);
            picFlor.SizeMode = PictureBoxSizeMode.Zoom;
            picFlor.TabIndex = 2;
            picFlor.TabStop = false;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Font = new Font("Georgia", 20F, FontStyle.Italic);
            lblBemVindo.ForeColor = Color.FromArgb(184, 59, 97);
            lblBemVindo.Location = new Point(0, 232);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(480, 40);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Bem-vindo(a)";
            lblBemVindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI", 9F);
            lblSub.ForeColor = Color.FromArgb(122, 45, 74);
            lblSub.Location = new Point(0, 272);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(480, 20);
            lblSub.TabIndex = 2;
            lblSub.Text = "Entre para ver as flores de hoje";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(122, 45, 74);
            lblUsuario.Location = new Point(80, 312);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(320, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(80, 334);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 27);
            txtUsuario.TabIndex = 0;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(122, 45, 74);
            lblSenha.Location = new Point(80, 380);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(320, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(80, 402);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(320, 27);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.FromArgb(184, 59, 97);
            btnAcessar.Cursor = Cursors.Hand;
            btnAcessar.FlatAppearance.BorderSize = 0;
            btnAcessar.FlatStyle = FlatStyle.Flat;
            btnAcessar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAcessar.ForeColor = Color.White;
            btnAcessar.Location = new Point(80, 462);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(320, 44);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 243, 247);
            ClientSize = new Size(480, 560);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblSub);
            Controls.Add(lblBemVindo);
            Controls.Add(pnlTopo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFlor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblLoja;
        private System.Windows.Forms.PictureBox picFlor;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessar;
    }
}
