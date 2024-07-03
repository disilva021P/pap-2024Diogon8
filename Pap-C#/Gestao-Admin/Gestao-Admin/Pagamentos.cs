using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Guna.Charts.WinForms;
using MySql.Data.MySqlClient;

namespace Gestao_Admin
{
    public partial class Pagamentos : System.Windows.Forms.UserControl
    { 
        public int nifVisualizar = -1;
        
        int mes = -1;
        int ano = -1;
        bool n = false;
        List<Utilizador> users;
        bool edita = false;
        public Pagamentos(List<Utilizador> users)
        {
            InitializeComponent();
            this.users = users;
        }
        public Pagamentos(int nifVisualizarr, List<Utilizador> users)
        {
            InitializeComponent();
            this.nifVisualizar = nifVisualizarr;
            this.users = users;
        }
        private void Pagamentos_Load(object sender, EventArgs e)
        {
            if (nifVisualizar == -1)
            {
                gunaBarDataset.Label = "Pagamentos (em €)";
                gunaBarDataset.LegendBoxFillColor = Color.MediumSlateBlue;
                gunaBarDataset.FillColors.Add(Color.MediumSlateBlue);
                gunaBarDataset.FillColors.Add(Color.MediumPurple);
                gunaBarDataset.YFormat = "C";
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (Utilizador u in users)
            {
                User user = new User(u);
                flowLayoutPanel1.Controls.Add(user);
            }
            scrollbar1.Minimum = panelUsers.VerticalScroll.Minimum;
            scrollbar1.Maximum = panelUsers.VerticalScroll.Maximum;
            atualiza();
        }
        /// <summary>
        /// Esta função serve para carregar o data set e vai depender das definições escolhidas pelo admin
        /// (@mes,@ano,@user)-> se não quer utilizar algum deles basta marcar como -1:(-1,2024,-1) neste caso só vai carregar o ano
        /// </summary>
        public void PreencheBarDataset(int mes,int ano, int user)
        {
            gunaBarDataset.DataPoints.Clear();
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                string query = "SELECT SUM(valorPagamento) FROM pagamento WHERE MONTH(dataPagamentoRecebido) = @mes ";
                if (ano != -1)
                    query += " AND YEAR(dataPagamentoRecebido) = @ano";
                if (user != -1)
                    query += " AND nif = @nif";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                

                int index = 1;
                if (mes == -1)
                {
                    foreach (string label in meses)
                    {
                        cmd.Parameters.AddWithValue("@mes", index);
                        if (ano != -1)
                            cmd.Parameters.AddWithValue("@ano", ano);
                        if (user != -1)
                            cmd.Parameters.AddWithValue("@nif", user);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        double valor;
                        if (!dr.IsDBNull(0))
                        {
                            valor = dr.GetDouble(0);
                        }
                        else
                        {
                            valor = 0;
                        }
                        gunaBarDataset.DataPoints.Add(new LPoint()
                        {
                            Label = label,
                            Y = valor,

                        });
                        index++;
                        cmd.Parameters.Clear();
                        dr.Close();
                    }
                    conn.Close();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@mes", mes);
                    if (ano != -1)
                        cmd.Parameters.AddWithValue("@ano", ano);
                    if (user != -1)
                        cmd.Parameters.AddWithValue("@nif", user);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    double valor;
                    if (!dr.IsDBNull(0))
                    {
                        valor = dr.GetDouble(0);
                    }
                    else
                    {
                        valor = 0;
                    }
                    gunaBarDataset.DataPoints.Add(new LPoint()
                    {
                        Label = meses[mes-1],
                        Y = valor,

                    });
                }
                conn.Close();
            }
            
        }
        public void PreencherPieDataSet(int mes, int ano, int user,bool n)
        {
            chart1.Series.Clear();

            if (n)
            {
                using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
                {

                    conn.Open();
                    string queryPago = "SELECT COUNT(*) FROM pagamento WHERE estado=1";
                    if (ano != -1)
                        queryPago += " AND YEAR(dataPagamentoRecebido) = @ano";
                    if (mes != -1)
                        queryPago += " AND MONTH(dataPagamentoRecebido) = @mes";
                    if (nifVisualizar != -1)
                        queryPago += " AND nif = @nif";
                    MySqlCommand cmdPago = new MySqlCommand(queryPago, conn);
                    if (ano != -1)
                        cmdPago.Parameters.AddWithValue("@ano", ano);
                    if (mes != -1)
                        cmdPago.Parameters.AddWithValue("@mes", mes);
                    if (nifVisualizar != -1)
                        cmdPago.Parameters.AddWithValue("@nif", nifVisualizar);
                    string queryNaoPago = "SELECT COUNT(*) FROM pagamento WHERE estado=0";
                    if (ano != -1)
                        queryNaoPago += " AND YEAR(dataPagamentoRecebido) = @ano";
                    if (mes != -1)
                        queryNaoPago += " AND MONTH(dataPagamentoRecebido) = @mes";
                    if (nifVisualizar != -1)
                        queryNaoPago += " AND nif = @nif";
                    MySqlCommand cmdNaoPago = new MySqlCommand(queryNaoPago, conn);
                    if (ano != -1)
                        cmdNaoPago.Parameters.AddWithValue("@ano", ano);
                    if (mes != -1)
                        cmdNaoPago.Parameters.AddWithValue("@mes", mes);
                    if (nifVisualizar != -1)
                        cmdNaoPago.Parameters.AddWithValue("@nif", nifVisualizar);
                    MySqlDataReader drP = cmdPago.ExecuteReader();
                    drP.Read();
                    int nP = drP.GetInt32(0);
                    drP.Close();
                    MySqlDataReader drNP = cmdNaoPago.ExecuteReader();
                    drNP.Read();
                    int nNPd = drNP.GetInt32(0);
                    drNP.Close();
                    string[] nomes = { "Pago", "Por Pagar" };
                    int[] quantidades = { nP, nNPd };
                    drNP.Close();


                    Series series = chart1.Series.Add("Pagamentos");
                    series.ChartType = SeriesChartType.Pie;

                    for (int i = 0; i < nomes.Length; i++)
                    {
                        series.Points.AddXY(nomes[i], quantidades[i]);
                        if (quantidades[i] > 0)
                        {
                            series.Points[i].Label = quantidades[i].ToString();
                        }
                        else
                        {
                            series.Points[i].Label = " ";
                        }
                        series.Points[i].LegendText = nomes[i].ToString();
                    }

                
                return;
                }
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
                {

                    conn.Open();
                    string queryPago = "SELECT COALESCE(Sum(valorPagamento), 0) FROM pagamento WHERE estado=1";
                    if (ano != -1)
                        queryPago += " AND YEAR(dataPagamentoRecebido) = @ano";
                    if (mes != -1)
                        queryPago += " AND MONTH(dataPagamentoRecebido) = @mes";
                    if (nifVisualizar != -1)
                        queryPago += " AND nif = @nif";
                    MySqlCommand cmdPago = new MySqlCommand(queryPago, conn);
                    if (ano != -1)
                        cmdPago.Parameters.AddWithValue("@ano", ano);
                    if (mes != -1)
                        cmdPago.Parameters.AddWithValue("@mes", mes);
                    if (nifVisualizar != -1)
                        cmdPago.Parameters.AddWithValue("@nif", nifVisualizar);
                    string queryNaoPago = "SELECT COALESCE(Sum(valorPagamento), 0) FROM pagamento WHERE estado=0";
                    if (ano != -1)
                        queryNaoPago += " AND YEAR(dataPagamentoRecebido) = @ano";
                    if (mes != -1)
                        queryNaoPago += " AND MONTH(dataPagamentoRecebido) = @mes";
                    if (nifVisualizar != -1)
                        queryNaoPago += " AND nif = @nif";
                    MySqlCommand cmdNaoPago = new MySqlCommand(queryNaoPago, conn);
                    if (ano != -1)
                        cmdNaoPago.Parameters.AddWithValue("@ano", ano);
                    if (mes != -1)
                        cmdNaoPago.Parameters.AddWithValue("@mes", mes);
                    if (nifVisualizar != -1)
                        cmdNaoPago.Parameters.AddWithValue("@nif", nifVisualizar);
                    MySqlDataReader drP = cmdPago.ExecuteReader();
                    drP.Read();
                    int nP = drP.GetInt32(0);
                    drP.Close();
                    MySqlDataReader drNP = cmdNaoPago.ExecuteReader();
                    drNP.Read();
                    int nNPd = drNP.GetInt32(0);
                    drNP.Close();
                    string[] nomes = { "Pago", "Por Pagar" };
                    int[] quantidades = { nP, nNPd };
                    drNP.Close();
                    Series series = chart1.Series.Add("Pagamentos");
                    series.ChartType = SeriesChartType.Pie;

                    for (int i = 0; i < nomes.Length; i++)
                    {
                        series.Points.AddXY(nomes[i], quantidades[i]);
                        if (quantidades[i] > 0)
                        {
                            series.Points[i].Label = quantidades[i].ToString() + "€";
                        }
                        else
                        {
                            series.Points[i].Label = " ";
                        }
                        
                        series.Points[i].LegendText = nomes[i].ToString();
                    }

                }
                return;
                
            }
            


        }
        public void Preencher_dgv(int mes, int ano, int user)
        {
            dgvPagamentos.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pagamento Where 1=1";
                //como eram ifs rapidos usei a identação em vez dos {}
                if (ano != -1)
                    query += " AND YEAR(dataPagamentoRecebido) = @ano";
                if (mes != -1)
                    query += " AND MONTH(dataPagamentoRecebido) = @mes";
                if (nifVisualizar != -1)
                    query += " AND nif = @nif";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (ano != -1)
                    cmd.Parameters.AddWithValue("@ano", ano);
                if (mes != -1)
                    cmd.Parameters.AddWithValue("@mes", mes);
                if (nifVisualizar != -1)
                    cmd.Parameters.AddWithValue("@nif",nifVisualizar);
                MySqlDataReader dr = cmd.ExecuteReader();
                Pagamento pagamento = new Pagamento();
                while (dr.Read())
                {
                    pagamento.Estado = dr.GetByte(4);
                    dgvPagamentos.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2).Date.Date.ToString("dd/MM/yyyy"), dr.GetDouble(3), pagamento.getEstado(), dr.GetInt32(5));
                }
                dr.Close();
                conn.Close();
            }
        }

        private void checkN_CheckedChanged(object sender, EventArgs e)
        {
            if(checkN.Checked)
            {
                n = true;
                checkE.Checked = false;
                PreencherPieDataSet(mes, ano, nifVisualizar, n);
            }
        }

        private void checkE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkE.Checked)
            {
                n=false;
                checkN.Checked = false;
                PreencherPieDataSet(mes, ano, nifVisualizar, n);
            }
        }

        private void btnLimparDefinicoes_Click(object sender, EventArgs e)
        {
            mes = -1;
            ano = -1;
            nifVisualizar = -1;
            n = false;
            atualiza();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMes.SelectedIndex == -1 || cbMes.SelectedIndex == 0)
            {
                mes = -1;
            }
            else
            {
                mes = cbMes.SelectedIndex;
            }
            atualiza();
        }
        void preencherLabels(int mes, int ano, int user)
        {
            #region total
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(valorPagamento) FROM pagamento Where 1=1";
                //como eram ifs rapidos usei a identação em vez dos {}
                if (ano != -1)
                    query += " AND YEAR(dataPagamentoRecebido) = @ano";
                if (mes != -1)
                    query += " AND MONTH(dataPagamentoRecebido) = @mes";
                if (nifVisualizar != -1)
                    query += " AND nif = @nif";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (ano != -1)
                    cmd.Parameters.AddWithValue("@ano", ano);
                if (mes != -1)
                    cmd.Parameters.AddWithValue("@mes", mes);
                if (nifVisualizar != -1)
                    cmd.Parameters.AddWithValue("@nif", nifVisualizar);
                object dr = cmd.ExecuteScalar();
                if (!dr.ToString().Equals(""))
                {
                    double valor = Convert.ToDouble(dr);
                    labelTotal.Text = valor.ToString("N2") + "€";
                }
                else
                {
                    labelTotal.Text = "0€";
                }
                conn.Close();
            }
            #endregion
            #region media
            using(MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                if(mes == -1)
                {
                    string query = "SELECT SUM(valorPagamento) FROM pagamento WHERE 1=1";
                    if (ano != -1)
                        query += " AND YEAR(dataPagamentoRecebido) = @ano";
                    if (user != -1)
                        query += " AND nif = @nif";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (ano != -1)
                        cmd.Parameters.AddWithValue("@ano", ano);
                    if (nifVisualizar != -1)
                        cmd.Parameters.AddWithValue("@nif", user);
                    object dr = cmd.ExecuteScalar();
                    if (!dr.ToString().Equals(""))
                    {
                        double valor = Convert.ToDouble(dr);
                        lblMedia.Text = (valor/12).ToString("N2") + "€";
                    }
                    else
                    {
                        lblMedia.Text = "0€";
                    }
                }
                else
                {
                    lblMedia.Text= labelTotal.Text;
                }
                conn.Close();
            }
            #endregion
        }
        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAno.SelectedIndex == -1 || cbAno.SelectedIndex == 0)
            {
                ano = -1;
            }
            else
            {
                ano = Convert.ToInt32(cbAno.SelectedItem.ToString());
            }
            atualiza();
        }
        public void atualiza()
        {
            edita = false;
            PreencheBarDataset(mes, ano, nifVisualizar);
            PreencherPieDataSet(mes, ano, nifVisualizar, n);
            Preencher_dgv(mes, ano, nifVisualizar);
            preencherLabels(mes, ano, nifVisualizar);
            
        }

        private void panelGlobal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Count() > 0)
            {
                if (int.TryParse(txtPesquisa.Text, out int resultado))
                {
                    List<Utilizador> usersProcurados = users.Where(u => u.Nif.ToString().StartsWith(txtPesquisa.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (Utilizador u in usersProcurados)
                    {
                        User user = new User(u);
                        flowLayoutPanel1.Controls.Add(user);
                    }
                }
                else
                {
                    List<Utilizador> usersProcurados = users.Where(u => u.Nome.StartsWith(txtPesquisa.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (Utilizador u in usersProcurados)
                    {
                        User user = new User(u);
                        flowLayoutPanel1.Controls.Add(user);
                    }
                }

            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Utilizador u in users)
                {
                    User user = new User(u);
                    flowLayoutPanel1.Controls.Add(user);
                }
            }
        }

        private void panelUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPagamentos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
            
        }

        private void dgvPagamentos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow linhaRemovida = e.Row;
            PopUp remover = new PopUp("Tem a certeza que deseja remover este pagamento no valor de "+ linhaRemovida.Cells[3].Value.ToString()+ "€ do utilizador com o nif: " + linhaRemovida.Cells[5].Value + "?", 3);
            remover.ShowDialog();
            if (PopUp.Valor)
            {
                using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM pagamento WHERE idPagamento=@id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", linhaRemovida.Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                atualiza();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvPagamentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (edita)
            {
                DataGridViewRow linhaEditada = dgvPagamentos.Rows[e.RowIndex];
                if(linhaEditada != null)
                {
                    string sql = "UPDATE pagamento SET ";
                    dynamic valor;
                    valor = null;
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            sql += "titulo = @valor";
                            valor = linhaEditada.Cells[1].Value.ToString();
                            break;
                        case 2:
                            if (DateTime.TryParse(linhaEditada.Cells[2].Value.ToString(), out DateTime retoma))
                            {
                                sql += "dataPagamentoRecebido = @valor";
                                valor = retoma;
                                valor.ToString("YYYY-MM-DD");
                            }
                            else
                            {
                                PopUp erro = new PopUp("Erro, valor inválido, deve ser uma data válida!", 1);
                                erro.ShowDialog();
                            }

                            break;
                        case 3:
                            if (Int32.TryParse(linhaEditada.Cells[3].Value.ToString(), out int retomaInt)){
                                valor = retomaInt;
                                sql += "valorPagamento = @valor";
                            }
                            else
                            {
                                PopUp erro = new PopUp("Erro, valor inválido, deve ser um valor real!", 1);
                                erro.ShowDialog();
                            }
                            break;
                        case 4:
                            if(linhaEditada.Cells[2].Value.ToString() == "Pago" || linhaEditada.Cells[2].Value.ToString() == "1")
                            {
                                sql += "estado = @valor";
                                valor = 1;
                            }
                            if(linhaEditada.Cells[2].Value.ToString() == "Por Pagar" || linhaEditada.Cells[2].Value.ToString() == "0")
                            {
                                sql += "estado = @valor";
                                valor = 0;
                            }
                            if(valor == null)
                            {
                                PopUp erro = new PopUp("Erro, valor inválido, deve inserir um dos seguintes valores:\n Pago (ou 1) \n Por Pagar(ou 0)", 1);
                                erro.ShowDialog();
                            }
                            break;
                    }
                    sql += " Where idPagamento=@id";
                    using(MySqlConnection con = new MySqlConnection(LoginAdmin.connectionString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql,con);
                        if(valor != null)
                        {
                            cmd.Parameters.AddWithValue("@valor", valor);
                            cmd.Parameters.AddWithValue("@id",(int)linhaEditada.Cells[0].Value);
                            cmd.ExecuteNonQuery();

                        }
                        else
                        {
                            linhaEditada.Cells[e.ColumnIndex].Value = valorAnterior;
                        }
                        con.Close();

                    }
                }
                atualiza();
            }
            else
            {
                
            }
        }
        dynamic valorAnterior;
        private void dgvPagamentos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            valorAnterior = dgvPagamentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            edita = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGlobal_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
