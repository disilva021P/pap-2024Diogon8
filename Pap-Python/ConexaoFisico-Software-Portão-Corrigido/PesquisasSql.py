import mysql.connector

conexao_config = {
    'host': 'localhost',
    'user': 'root',
    'password': 'mysql',
    'database': 'papgestaofinal'
}

def updateLocalusers(nif):
    print(nif)
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"update utilizador set idlocalizao=1 where nif={int(nif)}")
    cursor.execute(consulta_sql)
    cursor.close()
    conexao.commit()
    conexao.close()

def pesquisaMatricula(matricula):
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (
        "SELECT u.nif AS nif, u.idlocalizao AS local, u.idEstadoUtilizador AS estado "
        "FROM carro c,carroutilizador cu, utilizador u "
        "WHERE c.idCarro = cu.idCarro AND cu.idUtilizador = u.nif "
        f"AND c.matricula = '{matricula}';"
    )
    cursor.execute(consulta_sql)
    resultados = cursor.fetchall()

    cursor.close()
    conexao.close()
    if resultados:
        return resultados
    else:
        return None
