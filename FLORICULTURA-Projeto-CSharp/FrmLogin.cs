using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    public partial class FrmLogin : Form
    {
        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr h, int msg, int w, int l);

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Arredondar(btnAcessar, 22);
        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha o usuário e a senha.");
                txtUsuario.Focus();
                return;
            }
            Navegacao.IrPara(this, new FrmMenu());

        }

        private void Arredondar(Control c, int raio)
        {
            GraphicsPath p = new GraphicsPath();
            int d = raio * 2;
            p.AddArc(0, 0, d, d, 180, 90);
            p.AddArc(c.Width - d, 0, d, d, 270, 90);
            p.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            p.AddArc(0, c.Height - d, d, d, 90, 90);
            p.CloseFigure();
            c.Region = new Region(p);
        }
    }
}
