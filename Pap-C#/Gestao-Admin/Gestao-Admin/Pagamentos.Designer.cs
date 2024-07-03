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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelConfiguracoes = new Guna.UI2.WinForms.Guna2Panel();
            this.LimparConfig = new Guna.UI2.WinForms.Guna2Button();
            this.cbAno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelGlobal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUsers = new Guna.UI2.WinForms.Guna2Panel();
            this.scrollbar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panelConfiguracoes.SuspendLayout();
            this.panelGlobal.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panelConfiguracoes.BorderRadius = 10;
            this.panelConfiguracoes.Controls.Add(this.LimparConfig);
            this.panelConfiguracoes.Controls.Add(this.cbAno);
            this.panelConfiguracoes.Controls.Add(this.cbMes);
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1925, 105);
            this.panelConfiguracoes.TabIndex = 3;
            // 
            // LimparConfig
            // 
            this.LimparConfig.BorderRadius = 25;
            this.LimparConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LimparConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LimparConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LimparConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LimparConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LimparConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LimparConfig.ForeColor = System.Drawing.Color.White;
            this.LimparConfig.Location = new System.Drawing.Point(405, 21);
            this.LimparConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LimparConfig.Name = "LimparConfig";
            this.LimparConfig.Size = new System.Drawing.Size(204, 60);
            this.LimparConfig.TabIndex = 3;
            this.LimparConfig.Text = "Limpar";
            this.LimparConfig.Click += new System.EventHandler(this.btnLimparDefinicoes_Click);
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
            this.cbAno.Location = new System.Drawing.Point(204, 34);
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
            this.cbMes.Location = new System.Drawing.Point(3, 34);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(195, 36);
            this.cbMes.TabIndex = 0;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
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
            this.panelGlobal.Controls.Add(this.guna2Panel1);
            this.panelGlobal.Controls.Add(this.panelTotal);
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
            this.panelGlobal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGlobal_Paint_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblMedia);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(369, 405);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(282, 201);
            this.guna2Panel1.TabIndex = 7;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(104, 81);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(74, 39);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "10€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Media";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Transparent;
            this.panelTotal.BorderColor = System.Drawing.Color.Black;
            this.panelTotal.BorderRadius = 50;
            this.panelTotal.BorderThickness = 1;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.label1);
            this.panelTotal.FillColor = System.Drawing.Color.White;
            this.panelTotal.Location = new System.Drawing.Point(18, 405);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(282, 201);
            this.panelTotal.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(104, 81);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 39);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "10€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // panelUsers
            // 
            this.panelUsers.AutoScroll = true;
            this.panelUsers.Controls.Add(this.scrollbar1);
            this.panelUsers.Controls.Add(this.flowLayoutPanel1);
            this.panelUsers.Location = new System.Drawing.Point(667, 474);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1142, 409);
            this.panelUsers.TabIndex = 5;
            this.panelUsers.Click += new System.EventHandler(this.panelUsers_Click);
            // 
            // scrollbar1
            // 
            this.scrollbar1.AutoRoundedCorners = true;
            this.scrollbar1.BindingContainer = this.flowLayoutPanel1;
            this.scrollbar1.BorderRadius = 9;
            this.scrollbar1.InUpdate = false;
            this.scrollbar1.LargeChange = 10;
            this.scrollbar1.Location = new System.Drawing.Point(1121, 0);
            this.scrollbar1.Name = "scrollbar1";
            this.scrollbar1.ScrollbarSize = 21;
            this.scrollbar1.Size = new System.Drawing.Size(21, 409);
            this.scrollbar1.TabIndex = 1;
            this.scrollbar1.ThumbSize = 1F;
            this.scrollbar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.scrollbar1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1142, 409);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1115, 37);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(345, 318);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Pagamentos";
            // 
            // gunaChart1
            // 
            this.gunaChart1.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaBarDataset});
            chartFont1.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont1;
            this.gunaChart1.Location = new System.Drawing.Point(667, 37);
            this.gunaChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(419, 318);
            this.gunaChart1.TabIndex = 1;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont4;
            this.gunaChart1.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.gunaChart1.XAxes.Ticks = tick1;
            this.gunaChart1.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.gunaChart1.YAxes.Ticks = tick2;
            this.gunaChart1.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.gunaChart1.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.gunaChart1.ZAxes.Ticks = tick3;
            // 
            // gunaBarDataset
            // 
            this.gunaBarDataset.Label = "Bar1";
            this.gunaBarDataset.TargetChart = this.gunaChart1;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToResizeColumns = false;
            this.dgvPagamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagamentos.ColumnHeadersHeight = 34;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagamento,
            this.TituloPagamento,
            this.datapagamento,
            this.ValorPagamento,
            this.estado,
            this.Nif});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.Location = new System.Drawing.Point(3, 37);
            this.dgvPagamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagamentos.MultiSelect = false;
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
            this.dgvPagamentos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPagamentos_CellBeginEdit);
            this.dgvPagamentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellValueChanged);
            this.dgvPagamentos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPagamentos_RowsRemoved);
            this.dgvPagamentos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPagamentos_UserDeletingRow);
            // 
            // IdPagamento
            // 
            this.IdPagamento.HeaderText = "Id";
            this.IdPagamento.MinimumWidth = 6;
            this.IdPagamento.Name = "IdPagamento";
            this.IdPagamento.ReadOnly = true;
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
            this.Nif.ReadOnly = true;
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelConfiguracoes;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Panel panelGlobal;
        private Guna.UI2.WinForms.Guna2ComboBox cbAno;
        private Guna.UI2.WinForms.Guna2ComboBox cbMes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPagamentos;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkE;
        private System.Windows.Forms.CheckBox checkN;
        private Guna.UI2.WinForms.Guna2Panel panelUsers;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nif;
        private Guna.UI2.WinForms.Guna2Panel panelTotal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblMedia;
        private Guna.UI2.WinForms.Guna2Button LimparConfig;
    }
}
