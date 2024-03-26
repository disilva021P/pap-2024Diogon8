namespace Gestao_Admin
{
    partial class Cofiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cofiguracoes));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaFormSemBorda = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.rdPago = new Guna.UI2.WinForms.Guna2TileButton();
            this.rdNaoPago = new Guna.UI2.WinForms.Guna2TileButton();
            this.rdLugaresMarcados = new Guna.UI2.WinForms.Guna2TileButton();
            this.rdNaoLugaresMarcados = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblNaoPago = new System.Windows.Forms.Label();
            this.lblLMarcados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnConf = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaFormSemBorda
            // 
            this.gunaFormSemBorda.AnimateWindow = true;
            this.gunaFormSemBorda.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.gunaFormSemBorda.ContainerControl = this;
            this.gunaFormSemBorda.DockIndicatorTransparencyValue = 0.6D;
            this.gunaFormSemBorda.TransparentWhileDrag = true;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(105, 32);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(193, 39);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AllowDrop = true;
            this.lblDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhes.Location = new System.Drawing.Point(33, 71);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(336, 107);
            this.lblDetalhes.TabIndex = 1;
            this.lblDetalhes.Text = "Bem vindo á sua nova gestão de parque de estacionamento! Espero que goste do prog" +
    "rama e boas gestões!\r\nAntes de começar insira estas configurações\r\n";
            this.lblDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdPago
            // 
            this.rdPago.Animated = true;
            this.rdPago.BackColor = System.Drawing.Color.Transparent;
            this.rdPago.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdPago.FillColor = System.Drawing.Color.Transparent;
            this.rdPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdPago.ForeColor = System.Drawing.Color.White;
            this.rdPago.Image = ((System.Drawing.Image)(resources.GetObject("rdPago.Image")));
            this.rdPago.ImageSize = new System.Drawing.Size(100, 100);
            this.rdPago.IndicateFocus = true;
            this.rdPago.Location = new System.Drawing.Point(12, 219);
            this.rdPago.Name = "rdPago";
            this.rdPago.Size = new System.Drawing.Size(180, 159);
            this.rdPago.TabIndex = 5;
            this.rdPago.UseTransparentBackground = true;
            this.rdPago.Click += new System.EventHandler(this.rdPago_Click);
            // 
            // rdNaoPago
            // 
            this.rdNaoPago.Animated = true;
            this.rdNaoPago.BackColor = System.Drawing.Color.Transparent;
            this.rdNaoPago.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdNaoPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdNaoPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdNaoPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdNaoPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdNaoPago.FillColor = System.Drawing.Color.Transparent;
            this.rdNaoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdNaoPago.ForeColor = System.Drawing.Color.White;
            this.rdNaoPago.Image = ((System.Drawing.Image)(resources.GetObject("rdNaoPago.Image")));
            this.rdNaoPago.ImageSize = new System.Drawing.Size(100, 100);
            this.rdNaoPago.IndicateFocus = true;
            this.rdNaoPago.Location = new System.Drawing.Point(211, 219);
            this.rdNaoPago.Name = "rdNaoPago";
            this.rdNaoPago.Size = new System.Drawing.Size(180, 159);
            this.rdNaoPago.TabIndex = 6;
            this.rdNaoPago.UseTransparentBackground = true;
            this.rdNaoPago.Click += new System.EventHandler(this.rdNaoPago_Click);
            // 
            // rdLugaresMarcados
            // 
            this.rdLugaresMarcados.Animated = true;
            this.rdLugaresMarcados.BackColor = System.Drawing.Color.Transparent;
            this.rdLugaresMarcados.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdLugaresMarcados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdLugaresMarcados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdLugaresMarcados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdLugaresMarcados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdLugaresMarcados.FillColor = System.Drawing.Color.Transparent;
            this.rdLugaresMarcados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdLugaresMarcados.ForeColor = System.Drawing.Color.White;
            this.rdLugaresMarcados.Image = ((System.Drawing.Image)(resources.GetObject("rdLugaresMarcados.Image")));
            this.rdLugaresMarcados.ImageSize = new System.Drawing.Size(100, 100);
            this.rdLugaresMarcados.IndicateFocus = true;
            this.rdLugaresMarcados.Location = new System.Drawing.Point(12, 484);
            this.rdLugaresMarcados.Name = "rdLugaresMarcados";
            this.rdLugaresMarcados.Size = new System.Drawing.Size(180, 159);
            this.rdLugaresMarcados.TabIndex = 7;
            this.rdLugaresMarcados.UseTransparentBackground = true;
            this.rdLugaresMarcados.Click += new System.EventHandler(this.rdLugaresMarcados_Click);
            // 
            // rdNaoLugaresMarcados
            // 
            this.rdNaoLugaresMarcados.Animated = true;
            this.rdNaoLugaresMarcados.BackColor = System.Drawing.Color.Transparent;
            this.rdNaoLugaresMarcados.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdNaoLugaresMarcados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdNaoLugaresMarcados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdNaoLugaresMarcados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdNaoLugaresMarcados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdNaoLugaresMarcados.FillColor = System.Drawing.Color.Transparent;
            this.rdNaoLugaresMarcados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdNaoLugaresMarcados.ForeColor = System.Drawing.Color.White;
            this.rdNaoLugaresMarcados.Image = ((System.Drawing.Image)(resources.GetObject("rdNaoLugaresMarcados.Image")));
            this.rdNaoLugaresMarcados.ImageSize = new System.Drawing.Size(100, 100);
            this.rdNaoLugaresMarcados.IndicateFocus = true;
            this.rdNaoLugaresMarcados.Location = new System.Drawing.Point(211, 484);
            this.rdNaoLugaresMarcados.Name = "rdNaoLugaresMarcados";
            this.rdNaoLugaresMarcados.Size = new System.Drawing.Size(180, 159);
            this.rdNaoLugaresMarcados.TabIndex = 8;
            this.rdNaoLugaresMarcados.UseTransparentBackground = true;
            this.rdNaoLugaresMarcados.Click += new System.EventHandler(this.rdNaoLugaresMarcados_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(62, 381);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(97, 39);
            this.lblPago.TabIndex = 9;
            this.lblPago.Text = "Pago";
            // 
            // lblNaoPago
            // 
            this.lblNaoPago.AutoSize = true;
            this.lblNaoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoPago.Location = new System.Drawing.Point(222, 381);
            this.lblNaoPago.Name = "lblNaoPago";
            this.lblNaoPago.Size = new System.Drawing.Size(169, 39);
            this.lblNaoPago.TabIndex = 10;
            this.lblNaoPago.Text = "Não Pago";
            // 
            // lblLMarcados
            // 
            this.lblLMarcados.AllowDrop = true;
            this.lblLMarcados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMarcados.Location = new System.Drawing.Point(5, 646);
            this.lblLMarcados.Name = "lblLMarcados";
            this.lblLMarcados.Size = new System.Drawing.Size(207, 80);
            this.lblLMarcados.TabIndex = 11;
            this.lblLMarcados.Text = "Associado";
            this.lblLMarcados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 78);
            this.label1.TabIndex = 12;
            this.label1.Text = "Não Associados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(128, 442);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(147, 39);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Lugares";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(346, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // btnConf
            // 
            this.btnConf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Location = new System.Drawing.Point(12, 749);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(379, 57);
            this.btnConf.TabIndex = 15;
            this.btnConf.Text = "Adicionar Configurações";
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // Cofiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 818);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLMarcados);
            this.Controls.Add(this.lblNaoPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.rdNaoLugaresMarcados);
            this.Controls.Add(this.rdLugaresMarcados);
            this.Controls.Add(this.rdNaoPago);
            this.Controls.Add(this.rdPago);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.lblBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(403, 450);
            this.Name = "Cofiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cofiguracoes";
            this.Load += new System.EventHandler(this.Cofiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm gunaFormSemBorda;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Label lblBemVindo;
        private Guna.UI2.WinForms.Guna2TileButton rdNaoPago;
        private Guna.UI2.WinForms.Guna2TileButton rdPago;
        private System.Windows.Forms.Label lblNaoPago;
        private System.Windows.Forms.Label lblPago;
        private Guna.UI2.WinForms.Guna2TileButton rdNaoLugaresMarcados;
        private Guna.UI2.WinForms.Guna2TileButton rdLugaresMarcados;
        private System.Windows.Forms.Label lblLMarcados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnConf;
    }
}