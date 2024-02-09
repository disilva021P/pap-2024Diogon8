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
            this.GestaoForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_menu = new Guna.UI2.WinForms.Guna2CircleButton();
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
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(121, 565);
            this.Menu.TabIndex = 0;
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
            this.btn_menu.Location = new System.Drawing.Point(87, 488);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_menu.Size = new System.Drawing.Size(76, 74);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = ">";
            this.btn_menu.UseTransparentBackground = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_ClickAsync);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestao";
            this.Text = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GestaoForm;
        private Guna.UI2.WinForms.Guna2Panel Menu;
        private Guna.UI2.WinForms.Guna2CircleButton btn_menu;
    }
}