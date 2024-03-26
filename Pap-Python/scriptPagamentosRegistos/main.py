import mysql.connector
import datetime
import requests
import time
conexao_config = {
    'host': 'localhost',
    'user': 'root',
    'password': 'mysql',
    'database': 'papgestaofinal'
}
print(datetime.datetime.now().date())
def pesquisaRececao():
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"select nif,nome,sobrenome,email from utilizador where rececao=0 and dataInscricao=\"{datetime.datetime.now().date()}\"")
    cursor.execute(consulta_sql)
    resultados = cursor.fetchall()
    cursor.close()
    conexao.commit()
    conexao.close()
    return resultados
def pesquisaPagamentos():
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"SELECT pagamento.*, utilizador.email FROM pagamento,utilizador where pagamento.email = 0 and pagamento.nif=utilizador.nif;")
    cursor.execute(consulta_sql)
    resultados = cursor.fetchall()
    cursor.close()
    conexao.commit()
    conexao.close()
    return resultados
def atualizaRececao(nif):
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"update utilizador set rececao=1 where nif={nif}")
    cursor.execute(consulta_sql)
    cursor.close()
    conexao.commit()
    conexao.close()

def atualizaPesquisa(idpagamento):
    conexao = mysql.connector.connect(**conexao_config)
    cursor = conexao.cursor()
    consulta_sql = (f"update pagamento set email=1 where idPagamento={idpagamento}")
    cursor.execute(consulta_sql)
    cursor.close()
    conexao.commit()
    conexao.close()

assunto= "Já está inscrito no parque!"
while True:
    #region receção
    pessoalRececao = pesquisaRececao()
    for pessoa in pessoalRececao:
        mensagem = f"Olá senhor\\a {pessoa[1]} {pessoa[2]} damos-lhe as boas-vindas ao nosso parque damos as felicidades de o ter por ca!"
        response = requests.get(f"http://127.0.0.1:5000/api/enviaemail/?para={pessoa[3]}&assunto={assunto}&corpo={mensagem}")
        if response.status_code == 200:
            dados = response.json()
            if dados['resultado']== "sucess":
                atualizaRececao(pessoa[0])
                print("Funcionou!")
        else:
            print(f"Falha na requisição. Código de status: {response.status_code}")
            dados = response.json()
    time.sleep(1)
    #endregion
    #region pagamentos
    pagamentos = pesquisaPagamentos()
    for pagamento in pagamentos:
        assuntoPag = f"Novo {pagamento[1]} enviado!"
        mensagem = f"Olá senhor\\a {pagamento[6]} vimos por aqui informar que tem um novo pagamento no valor de {pagamento[3]}" \
                   f" devemos informar que deve pagar dentro do tempo estipulado!"
        response = requests.get(
            f"http://127.0.0.1:5000/api/enviaemail/?para={pagamento[7]}&assunto={assuntoPag}&corpo={mensagem}")
        if response.status_code == 200:
            dados = response.json()
            if dados['resultado'] == "sucess":
                atualizaPesquisa(pagamento[0])
                print(pagamento)
                print("ALoooo!")
        else:
            print(f"Falha na requisição. Código de status: {response.status_code}")
            dados = response.json()
    time.sleep(1)
    #endregion