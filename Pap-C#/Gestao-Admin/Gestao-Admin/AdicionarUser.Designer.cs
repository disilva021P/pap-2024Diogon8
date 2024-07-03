namespace Gestao_Admin
{
    partial class AdicionarUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImagemAdicionar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCarregarImagem = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNif = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSobreNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataNascimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPlanoUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dataInscricao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPlano = new System.Windows.Forms.Label();
            this.cbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMorada = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCarros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemAdicionar
            // 
            this.ImagemAdicionar.BorderRadius = 25;
            this.ImagemAdicionar.ImageRotate = 0F;
            this.ImagemAdicionar.Location = new System.Drawing.Point(55, 54);
            this.ImagemAdicionar.Name = "ImagemAdicionar";
            this.ImagemAdicionar.Size = new System.Drawing.Size(200, 200);
            this.ImagemAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemAdicionar.TabIndex = 0;
            this.ImagemAdicionar.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCarregarImagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCarregarImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCarregarImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCarregarImagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCarregarImagem.ForeColor = System.Drawing.Color.White;
            this.btnCarregarImagem.Location = new System.Drawing.Point(261, 142);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(180, 45);
            this.btnCarregarImagem.TabIndex = 1;
            this.btnCarregarImagem.Text = "Carregar imagem";
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(180, 45);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "<";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(1054, 754);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 45);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adiconar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(846, 754);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNif
            // 
            this.txtNif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNif.DefaultText = "";
            this.txtNif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNif.Location = new System.Drawing.Point(212, 447);
            this.txtNif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.PasswordChar = '\0';
            this.txtNif.PlaceholderText = "";
            this.txtNif.SelectedText = "";
            this.txtNif.Size = new System.Drawing.Size(229, 48);
            this.txtNif.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(212, 279);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(229, 48);
            this.txtNome.TabIndex = 6;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSobreNome.DefaultText = "";
            this.txtSobreNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSobreNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSobreNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSobreNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSobreNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSobreNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSobreNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSobreNome.Location = new System.Drawing.Point(212, 335);
            this.txtSobreNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.PasswordChar = '\0';
            this.txtSobreNome.PlaceholderText = "";
            this.txtSobreNome.SelectedText = "";
            this.txtSobreNome.Size = new System.Drawing.Size(229, 48);
            this.txtSobreNome.TabIndex = 7;
            this.txtSobreNome.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Location = new System.Drawing.Point(212, 391);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.SelectedText = "";
            this.txtNumero.Size = new System.Drawing.Size(229, 48);
            this.txtNumero.TabIndex = 8;
            // 
            // dataNascimento
            // 
            this.dataNascimento.Checked = true;
            this.dataNascimento.FillColor = System.Drawing.Color.White;
            this.dataNascimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataNascimento.Location = new System.Drawing.Point(743, 488);
            this.dataNascimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataNascimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(229, 48);
            this.dataNascimento.TabIndex = 9;
            this.dataNascimento.Value = new System.DateTime(2024, 2, 15, 12, 37, 50, 240);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(212, 503);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(229, 48);
            this.txtEmail.TabIndex = 10;
            // 
            // cbPlanoUser
            // 
            this.cbPlanoUser.BackColor = System.Drawing.Color.Transparent;
            this.cbPlanoUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlanoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanoUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPlanoUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPlanoUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPlanoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPlanoUser.ItemHeight = 30;
            this.cbPlanoUser.Location = new System.Drawing.Point(743, 279);
            this.cbPlanoUser.Name = "cbPlanoUser";
            this.cbPlanoUser.Size = new System.Drawing.Size(229, 36);
            this.cbPlanoUser.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 291);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(128, 355);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(78, 16);
            this.lblSobrenome.TabIndex = 16;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(131, 406);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 17;
            this.lblNum.Text = "Número";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(131, 466);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(23, 16);
            this.lblNif.TabIndex = 18;
            this.lblNif.Text = "Nif";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(131, 522);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // dataInscricao
            // 
            this.dataInscricao.Checked = true;
            this.dataInscricao.FillColor = System.Drawing.Color.White;
            this.dataInscricao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataInscricao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataInscricao.Location = new System.Drawing.Point(743, 413);
            this.dataInscricao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataInscricao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataInscricao.Name = "dataInscricao";
            this.dataInscricao.Size = new System.Drawing.Size(229, 48);
            this.dataInscricao.TabIndex = 20;
            this.dataInscricao.Value = new System.DateTime(2024, 2, 15, 12, 37, 50, 240);
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(695, 290);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(42, 16);
            this.lblPlano.TabIndex = 21;
            this.lblPlano.Text = "Plano";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEstado.ItemHeight = 30;
            this.cbEstado.Location = new System.Drawing.Point(743, 335);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(229, 36);
            this.cbEstado.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // txtMorada
            // 
            this.txtMorada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMorada.DefaultText = "";
            this.txtMorada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMorada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMorada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMorada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMorada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMorada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMorada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMorada.Location = new System.Drawing.Point(212, 559);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.PasswordChar = '\0';
            this.txtMorada.PlaceholderText = "";
            this.txtMorada.SelectedText = "";
            this.txtMorada.Size = new System.Drawing.Size(229, 48);
            this.txtMorada.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Comentarios";
            // 
            // txtComentario
            // 
            this.txtComentario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComentario.DefaultText = "";
            this.txtComentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComentario.Location = new System.Drawing.Point(217, 615);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.PlaceholderText = "";
            this.txtComentario.SelectedText = "";
            this.txtComentario.Size = new System.Drawing.Size(229, 48);
            this.txtComentario.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Data de Inscrição";
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCarros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Matricula,
            this.Marca});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCarros.Location = new System.Drawing.Point(698, 542);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.RowHeadersVisible = false;
            this.dgvCarros.RowHeadersWidth = 51;
            this.dgvCarros.RowTemplate.Height = 24;
            this.dgvCarros.Size = new System.Drawing.Size(274, 150);
            this.dgvCarros.TabIndex = 29;
            this.dgvCarros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCarros.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCarros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCarros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCarros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCarros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCarros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCarros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCarros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCarros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvCarros.ThemeStyle.ReadOnly = false;
            this.dgvCarros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCarros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCarros.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCarros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCarros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCarros.Visible = false;
            this.dgvCarros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCarros_RowsAdded);
            this.dgvCarros.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCarros_RowsRemoved);
            this.dgvCarros.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCarros_UserDeletingRow);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            // 
            // AdicionarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlano);
            this.Controls.Add(this.dataInscricao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbPlanoUser);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.ImagemAdicionar);
            this.Name = "AdicionarUser";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.AdicionarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ImagemAdicionar;
        private Guna.UI2.WinForms.Guna2Button btnCarregarImagem;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtNif;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtSobreNome;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataNascimento;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2ComboBox cbPlanoUser;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataInscricao;
        private System.Windows.Forms.Label lblPlano;
        private Guna.UI2.WinForms.Guna2ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMorada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}
