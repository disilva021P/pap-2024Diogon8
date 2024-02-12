namespace Gestao_Admin
{
    partial class Utilizadores
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
            this.PanelUnico = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // PanelUnico
            // 
            this.PanelUnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUnico.Location = new System.Drawing.Point(0, 0);
            this.PanelUnico.Name = "PanelUnico";
            this.PanelUnico.Size = new System.Drawing.Size(1925, 1013);
            this.PanelUnico.TabIndex = 0;
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelUnico);
            this.Name = "Utilizadores";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelUnico;
    }
}
