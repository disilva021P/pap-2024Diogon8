namespace Gestao_Admin
{
    partial class Ocorrencias
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
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelUnico = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panelConfiguracoes.BorderRadius = 10;
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1925, 105);
            this.panelConfiguracoes.TabIndex = 3;
            // 
            // PanelUnico
            // 
            this.PanelUnico.AutoScroll = true;
            this.PanelUnico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelUnico.Location = new System.Drawing.Point(0, 111);
            this.PanelUnico.Name = "PanelUnico";
            this.PanelUnico.Size = new System.Drawing.Size(1925, 902);
            this.PanelUnico.TabIndex = 2;
            // 
            // Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConfiguracoes);
            this.Controls.Add(this.PanelUnico);
            this.Name = "Ocorrencias";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.Ocorrencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
        private System.Windows.Forms.FlowLayoutPanel PanelUnico;
    }
}
