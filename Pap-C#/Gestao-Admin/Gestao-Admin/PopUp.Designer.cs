﻿namespace Gestao_Admin
{
    partial class PopUp
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.mensagem = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.mensagem);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(329, 247);
            this.guna2Panel1.TabIndex = 0;
            // 
            // mensagem
            // 
            this.mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem.Location = new System.Drawing.Point(12, 9);
            this.mensagem.Name = "mensagem";
            this.mensagem.Size = new System.Drawing.Size(305, 165);
            this.mensagem.TabIndex = 1;
            this.mensagem.Text = "label1";
            this.mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mensagem.Click += new System.EventHandler(this.mensagem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btn2);
            this.guna2Panel2.Controls.Add(this.btn1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 177);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(305, 54);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.Animated = true;
            this.btn2.BorderRadius = 20;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(155, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 54);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Adicionar";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Animated = true;
            this.btn1.BorderRadius = 20;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 54);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Ok";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 247);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUp";
            this.TopMost = true;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private System.Windows.Forms.Label mensagem;
    }
}