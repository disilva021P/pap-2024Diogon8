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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lugar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.lblLugaresInseridos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPorInserir = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 450);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPorInserir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLugaresInseridos);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.Lugar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 1;
            // 
            // Lugar
            // 
            this.Lugar.BorderThickness = 1;
            this.Lugar.CustomBorderColor = System.Drawing.Color.Black;
            this.Lugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Lugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Lugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Lugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Lugar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lugar.ForeColor = System.Drawing.Color.White;
            this.Lugar.Location = new System.Drawing.Point(25, 3);
            this.Lugar.Name = "Lugar";
            this.Lugar.Size = new System.Drawing.Size(100, 80);
            this.Lugar.TabIndex = 0;
            this.Lugar.Text = "Lugar";
            this.Lugar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lugar_MouseDown);
            this.Lugar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lugar_MouseUp);
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
            this.btnSalvar.Location = new System.Drawing.Point(25, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 80);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            // 
            // lblLugaresInseridos
            // 
            this.lblLugaresInseridos.AutoSize = true;
            this.lblLugaresInseridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugaresInseridos.Location = new System.Drawing.Point(51, 148);
            this.lblLugaresInseridos.Name = "lblLugaresInseridos";
            this.lblLugaresInseridos.Size = new System.Drawing.Size(36, 39);
            this.lblLugaresInseridos.TabIndex = 2;
            this.lblLugaresInseridos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lugares inseridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lugares por inserir";
            // 
            // lblPorInserir
            // 
            this.lblPorInserir.AutoSize = true;
            this.lblPorInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorInserir.Location = new System.Drawing.Point(51, 229);
            this.lblPorInserir.Name = "lblPorInserir";
            this.lblPorInserir.Size = new System.Drawing.Size(36, 39);
            this.lblPorInserir.TabIndex = 4;
            this.lblPorInserir.Text = "0";
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel);
            this.Name = "Estacionamento";
            this.Text = "pa";
            this.Load += new System.EventHandler(this.Estacionamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Lugar;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label lblLugaresInseridos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorInserir;
        private System.Windows.Forms.Label label1;
    }
}