namespace Gestao_Admin
{
    partial class EstacionamentoControl
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
            this.PanelUnico = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLugaresInseridos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPorInserir = new System.Windows.Forms.Label();
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.painelEditarInicial = new System.Windows.Forms.Panel();
            this.lblnPorPreencher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreencher = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.painelEdita = new Guna.UI2.WinForms.Guna2Panel();
            this.panelConfiguracoes.SuspendLayout();
            this.painelEditarInicial.SuspendLayout();
            this.painelEdita.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUnico
            // 
            this.PanelUnico.AutoScroll = true;
            this.PanelUnico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelUnico.Location = new System.Drawing.Point(0, 111);
            this.PanelUnico.Name = "PanelUnico";
            this.PanelUnico.Size = new System.Drawing.Size(1925, 902);
            this.PanelUnico.TabIndex = 4;
            // 
            // lblLugaresInseridos
            // 
            this.lblLugaresInseridos.AutoSize = true;
            this.lblLugaresInseridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresInseridos.ForeColor = System.Drawing.Color.White;
            this.lblLugaresInseridos.Location = new System.Drawing.Point(696, 35);
            this.lblLugaresInseridos.Name = "lblLugaresInseridos";
            this.lblLugaresInseridos.Size = new System.Drawing.Size(27, 29);
            this.lblLugaresInseridos.TabIndex = 7;
            this.lblLugaresInseridos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lugares Ocupados:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lugares Vazios:";
            // 
            // lblPorInserir
            // 
            this.lblPorInserir.AutoSize = true;
            this.lblPorInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorInserir.ForeColor = System.Drawing.Color.White;
            this.lblPorInserir.Location = new System.Drawing.Point(287, 35);
            this.lblPorInserir.Name = "lblPorInserir";
            this.lblPorInserir.Size = new System.Drawing.Size(27, 29);
            this.lblPorInserir.TabIndex = 9;
            this.lblPorInserir.Text = "0";
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panelConfiguracoes.BorderRadius = 10;
            this.panelConfiguracoes.Controls.Add(this.painelEditarInicial);
            this.panelConfiguracoes.Controls.Add(this.btnEditar);
            this.panelConfiguracoes.Controls.Add(this.painelEdita);
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1925, 105);
            this.panelConfiguracoes.TabIndex = 5;
            // 
            // painelEditarInicial
            // 
            this.painelEditarInicial.Controls.Add(this.lblnPorPreencher);
            this.painelEditarInicial.Controls.Add(this.label6);
            this.painelEditarInicial.Controls.Add(this.btnPreencher);
            this.painelEditarInicial.Controls.Add(this.btnSalvar);
            this.painelEditarInicial.Location = new System.Drawing.Point(801, 5);
            this.painelEditarInicial.Name = "painelEditarInicial";
            this.painelEditarInicial.Size = new System.Drawing.Size(748, 97);
            this.painelEditarInicial.TabIndex = 13;
            this.painelEditarInicial.Visible = false;
            // 
            // lblnPorPreencher
            // 
            this.lblnPorPreencher.AutoSize = true;
            this.lblnPorPreencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnPorPreencher.ForeColor = System.Drawing.Color.White;
            this.lblnPorPreencher.Location = new System.Drawing.Point(676, 19);
            this.lblnPorPreencher.Name = "lblnPorPreencher";
            this.lblnPorPreencher.Size = new System.Drawing.Size(27, 29);
            this.lblnPorPreencher.TabIndex = 13;
            this.lblnPorPreencher.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lugares Para Preencher:";
            // 
            // btnPreencher
            // 
            this.btnPreencher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreencher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreencher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreencher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreencher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreencher.ForeColor = System.Drawing.Color.White;
            this.btnPreencher.Location = new System.Drawing.Point(189, 3);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(180, 45);
            this.btnPreencher.TabIndex = 1;
            this.btnPreencher.Text = "Preencher Automáticamente";
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(180, 45);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(1555, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 45);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // painelEdita
            // 
            this.painelEdita.Controls.Add(this.lblLugaresInseridos);
            this.painelEdita.Controls.Add(this.label1);
            this.painelEdita.Controls.Add(this.lblPorInserir);
            this.painelEdita.Controls.Add(this.label2);
            this.painelEdita.Location = new System.Drawing.Point(3, 5);
            this.painelEdita.Name = "painelEdita";
            this.painelEdita.Size = new System.Drawing.Size(727, 100);
            this.painelEdita.TabIndex = 11;
            this.painelEdita.Visible = false;
            this.painelEdita.Paint += new System.Windows.Forms.PaintEventHandler(this.painelEdita_Paint);
            // 
            // EstacionamentoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConfiguracoes);
            this.Controls.Add(this.PanelUnico);
            this.Name = "EstacionamentoControl";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.EstacionamentoControl_Load);
            this.panelConfiguracoes.ResumeLayout(false);
            this.painelEditarInicial.ResumeLayout(false);
            this.painelEditarInicial.PerformLayout();
            this.painelEdita.ResumeLayout(false);
            this.painelEdita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelUnico;
        private System.Windows.Forms.Label lblLugaresInseridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorInserir;
        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
        private Guna.UI2.WinForms.Guna2Panel painelEdita;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Panel painelEditarInicial;
        private System.Windows.Forms.Label lblnPorPreencher;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnPreencher;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
    }
}
