import mysql.connector

conexao_config = {
    'host': 'localhost',
    'user': 'root',
    'password': 'mysql',
    'database': 'papgestaofinal'
}
def updateLugar(nlugar,estado):
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"update lugar set idOcupacao={estado} where Nlugar={nlugar}")
    cursor.execute(consulta_sql)
    cursor.close()
    conexao.commit()
    conexao.close()
def selecionarEstado():
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"Select Nlugar,idOcupacao from lugar")
    cursor.execute(consulta_sql)
    resultados = cursor.fetchall()
    cursor.close()
    conexao.commit()
    conexao.close()
    return resultados