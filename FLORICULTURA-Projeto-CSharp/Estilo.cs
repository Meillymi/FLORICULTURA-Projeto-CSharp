using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FLORICULTURA_Projeto_CSharp
{
    // Funções de apoio usadas por todos os formulários
    public static class Estilo
    {
        public static readonly Color Rosa = ColorTranslator.FromHtml("#B83B61");
        public static readonly Color RosaClaro = ColorTranslator.FromHtml("#F4A9C0");
        public static readonly Color RosaFundo = ColorTranslator.FromHtml("#FDE0E9");
        public static readonly Color Texto = ColorTranslator.FromHtml("#4A2B38");

        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr h, int msg, int w, int l);

        // Arrastar um formulário sem borda
        public static void Arrastar(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xF012, 0);
        }

        // Cantos arredondados em qualquer controle
        public static void Arredondar(Control c, int raio)
        {
            int r = Math.Min(raio, Math.Min(c.Width, c.Height) / 2);
            int d = r * 2;
            GraphicsPath p = new GraphicsPath();
            p.AddArc(0, 0, d, d, 180, 90);
            p.AddArc(c.Width - d, 0, d, d, 270, 90);
            p.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            p.AddArc(0, c.Height - d, d, d, 90, 90);
            p.CloseFigure();
            c.Region = new Region(p);
        }

        // Deixa o DataGridView com a cara da floricultura
        public static void EstilizarGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 34;
            g.ColumnHeadersDefaultCellStyle.BackColor = Rosa;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Rosa;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            g.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            g.DefaultCellStyle.ForeColor = Texto;
            g.DefaultCellStyle.SelectionBackColor = RosaClaro;
            g.DefaultCellStyle.SelectionForeColor = Texto;
            g.AlternatingRowsDefaultCellStyle.BackColor = RosaFundo;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.ReadOnly = true;
            g.RowTemplate.Height = 28;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = RosaFundo;
        }

        // Lê a imagem do disco sem travar o arquivo (devolve null se não existir)
        public static Image CarregarImagem(string caminho)
        {
            if (string.IsNullOrEmpty(caminho) || !File.Exists(caminho)) return null;
            using (Image img = Image.FromFile(caminho))
            {
                return new Bitmap(img);
            }
        }

        // Copia a imagem escolhida para a pasta "Imagens" ao lado do programa e devolve o novo caminho
        public static string CopiarImagem(string origem)
        {
            string pasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagens");
            Directory.CreateDirectory(pasta);
            if (string.Equals(Path.GetDirectoryName(origem), pasta, StringComparison.OrdinalIgnoreCase)) return origem;
            string destino = Path.Combine(pasta, Guid.NewGuid().ToString("N") + Path.GetExtension(origem));
            File.Copy(origem, destino);
            return destino;
        }
    }

    // Troca de tela: abre a nova, fecha a anterior (o login só é escondido)
    public static class Navegacao
    {
        private static bool trocando = false;

        public static void IrPara(Form atual, Form destino)
        {
            destino.StartPosition = FormStartPosition.Manual;
            destino.Location = atual.Location;
            destino.FormClosed += (s, e) => { if (!trocando) Application.Exit(); };
            destino.Show();

            trocando = true;
            if (atual is FrmLogin) atual.Hide();
            else atual.Close();
            trocando = false;
        }
    }
}
