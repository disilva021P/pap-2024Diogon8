using Gestao_Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class AdminLogin
{
    public int Nif { get; set; }
    public string Nome { get; set; }
    public string Password { get; set; }
}

public class Carro
{
    public int IdCarro { get; set; }
    public string Matricula { get; set; }
    public string Marca { get; set; }
}

public class CarroUtilizador
{
    public int IdUtilizador { get; set; }
    public int IdCarro { get; set; }
    public int? CarroEmprestado { get; set; }
}

public class ControleExecucao
{
    public int IdControleExecucao { get; set; }
    public string NomeProcedure { get; set; }
    public int Nif { get; set; }
    public byte Cancelar { get; set; }
}

public class EstadoOcorrencia
{
    public int IdEstadoOcorrencia { get; set; }
    public string Estado { get; set; }
}

public class EstadoUtilizador
{
    public int IdEstadoUtilizador { get; set; }
    public string Estado { get; set; }
}

public class Localizacao
{
    public int IdLocalizacao { get; set; }
    public string LocalizacaoTxt { get; set; }
}

public class Lugar
{
    public int NLugar { get; set; }
    public string Tipo { get; set; }
    public int? Nif { get; set; }
    public int IdOcupacao { get; set; }

    public OcupacaoLugar EstadoOcupacao { get; set; }
    public Utilizador Utilizador { get; set; }
}

public class OcorrenciasBd
{
    public int IdOcorrencia { get; set; }
    public int Nif { get; set; }
    public string Motivo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataOcorrencia { get; set; }
    public byte[] Foto { get; set; }
    public string Matricula { get; set; }
    public int IdEstadoOcorrencias { get; set; }
    public string getEstado()
    {
        if (IdEstadoOcorrencias == 0) return "Por Analisar";
        else if (IdEstadoOcorrencias == 1) return "Em análise";
        else return "Finalizada";
    }
    public EstadoOcorrencia EstadoOcorrencia { get; set; }
    public static List<OcorrenciasBd> getOcorrencias()
    {
        List<OcorrenciasBd> listaOcorrencias = new List<OcorrenciasBd>();
        using (MySqlConnection con = new MySqlConnection(LoginAdmin.connectionString))
        {
            con.Open();
            string sql = "Select * from ocorrencias;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                OcorrenciasBd oc = new OcorrenciasBd();
                oc.IdOcorrencia = dr.GetInt32(0);
                oc.Nif = dr.GetInt32(1);
                oc.Motivo = dr.GetString(2);
                oc.Descricao = dr.GetString(3);
                oc.DataOcorrencia = dr.GetDateTime(4);
                oc.Foto = (byte[])dr[5];
                oc.Matricula = (dr.IsDBNull(6)) ? "" : dr.GetString(6);
                oc.IdEstadoOcorrencias = dr.GetInt32(7);
                listaOcorrencias.Add(oc);
            }
            dr.Close();
            con.Close();
        }
        return listaOcorrencias;
    }
}


public class OcupacaoLugar
{
    public int IdEstado { get; set; }
    public string Estado { get; set; }
}


public class Pagamento
{
    public int IdPagamento { get; set; }
    public string Titulo { get; set; }
    public DateTime DataPagamentoRecebido { get; set; }
    public double ValorPagamento { get; set; }
    public byte Estado { get; set; }
    public int Nif { get; set; }

    public string getEstado()
    {
        if (Estado == 0)
        {
            return "Por Pagar";
        }
        else
        {
            return "Pago" ;
        }
    }
}

public class Plano
{
    public int IdPlano { get; set; }
    public string Nome { get; set; }
    public string Titulo { get; set; }

    public double Valor { get; set; }
}

public class Utilizador
{
    public int Nif { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Morada { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
    public byte[] Foto { get; set; }
    public string Comentarios { get; set; }
    public string Numero { get; set; }
    public DateTime DataInscricao { get; set; }
    public int NOcorrenciasCometidas { get; set; }
    public string IdLocalizacao { get; set; }
    public string IdEstadoUtilizador { get; set; }
    public string IdPlano { get; set; }
    static public List<Utilizador> getUsers()
    {
        List<Utilizador> users = new List<Utilizador>();
        using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
        {
            connection.Open();
            string query = "SELECT nif, nome, sobrenome, morada, dataNascimento, email, foto,comentarios,numero,dataInscricao,nOcorrenciasCometidas," +
                "(SELECT estado FROM estadoutilizador WHERE idEstadoUtilizador = utilizador.idEstadoUtilizador) AS estado_utilizador," +
                "(SELECT titulo FROM planos WHERE idPlano = utilizador.idplano) AS nome_plano," +
                "(SELECT localizacaoTxt FROM localizacao WHERE idlocalizacao = utilizador.idlocalizao) AS localizacao FROM    utilizador;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Utilizador u = new Utilizador();
                u.Nif = dr.GetInt32(0);
                u.Nome = dr.GetString(1);
                u.Sobrenome = dr.GetString(2);
                u.Morada = dr.GetString(3);
                u.DataNascimento = dr.GetDateTime(4).Date;
                u.Email = dr.GetString(5);
                u.Foto = (byte[])dr[6];
                u.Comentarios = dr.GetString(7);
                u.Numero = dr.GetString(8);
                u.DataInscricao = dr.GetDateTime(9).Date;
                u.NOcorrenciasCometidas = dr.GetInt32(10);
                u.IdEstadoUtilizador = dr.GetString(11);
                u.IdPlano = dr.GetString(12);
                u.IdLocalizacao = dr.GetString(13);
                users.Add(u);
            }
            dr.Close();
        }
        return users;
    }
    static public List<Utilizador> getUsersSemLugar()
    {
        List<Utilizador> users = new List<Utilizador>();
        using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
        {
            connection.Open();
            string query = "SELECT utilizador.nif, utilizador.nome, utilizador.sobrenome, utilizador.morada, utilizador.dataNascimento, utilizador.email, utilizador.foto, utilizador.comentarios, utilizador.numero, utilizador.dataInscricao, utilizador.nOcorrenciasCometidas, estadoutilizador.estado AS estado_utilizador, planos.titulo AS nome_plano, localizacao.localizacaoTxt AS localizacao "+ 
            " FROM utilizador "+
            "JOIN estadoutilizador ON estadoutilizador.idEstadoUtilizador = utilizador.idEstadoUtilizador "+
            "JOIN planos ON planos.idPlano = utilizador.idplano "+
            "JOIN localizacao ON localizacao.idlocalizacao = utilizador.idlocalizao "+
            "LEFT JOIN lugar ON utilizador.nif = lugar.nif "+
            "WHERE lugar.nif IS NULL;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Utilizador u = new Utilizador();
                u.Nif = dr.GetInt32(0);
                u.Nome = dr.GetString(1);
                u.Sobrenome = dr.GetString(2);
                u.Morada = dr.GetString(3);
                u.DataNascimento = dr.GetDateTime(4).Date;
                u.Email = dr.GetString(5);
                u.Foto = (byte[])dr[6];
                u.Comentarios = dr.GetString(7);
                u.Numero = dr.GetString(8);
                u.DataInscricao = dr.GetDateTime(9).Date;
                u.NOcorrenciasCometidas = dr.GetInt32(10);
                u.IdEstadoUtilizador = dr.GetString(11);
                u.IdPlano = dr.GetString(12);
                u.IdLocalizacao = dr.GetString(13);
                users.Add(u);
            }
            dr.Close();
        }
        return users;
    }
}

public class UtilizadorLogin
{
    public int Nif { get; set; }
    public string Password { get; set; }
}
