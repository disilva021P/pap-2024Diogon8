namespace Gestao_Admin
{
    partial class User
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ImageUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.txtDataInscricao = new System.Windows.Forms.Label();
            this.txtOcorrencias = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ImageUser);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(237, 186);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ImageUser
            // 
            this.ImageUser.BorderRadius = 25;
            this.ImageUser.ImageRotate = 0F;
            this.ImageUser.Location = new System.Drawing.Point(3, 3);
            this.ImageUser.Name = "ImageUser";
            this.ImageUser.Size = new System.Drawing.Size(231, 180);
            this.ImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageUser.TabIndex = 0;
            this.ImageUser.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(246, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(108, 39);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(250, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(51, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.AutoSize = true;
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(250, 115);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(134, 20);
            this.txtDataNascimento.TabIndex = 3;
            this.txtDataNascimento.Text = "DataNascimento";
            this.txtDataNascimento.Click += new System.EventHandler(this.txtDataNascimento_Click);
            // 
            // txtNif
            // 
            this.txtNif.AutoSize = true;
            this.txtNif.BackColor = System.Drawing.SystemColors.Control;
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(766, 22);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(51, 29);
            this.txtNif.TabIndex = 4;
            this.txtNif.Text = " Nif";
            // 
            // txtNumero
            // 
            this.txtNumero.AutoSize = true;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(504, 74);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.Text = "Número";
            // 
            // txtDataInscricao
            // 
            this.txtDataInscricao.AutoSize = true;
            this.txtDataInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInscricao.Location = new System.Drawing.Point(504, 115);
            this.txtDataInscricao.Name = "txtDataInscricao";
            this.txtDataInscricao.Size = new System.Drawing.Size(113, 20);
            this.txtDataInscricao.TabIndex = 6;
            this.txtDataInscricao.Text = "DataInscricao";
            // 
            // txtOcorrencias
            // 
            this.txtOcorrencias.AutoSize = true;
            this.txtOcorrencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcorrencias.Location = new System.Drawing.Point(767, 74);
            this.txtOcorrencias.Name = "txtOcorrencias";
            this.txtOcorrencias.Size = new System.Drawing.Size(113, 20);
            this.txtOcorrencias.TabIndex = 7;
            this.txtOcorrencias.Text = "NOcorrencias";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(767, 115);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(61, 20);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Text = "Estado";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtOcorrencias);
            this.Controls.Add(this.txtDataInscricao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1105, 192);
            this.Load += new System.EventHandler(this.User_Load);
            this.Click += new System.EventHandler(this.User_Click);
            this.Leave += new System.EventHandler(this.User_Leave);
            this.MouseCaptureChanged += new System.EventHandler(this.User_MouseCaptureChanged);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ImageUser;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtDataNascimento;
        private System.Windows.Forms.Label txtNif;
        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.Label txtDataInscricao;
        private System.Windows.Forms.Label txtOcorrencias;
        private System.Windows.Forms.Label txtEstado;
    }
}
