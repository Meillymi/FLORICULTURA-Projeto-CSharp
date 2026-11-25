namespace FLORICULTURA_Projeto_CSharp
{
    partial class FrmAddCategoria
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
            this.pnlTopoDlg = new System.Windows.Forms.Panel();
            this.lblTituloDlg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTopoDlg.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlTopoDlg
            //
            this.pnlTopoDlg.Controls.Add(this.lblTituloDlg);
            this.pnlTopoDlg.Location = new System.Drawing.Point(0, 0);
            this.pnlTopoDlg.Size = new System.Drawing.Size(340, 56);
            this.pnlTopoDlg.Name = "pnlTopoDlg";
            this.pnlTopoDlg.TabIndex = 0;
            this.pnlTopoDlg.BackColor = System.Drawing.ColorTranslator.FromHtml("#F9C6D6");
            this.pnlTopoDlg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopoDlg_MouseDown);
            //
            // lblTituloDlg
            //
            this.lblTituloDlg.Location = new System.Drawing.Point(16, 10);
            this.lblTituloDlg.Size = new System.Drawing.Size(280, 36);
            this.lblTituloDlg.Name = "lblTituloDlg";
            this.lblTituloDlg.TabIndex = 1;
            this.lblTituloDlg.Text = "Nova categoria";
            this.lblTituloDlg.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblTituloDlg.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTituloDlg.AutoSize = false;
            this.lblTituloDlg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloDlg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopoDlg_MouseDown);
            //
            // lblNome
            //
            this.lblNome.Location = new System.Drawing.Point(24, 76);
            this.lblNome.Size = new System.Drawing.Size(292, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome da categoria";
            this.lblNome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7A2D4A");
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNome.AutoSize = false;
            //
            // txtNome
            //
            this.txtNome.Location = new System.Drawing.Point(24, 98);
            this.txtNome.Size = new System.Drawing.Size(292, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.TabIndex = 3;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(24, 146);
            this.btnSalvar.Size = new System.Drawing.Size(140, 40);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.BackColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnSalvar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(176, 146);
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            this.btnCancelar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#B83B61");
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FrmAddCategoria
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFF3F7");
            this.ClientSize = new System.Drawing.Size(340, 210);
            this.Controls.Add(this.pnlTopoDlg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova categoria";
            this.Load += new System.EventHandler(this.FrmAddCategoria_Load);
            this.pnlTopoDlg.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopoDlg;
        private System.Windows.Forms.Label lblTituloDlg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
