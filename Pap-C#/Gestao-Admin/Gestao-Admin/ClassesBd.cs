using System;

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

public class Ocorrencias
{
    public int IdOcorrencia { get; set; }
    public int Nif { get; set; }
    public string Motivo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataOcorrencia { get; set; }
    public byte[] Foto { get; set; }
    public string Matricula { get; set; }
    public int IdEstadoOcorrencias { get; set; }

    public EstadoOcorrencia EstadoOcorrencia { get; set; }
    public Utilizador Registardor { get; set; }
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

    // Relacionamentos
    public Utilizador User { get; set; }
}

public class Plano
{
    public int IdPlano { get; set; }
    public string Nome { get; set; }
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
    public byte?[] Foto { get; set; }
    public string Comentarios { get; set; }
    public string Numero { get; set; }
    public DateTime DataInscricao { get; set; }
    public int NOcorrenciasCometidas { get; set; }
    public string IdLocalizacao { get; set; }
    public string IdEstadoUtilizador { get; set; }
    public string IdPlano { get; set; }
}

public class UtilizadorLogin
{
    public int Nif { get; set; }
    public string Password { get; set; }
}
