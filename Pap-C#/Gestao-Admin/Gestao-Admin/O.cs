using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Ocorrencias : UserControl
    {
        List<OcorrenciasBd> ocorrencias = new List<OcorrenciasBd>();
        public Ocorrencias()
        {
            InitializeComponent();
        }

        private void Ocorrencias_Load(object sender, EventArgs e)
        {
            ocorrencias.Clear();
            ocorrencias = OcorrenciasBd.getOcorrencias();
            atualizarDgv();
        }
        void atualizarDgv()
        {
            dgvOcorrencias.Rows.Clear();
            foreach (OcorrenciasBd o in ocorrencias)
            {
                dgvOcorrencias.Rows.Add(o.IdOcorrencia.ToString(), o.Nif.ToString(),
                    o.Motivo, o.Descricao, o.DataOcorrencia.ToString("dd-MM-yyyy"), o.Matricula,
                    o.getEstado()
                    );
            }
        }
        private void PanelUnico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvOcorrencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizarEstado_Click(object sender, EventArgs e)
        {
            if (dgvOcorrencias.SelectedRows.Count < 1)
            {
                PopUp erro = new PopUp("Erro, por favor selecione uma linha!", 1);
                erro.ShowDialog();
                return;
            }
            OcorrenciasBd o = ocorrencias[dgvOcorrencias.SelectedRows[0].Index];
            if (o.IdEstadoOcorrencias == 2)
            {
                PopUp erro = new PopUp("Erro, esta ocorrência ja foi finalizada!", 1);
                erro.ShowDialog();
                return ;
            }
            o.IdEstadoOcorrencias += 1;
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql1 = "Update ocorrencias set idEstadoOcorrencias=@id where idOcorrencia=@idOCORRCIA";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@id",o.IdEstadoOcorrencias);
                cmd1.Parameters.AddWithValue("@idOCORRCIA", o.IdOcorrencia);

                
                cmd1.ExecuteNonQuery();
                atualizarDgv();
                conn.Close();
            }
        }

        private void btnTomarAcao_Click(object sender, EventArgs e)
        {
            if(dgvAcao.SelectedRows.Count == 0)
            {
                PopUp erro = new PopUp("Erro, por favor selecione uma linha!", 1);
                erro.ShowDialog();
                return;
            }
            if (txtValor.Text.ToString().Equals(""))
            {
                PopUp erro = new PopUp("Erro, caso não queira multar apenas finalize!", 1);
                erro.ShowDialog();
                return;
            }
            string valor = dgvOcorrencias.SelectedRows[0].Cells[5].Value.ToString();
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql = "SELECT nif FROM papgestaofinal.carro,carroutilizador,utilizador WHERE carro.matricula=@matricula and carro.idCarro=carroutilizador.idCarro and carroutilizador.idUtilizador = utilizador.nif;";
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@matricula", valor);
                MySqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                int nif = dr.GetInt32(0);
                dr.Close();
                string sql1 = "INSERT INTO `papgestaofinal`.`pagamento` (`titulo`, `dataPagamentoRecebido`,`valorPagamento`,`estado`,`nif`,`email`) VALUES ('Multa', @data, @valor,0,@nif,0) ;";
                MySqlCommand cmdPagamento = new MySqlCommand(sql1, conn);
                cmdPagamento.Parameters.AddWithValue("@data", DateTime.Now);
                cmdPagamento.Parameters.AddWithValue("@valor", Convert.ToDouble( txtValor.Text));
                cmdPagamento.Parameters.AddWithValue("@nif", nif);
                cmdPagamento.ExecuteNonQuery();
                guna2Panel2.Visible= false;
                string sqlUpdate = "update ocorrencias set idEstadoOcorrencias=2  where idOcorrencia=@id";
                MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@id", Convert.ToInt32(dgvOcorrencias.SelectedRows[0].Cells[0].Value));
                cmdUpdate.ExecuteNonQuery();
                conn.Close();
                atualizarDgv();


            }



        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvOcorrencias.SelectedRows.Count == 0)
            {
                PopUp erro = new PopUp("Erro, por favor selecione uma linha!", 1);
                erro.ShowDialog();
                return;
            }
            string valor = dgvOcorrencias.SelectedRows[0].Cells[5].Value.ToString();
            if (valor.Equals(""))
            {
                PopUp erro = new PopUp("Erro, só pode tomar uma ação caso tenha mais alguém envolvido", 1);
                erro.ShowDialog();
                return;
            }
            MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString);
            
                conn.Open();
                string sql1 = "SELECT matricula,nif,nome,sobrenome FROM papgestaofinal.carro,carroutilizador,utilizador WHERE carro.matricula=@matricula and carro.idCarro=carroutilizador.idCarro and carroutilizador.idUtilizador = utilizador.nif;";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@matricula", valor);
                MySqlDataReader dr = cmd1.ExecuteReader();
            
            if (!dr.HasRows)
            {
                PopUp erro = new PopUp("Erro, Esta matricula não existe!", 1);
                erro.ShowDialog();
                conn.Close();
                return;
            }
                if (guna2Panel2.Visible)
                {
                    guna2Panel2.Visible = false;
                }
                else
                {
                    
                    dgvAcao.Rows.Clear();
                    guna2Panel2.Visible = true;
                    while (dr.Read())
                    {
                        dgvAcao.Rows.Add(dr.GetInt32(1),dr.GetString(2)+" "+dr.GetString(3));
                    }
                    
                }
            conn.Close();

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvOcorrencias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvOcorrencias.Rows[e.RowIndex];
            if(linha.Cells[0].Value != null) {
                MostrarOcorrencia oc = new MostrarOcorrencia(Convert.ToInt32(linha.Cells[0].Value));
                oc.ShowDialog();
            }
            
        }
    }
    }

