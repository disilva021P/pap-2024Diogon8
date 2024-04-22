namespace Gestao_Admin
{
    partial class Estacionamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacionamento));
            this.panelEstacionamentoEdit = new System.Windows.Forms.Panel();
            this.Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEstacionamentoEdit
            // 
            this.panelEstacionamentoEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelEstacionamentoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstacionamentoEdit.Location = new System.Drawing.Point(120, 0);
            this.panelEstacionamentoEdit.Name = "panelEstacionamentoEdit";
            this.panelEstacionamentoEdit.Size = new System.Drawing.Size(680, 450);
            this.panelEstacionamentoEdit.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.Controls.Add(this.btnSair);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(120, 450);
            this.Menu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.BorderRadius = 25;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSair.Location = new System.Drawing.Point(5, 898);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnSair.Size = new System.Drawing.Size(110, 106);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEstacionamentoEdit);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estacionamento";
            this.Text = "pa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estacionamento_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstacionamentoEdit;
        private Guna.UI2.WinForms.Guna2Panel Menu;
        private Guna.UI2.WinForms.Guna2Button btnSair;
    }
}