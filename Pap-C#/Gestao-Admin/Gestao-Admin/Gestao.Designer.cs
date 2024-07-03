namespace Gestao_Admin
{
    partial class Gestao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestao));
            this.GestaoForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_menu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagamentos = new Guna.UI2.WinForms.Guna2Button();
            this.btnLugares = new Guna.UI2.WinForms.Guna2Button();
            this.btnOcorrencias = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirPortao = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnFecharPortao = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelPrincipal.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GestaoForm
            // 
            this.GestaoForm.AnimateWindow = true;
            this.GestaoForm.AnimationInterval = 1000;
            this.GestaoForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.GestaoForm.ContainerControl = this;
            this.GestaoForm.DockIndicatorTransparencyValue = 0.6D;
            this.GestaoForm.TransparentWhileDrag = true;
            // 
            // btn_menu
            // 
            this.btn_menu.Animated = true;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Location = new System.Drawing.Point(71, 488);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_menu.Size = new System.Drawing.Size(76, 74);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.Text = ">";
            this.btn_menu.UseTransparentBackground = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_ClickAsync);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AccessibleName = "PanelPrincipal";
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPrincipal.Controls.Add(this.btnFecharPortao);
            this.PanelPrincipal.Controls.Add(this.btnAbrirPortao);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(120, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1416, 1013);
            this.PanelPrincipal.TabIndex = 2;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 25;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDashboard.Location = new System.Drawing.Point(5, 56);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnDashboard.Size = new System.Drawing.Size(110, 106);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.Controls.Add(this.btnSair);
            this.Menu.Controls.Add(this.btn_menu);
            this.Menu.Controls.Add(this.btnPagamentos);
            this.Menu.Controls.Add(this.btnLugares);
            this.Menu.Controls.Add(this.btnOcorrencias);
            this.Menu.Controls.Add(this.btnUsers);
            this.Menu.Controls.Add(this.btnDashboard);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(120, 1013);
            this.Menu.TabIndex = 0;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
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
            // btnPagamentos
            // 
            this.btnPagamentos.Animated = true;
            this.btnPagamentos.BorderRadius = 25;
            this.btnPagamentos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagamentos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagamentos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagamentos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagamentos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnPagamentos.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPagamentos.ForeColor = System.Drawing.Color.White;
            this.btnPagamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamentos.Image")));
            this.btnPagamentos.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPagamentos.Location = new System.Drawing.Point(5, 751);
            this.btnPagamentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnPagamentos.Size = new System.Drawing.Size(110, 106);
            this.btnPagamentos.TabIndex = 4;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnLugares
            // 
            this.btnLugares.Animated = true;
            this.btnLugares.BorderRadius = 25;
            this.btnLugares.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLugares.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLugares.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLugares.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLugares.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnLugares.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnLugares.ForeColor = System.Drawing.Color.White;
            this.btnLugares.Image = ((System.Drawing.Image)(resources.GetObject("btnLugares.Image")));
            this.btnLugares.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLugares.Location = new System.Drawing.Point(5, 599);
            this.btnLugares.Margin = new System.Windows.Forms.Padding(0);
            this.btnLugares.Name = "btnLugares";
            this.btnLugares.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnLugares.Size = new System.Drawing.Size(110, 106);
            this.btnLugares.TabIndex = 3;
            this.btnLugares.Text = "Lugares";
            this.btnLugares.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLugares.Click += new System.EventHandler(this.btnLugares_Click);
            // 
            // btnOcorrencias
            // 
            this.btnOcorrencias.Animated = true;
            this.btnOcorrencias.BorderRadius = 25;
            this.btnOcorrencias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOcorrencias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOcorrencias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOcorrencias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOcorrencias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnOcorrencias.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnOcorrencias.ForeColor = System.Drawing.Color.White;
            this.btnOcorrencias.Image = ((System.Drawing.Image)(resources.GetObject("btnOcorrencias.Image")));
            this.btnOcorrencias.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOcorrencias.Location = new System.Drawing.Point(5, 326);
            this.btnOcorrencias.Margin = new System.Windows.Forms.Padding(0);
            this.btnOcorrencias.Name = "btnOcorrencias";
            this.btnOcorrencias.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnOcorrencias.Size = new System.Drawing.Size(110, 106);
            this.btnOcorrencias.TabIndex = 2;
            this.btnOcorrencias.Text = "Ocorrências";
            this.btnOcorrencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOcorrencias.Click += new System.EventHandler(this.btnOcorrencias_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.BorderRadius = 25;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUsers.Location = new System.Drawing.Point(5, 204);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.btnUsers.Size = new System.Drawing.Size(110, 106);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(734, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAbrirPortao
            // 
            this.btnAbrirPortao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirPortao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirPortao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbrirPortao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbrirPortao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrirPortao.ForeColor = System.Drawing.Color.White;
            this.btnAbrirPortao.Location = new System.Drawing.Point(646, 204);
            this.btnAbrirPortao.Name = "btnAbrirPortao";
            this.btnAbrirPortao.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAbrirPortao.Size = new System.Drawing.Size(148, 148);
            this.btnAbrirPortao.TabIndex = 1;
            this.btnAbrirPortao.Text = "Abrir Portão";
            this.btnAbrirPortao.Click += new System.EventHandler(this.btnAbrirPortao_Click);
            // 
            // btnFecharPortao
            // 
            this.btnFecharPortao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharPortao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharPortao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFecharPortao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFecharPortao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFecharPortao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFecharPortao.ForeColor = System.Drawing.Color.White;
            this.btnFecharPortao.Location = new System.Drawing.Point(884, 204);
            this.btnFecharPortao.Name = "btnFecharPortao";
            this.btnFecharPortao.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFecharPortao.Size = new System.Drawing.Size(148, 148);
            this.btnFecharPortao.TabIndex = 2;
            this.btnFecharPortao.Text = "Fechar Portão";
            this.btnFecharPortao.Click += new System.EventHandler(this.btnFecharPortao_Click);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1013);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestao";
            this.Text = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GestaoForm;
        private Guna.UI2.WinForms.Guna2CircleButton btn_menu;
        private Guna.UI2.WinForms.Guna2Panel Menu;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLugares;
        private Guna.UI2.WinForms.Guna2Button btnOcorrencias;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2Button btnPagamentos;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipal;
        private Guna.UI2.WinForms.Guna2CircleButton btnFecharPortao;
        private Guna.UI2.WinForms.Guna2CircleButton btnAbrirPortao;
        private System.Windows.Forms.Label label1;
    }
}