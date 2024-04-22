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
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.lblLugaresInseridos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPorInserir = new System.Windows.Forms.Label();
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.panelConfiguracoes.SuspendLayout();
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
            // btnSalvar
            // 
            this.btnSalvar.BorderThickness = 1;
            this.btnSalvar.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(887, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(183, 80);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            // 
            // lblLugaresInseridos
            // 
            this.lblLugaresInseridos.AutoSize = true;
            this.lblLugaresInseridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresInseridos.ForeColor = System.Drawing.Color.White;
            this.lblLugaresInseridos.Location = new System.Drawing.Point(683, 33);
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
            this.label1.Location = new System.Drawing.Point(464, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lugares inseridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lugares por inserir";
            // 
            // lblPorInserir
            // 
            this.lblPorInserir.AutoSize = true;
            this.lblPorInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorInserir.ForeColor = System.Drawing.Color.White;
            this.lblPorInserir.Location = new System.Drawing.Point(365, 33);
            this.lblPorInserir.Name = "lblPorInserir";
            this.lblPorInserir.Size = new System.Drawing.Size(27, 29);
            this.lblPorInserir.TabIndex = 9;
            this.lblPorInserir.Text = "0";
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panelConfiguracoes.BorderRadius = 10;
            this.panelConfiguracoes.Controls.Add(this.lblPorInserir);
            this.panelConfiguracoes.Controls.Add(this.label2);
            this.panelConfiguracoes.Controls.Add(this.label1);
            this.panelConfiguracoes.Controls.Add(this.lblLugaresInseridos);
            this.panelConfiguracoes.Controls.Add(this.btnSalvar);
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1925, 105);
            this.panelConfiguracoes.TabIndex = 5;
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
            this.panelConfiguracoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelUnico;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label lblLugaresInseridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorInserir;
        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
    }
}
