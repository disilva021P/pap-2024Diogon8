namespace Gestao_Admin
{
    partial class Pagamentos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.Charts.WinForms.ChartFont chartFont25 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont26 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont27 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont28 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid10 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick10 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont29 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid11 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick11 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont30 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid12 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel4 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont31 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick12 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont32 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLimparDefinicoes = new Guna.UI2.WinForms.Guna2Button();
            this.cbAno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdicionarUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoverUsesr = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelGlobal = new Guna.UI2.WinForms.Guna2Panel();
            this.scrollbar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panelUsers = new Guna.UI2.WinForms.Guna2Panel();
            this.checkE = new System.Windows.Forms.CheckBox();
            this.checkN = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.gunaBarDataset = new Guna.Charts.WinForms.GunaBarDataset();
            this.dgvPagamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConfiguracoes.SuspendLayout();
            this.panelGlobal.SuspendLayout();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panelConfiguracoes.BorderRadius = 10;
            this.panelConfiguracoes.Controls.Add(this.btnLimparDefinicoes);
            this.panelConfiguracoes.Controls.Add(this.cbAno);
            this.panelConfiguracoes.Controls.Add(this.cbMes);
            this.panelConfiguracoes.Controls.Add(this.btnAdicionarUser);
            this.panelConfiguracoes.Controls.Add(this.btnRemoverUsesr);
            this.panelConfiguracoes.Controls.Add(this.btnEditarUser);
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1925, 105);
            this.panelConfiguracoes.TabIndex = 3;
            // 
            // btnLimparDefinicoes
            // 
            this.btnLimparDefinicoes.BorderRadius = 25;
            this.btnLimparDefinicoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparDefinicoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparDefinicoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimparDefinicoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimparDefinicoes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimparDefinicoes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimparDefinicoes.ForeColor = System.Drawing.Color.White;
            this.btnLimparDefinicoes.Location = new System.Drawing.Point(677, 21);
            this.btnLimparDefinicoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparDefinicoes.Name = "btnLimparDefinicoes";
            this.btnLimparDefinicoes.Size = new System.Drawing.Size(204, 60);
            this.btnLimparDefinicoes.TabIndex = 3;
            this.btnLimparDefinicoes.Text = "Limpar";
            this.btnLimparDefinicoes.Click += new System.EventHandler(this.btnLimparDefinicoes_Click);
            // 
            // cbAno
            // 
            this.cbAno.BackColor = System.Drawing.Color.Transparent;
            this.cbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAno.ItemHeight = 30;
            this.cbAno.Items.AddRange(new object[] {
            "",
            "2023",
            "2024",
            "2025"});
            this.cbAno.Location = new System.Drawing.Point(476, 34);
            this.cbAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(195, 36);
            this.cbAno.TabIndex = 1;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.Transparent;
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMes.ItemHeight = 30;
            this.cbMes.Items.AddRange(new object[] {
            "",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(275, 34);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(195, 36);
            this.cbMes.TabIndex = 0;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // btnAdicionarUser
            // 
            this.btnAdicionarUser.BorderRadius = 25;
            this.btnAdicionarUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionarUser.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarUser.Location = new System.Drawing.Point(1004, 21);
            this.btnAdicionarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarUser.Name = "btnAdicionarUser";
            this.btnAdicionarUser.Size = new System.Drawing.Size(204, 60);
            this.btnAdicionarUser.TabIndex = 2;
            this.btnAdicionarUser.Text = "Adicionar";
            // 
            // btnRemoverUsesr
            // 
            this.btnRemoverUsesr.BorderRadius = 25;
            this.btnRemoverUsesr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoverUsesr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoverUsesr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoverUsesr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoverUsesr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnRemoverUsesr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoverUsesr.ForeColor = System.Drawing.Color.White;
            this.btnRemoverUsesr.Location = new System.Drawing.Point(1256, 21);
            this.btnRemoverUsesr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverUsesr.Name = "btnRemoverUsesr";
            this.btnRemoverUsesr.Size = new System.Drawing.Size(204, 60);
            this.btnRemoverUsesr.TabIndex = 1;
            this.btnRemoverUsesr.Text = "Remover";
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.BorderRadius = 25;
            this.btnEditarUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarUser.ForeColor = System.Drawing.Color.White;
            this.btnEditarUser.Location = new System.Drawing.Point(1493, 21);
            this.btnEditarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(204, 60);
            this.btnEditarUser.TabIndex = 0;
            this.btnEditarUser.Text = "Editar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderRadius = 25;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.Location = new System.Drawing.Point(667, 405);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderText = "Nif ou Nome";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(517, 60);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // panelGlobal
            // 
            this.panelGlobal.Controls.Add(this.panelUsers);
            this.panelGlobal.Controls.Add(this.checkE);
            this.panelGlobal.Controls.Add(this.txtPesquisa);
            this.panelGlobal.Controls.Add(this.checkN);
            this.panelGlobal.Controls.Add(this.chart1);
            this.panelGlobal.Controls.Add(this.gunaChart1);
            this.panelGlobal.Controls.Add(this.dgvPagamentos);
            this.panelGlobal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGlobal.Location = new System.Drawing.Point(0, 102);
            this.panelGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGlobal.Name = "panelGlobal";
            this.panelGlobal.Size = new System.Drawing.Size(1925, 911);
            this.panelGlobal.TabIndex = 4;
            // 
            // scrollbar1
            // 
            this.scrollbar1.AutoRoundedCorners = true;
            this.scrollbar1.BindingContainer = this.flowLayoutPanel1;
            this.scrollbar1.BorderRadius = 9;
            this.scrollbar1.InUpdate = false;
            this.scrollbar1.LargeChange = 409;
            this.scrollbar1.Location = new System.Drawing.Point(1163, 0);
            this.scrollbar1.Maximum = 414;
            this.scrollbar1.Name = "scrollbar1";
            this.scrollbar1.ScrollbarSize = 21;
            this.scrollbar1.Size = new System.Drawing.Size(21, 412);
            this.scrollbar1.SmallChange = 5;
            this.scrollbar1.TabIndex = 1;
            this.scrollbar1.ThumbSize = 40F;
            this.scrollbar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // panelUsers
            // 
            this.panelUsers.AutoScroll = true;
            this.panelUsers.Controls.Add(this.scrollbar1);
            this.panelUsers.Controls.Add(this.flowLayoutPanel1);
            this.panelUsers.Location = new System.Drawing.Point(667, 474);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1205, 409);
            this.panelUsers.TabIndex = 5;
            this.panelUsers.Click += new System.EventHandler(this.panelUsers_Click);
            // 
            // checkE
            // 
            this.checkE.AutoSize = true;
            this.checkE.Checked = true;
            this.checkE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkE.Location = new System.Drawing.Point(1468, 63);
            this.checkE.Name = "checkE";
            this.checkE.Size = new System.Drawing.Size(64, 20);
            this.checkE.TabIndex = 4;
            this.checkE.Text = "Euros";
            this.checkE.UseVisualStyleBackColor = true;
            this.checkE.CheckedChanged += new System.EventHandler(this.checkE_CheckedChanged);
            // 
            // checkN
            // 
            this.checkN.AutoSize = true;
            this.checkN.Location = new System.Drawing.Point(1468, 37);
            this.checkN.Name = "checkN";
            this.checkN.Size = new System.Drawing.Size(84, 20);
            this.checkN.TabIndex = 3;
            this.checkN.Text = "Números";
            this.checkN.UseVisualStyleBackColor = true;
            this.checkN.CheckedChanged += new System.EventHandler(this.checkN_CheckedChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(1115, 37);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(345, 318);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Pagamentos";
            // 
            // gunaChart1
            // 
            this.gunaChart1.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaBarDataset});
            chartFont25.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont25;
            this.gunaChart1.Location = new System.Drawing.Point(667, 37);
            this.gunaChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(419, 318);
            this.gunaChart1.TabIndex = 1;
            chartFont26.FontName = "Arial";
            chartFont26.Size = 12;
            chartFont26.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont26;
            chartFont27.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont27;
            chartFont28.FontName = "Arial";
            chartFont28.Size = 9;
            chartFont28.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont28;
            this.gunaChart1.XAxes.GridLines = grid10;
            chartFont29.FontName = "Arial";
            tick10.Font = chartFont29;
            this.gunaChart1.XAxes.Ticks = tick10;
            this.gunaChart1.YAxes.GridLines = grid11;
            chartFont30.FontName = "Arial";
            tick11.Font = chartFont30;
            this.gunaChart1.YAxes.Ticks = tick11;
            this.gunaChart1.ZAxes.GridLines = grid12;
            chartFont31.FontName = "Arial";
            pointLabel4.Font = chartFont31;
            this.gunaChart1.ZAxes.PointLabels = pointLabel4;
            chartFont32.FontName = "Arial";
            tick12.Font = chartFont32;
            this.gunaChart1.ZAxes.Ticks = tick12;
            // 
            // gunaBarDataset
            // 
            this.gunaBarDataset.Label = "Bar1";
            this.gunaBarDataset.TargetChart = this.gunaChart1;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AllowUserToResizeColumns = false;
            this.dgvPagamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPagamentos.ColumnHeadersHeight = 34;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagamento,
            this.TituloPagamento,
            this.datapagamento,
            this.ValorPagamento,
            this.estado,
            this.Nif});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamentos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPagamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.Location = new System.Drawing.Point(3, 37);
            this.dgvPagamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.RowHeadersVisible = false;
            this.dgvPagamentos.RowHeadersWidth = 51;
            this.dgvPagamentos.RowTemplate.Height = 24;
            this.dgvPagamentos.Size = new System.Drawing.Size(658, 318);
            this.dgvPagamentos.TabIndex = 0;
            this.dgvPagamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagamentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPagamentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPagamentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPagamentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPagamentos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagamentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPagamentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagamentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPagamentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPagamentos.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvPagamentos.ThemeStyle.ReadOnly = false;
            this.dgvPagamentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagamentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPagamentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagamentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPagamentos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPagamentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // IdPagamento
            // 
            this.IdPagamento.HeaderText = "Id";
            this.IdPagamento.MinimumWidth = 6;
            this.IdPagamento.Name = "IdPagamento";
            // 
            // TituloPagamento
            // 
            this.TituloPagamento.HeaderText = "Titulo";
            this.TituloPagamento.MinimumWidth = 6;
            this.TituloPagamento.Name = "TituloPagamento";
            // 
            // datapagamento
            // 
            this.datapagamento.HeaderText = "Data Receção";
            this.datapagamento.MinimumWidth = 6;
            this.datapagamento.Name = "datapagamento";
            // 
            // ValorPagamento
            // 
            this.ValorPagamento.HeaderText = "Valor";
            this.ValorPagamento.MinimumWidth = 6;
            this.ValorPagamento.Name = "ValorPagamento";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            // 
            // Nif
            // 
            this.Nif.HeaderText = "Nif";
            this.Nif.MinimumWidth = 6;
            this.Nif.Name = "Nif";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 412);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGlobal);
            this.Controls.Add(this.panelConfiguracoes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagamentos";
            this.Size = new System.Drawing.Size(1925, 1013);
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            this.panelConfiguracoes.ResumeLayout(false);
            this.panelGlobal.ResumeLayout(false);
            this.panelGlobal.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarUser;
        private Guna.UI2.WinForms.Guna2Button btnRemoverUsesr;
        private Guna.UI2.WinForms.Guna2Button btnEditarUser;
        private Guna.UI2.WinForms.Guna2Panel panelGlobal;
        private Guna.UI2.WinForms.Guna2ComboBox cbAno;
        private Guna.UI2.WinForms.Guna2ComboBox cbMes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPagamentos;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nif;
        private System.Windows.Forms.CheckBox checkE;
        private System.Windows.Forms.CheckBox checkN;
        private Guna.UI2.WinForms.Guna2Button btnLimparDefinicoes;
        private Guna.UI2.WinForms.Guna2Panel panelUsers;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
