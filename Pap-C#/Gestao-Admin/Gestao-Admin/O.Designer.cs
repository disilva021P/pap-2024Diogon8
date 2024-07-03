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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOcorrencias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOcorrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizarEstado = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinalizar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvAcao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nifAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTomarAcao = new Guna.UI2.WinForms.Guna2Button();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcao)).BeginInit();
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
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnFinalizar);
            this.guna2Panel1.Controls.Add(this.btnAtualizarEstado);
            this.guna2Panel1.Controls.Add(this.dgvOcorrencias);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 105);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1925, 908);
            this.guna2Panel1.TabIndex = 4;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AllowUserToAddRows = false;
            this.dgvOcorrencias.AllowUserToDeleteRows = false;
            this.dgvOcorrencias.AllowUserToResizeColumns = false;
            this.dgvOcorrencias.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvOcorrencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOcorrencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOcorrencias.ColumnHeadersHeight = 34;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nif,
            this.motivo,
            this.descricao,
            this.dataOcorrencia,
            this.matricula,
            this.estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOcorrencias.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOcorrencias.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOcorrencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOcorrencias.Location = new System.Drawing.Point(0, 0);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.ReadOnly = true;
            this.dgvOcorrencias.RowHeadersVisible = false;
            this.dgvOcorrencias.RowHeadersWidth = 51;
            this.dgvOcorrencias.RowTemplate.Height = 24;
            this.dgvOcorrencias.Size = new System.Drawing.Size(917, 908);
            this.dgvOcorrencias.TabIndex = 4;
            this.dgvOcorrencias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOcorrencias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOcorrencias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOcorrencias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOcorrencias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOcorrencias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOcorrencias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOcorrencias.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvOcorrencias.ThemeStyle.ReadOnly = true;
            this.dgvOcorrencias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOcorrencias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOcorrencias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOcorrencias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOcorrencias.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOcorrencias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOcorrencias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOcorrencias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOcorrencias_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nif
            // 
            this.nif.HeaderText = "Nif";
            this.nif.MinimumWidth = 6;
            this.nif.Name = "nif";
            this.nif.ReadOnly = true;
            // 
            // motivo
            // 
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // dataOcorrencia
            // 
            this.dataOcorrencia.HeaderText = "Data da Ocorrência";
            this.dataOcorrencia.MinimumWidth = 6;
            this.dataOcorrencia.Name = "dataOcorrencia";
            this.dataOcorrencia.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.MinimumWidth = 6;
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnAtualizarEstado
            // 
            this.btnAtualizarEstado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizarEstado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizarEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtualizarEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtualizarEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizarEstado.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarEstado.Location = new System.Drawing.Point(923, 35);
            this.btnAtualizarEstado.Name = "btnAtualizarEstado";
            this.btnAtualizarEstado.Size = new System.Drawing.Size(235, 45);
            this.btnAtualizarEstado.TabIndex = 5;
            this.btnAtualizarEstado.Text = "Atualizar Estado da Ocorrência";
            this.btnAtualizarEstado.Click += new System.EventHandler(this.btnAtualizarEstado_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(923, 86);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(235, 45);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Tomar Ações";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtValor);
            this.guna2Panel2.Controls.Add(this.btnTomarAcao);
            this.guna2Panel2.Controls.Add(this.dgvAcao);
            this.guna2Panel2.Location = new System.Drawing.Point(923, 137);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(235, 249);
            this.guna2Panel2.TabIndex = 7;
            this.guna2Panel2.Visible = false;
            // 
            // dgvAcao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAcao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nifAcao,
            this.nomeAcao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAcao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAcao.Location = new System.Drawing.Point(0, 0);
            this.dgvAcao.Name = "dgvAcao";
            this.dgvAcao.RowHeadersVisible = false;
            this.dgvAcao.RowHeadersWidth = 51;
            this.dgvAcao.RowTemplate.Height = 24;
            this.dgvAcao.Size = new System.Drawing.Size(235, 104);
            this.dgvAcao.TabIndex = 0;
            this.dgvAcao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAcao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAcao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAcao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAcao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAcao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAcao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAcao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAcao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAcao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAcao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAcao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcao.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvAcao.ThemeStyle.ReadOnly = false;
            this.dgvAcao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAcao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAcao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAcao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAcao.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAcao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAcao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nifAcao
            // 
            this.nifAcao.HeaderText = "Nif";
            this.nifAcao.MinimumWidth = 6;
            this.nifAcao.Name = "nifAcao";
            // 
            // nomeAcao
            // 
            this.nomeAcao.HeaderText = "Nome";
            this.nomeAcao.MinimumWidth = 6;
            this.nomeAcao.Name = "nomeAcao";
            // 
            // btnTomarAcao
            // 
            this.btnTomarAcao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTomarAcao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTomarAcao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTomarAcao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTomarAcao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTomarAcao.ForeColor = System.Drawing.Color.White;
            this.btnTomarAcao.Location = new System.Drawing.Point(4, 197);
            this.btnTomarAcao.Name = "btnTomarAcao";
            this.btnTomarAcao.Size = new System.Drawing.Size(228, 45);
            this.btnTomarAcao.TabIndex = 1;
            this.btnTomarAcao.Text = "Confirmar ação";
            this.btnTomarAcao.Click += new System.EventHandler(this.btnTomarAcao_Click);
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Location = new System.Drawing.Point(6, 142);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderText = "Valor";
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(226, 48);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelConfiguracoes);
            this.Name = "Ocorrencias";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.Ocorrencias_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOcorrencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOcorrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private Guna.UI2.WinForms.Guna2Button btnAtualizarEstado;
        private Guna.UI2.WinForms.Guna2Button btnFinalizar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnTomarAcao;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAcao;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
    }
}
