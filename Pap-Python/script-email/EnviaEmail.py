import time
from email.message import EmailMessage
import ssl
import smtplib
from flask import Flask, request, jsonify, render_template
from mysql import connector
import serial

app = Flask(__name__)
app.config['DEBUG'] = True
app.config['ENV'] = 'development'

email_envio = "contatestepapdiogon8esca@gmail.com"
codigo= "atsl chzh mvme nglf"
chave= "PALAVRAPASSULTRASECRETA:O!okjachega"
def conectar_bd():
    return connector.connect(
        host="localhost",
        user="root",
        password="mysql",
        database="papgestaofinal"
    )

@app.route('/api/enviaemail/', methods=['GET'])
def enviar_email():
    para = request.args.get('para')
    assunto = request.args.get('assunto')
    corpo = request.args.get('corpo')
    dados = {
        "resultado": "error",
    }
    if para is not None and assunto is not None and corpo is not None:
        em = EmailMessage()
        em['From'] = email_envio
        em['To'] = para
        em['subject'] = assunto
        em.set_content(corpo)
        context= ssl.create_default_context()
        with smtplib.SMTP_SSL('smtp.gmail.com',465,context=context) as smtp:
            smtp.login(email_envio,codigo)
            smtp.sendmail(email_envio, para, em.as_string())
            dados = {
                "resultado": "sucess",
            }

    return jsonify(dados)
@app.route('/', methods=['GET','POST'])
def post():
    return "teste"
@app.route('/payment/execute/', methods=['GET','POST'])
def pagamento():
    return render_template("Confirmado.html")
@app.route('/payment/canceled/', methods=['GET'])
def cancelado():
    return render_template("Erro.html")

@app.route('/loginUtilizadores/', methods=["GET","POST"])
def loginUtilizadores():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    password = request.args.get('pass')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT Count(*) FROM utilizadorlogin WHERE nif={int(nif)} AND password={str(password)}"
    cursor.execute(query)
    resultados = cursor.fetchall()
    dados = {
        "entra": False,
    }
    for linha in resultados:
        if int(linha[0]) > 0:
            dados = {
                "entra": True,
            }
    conexao.close()

    return jsonify(dados)


@app.route('/getPagamentos/', methods=["GET","POST"])
def getPagamentos():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT * FROM pagamento WHERE nif={int(nif)}"
    cursor.execute(query)
    resultados = cursor.fetchall()
    pagamentos = []
    for linha in resultados:
        pagamento_json = {
            "id": linha[0],
            "titulo": linha[1],
            "data": linha[2].strftime("%d-%m-%Y"),
            "valor": linha[3],
            "estado": linha[4],
        }
        pagamentos.append(pagamento_json)
    conexao.close()

    return jsonify(pagamentos)

@app.route('/getOcorrencias/', methods=["GET","POST"])
def getOcorrencias():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT * FROM ocorrencias WHERE nif={int(nif)}"
    cursor.execute(query)
    resultados = cursor.fetchall()
    ocorrencias = []
    for linha in resultados:
        ocorrencias_json = {
            "id": linha[0],
            "motivo": linha[2],
            "descricao": linha[3],
            "dataOcorrencia": linha[4].strftime("%d-%m-%Y"),
            "foto": linha[5].hex(),
            "matricula": linha[6],
            "idEstadoOcorrencia": linha[7],
        }
        ocorrencias.append(ocorrencias_json)
    conexao.close()

    return jsonify(ocorrencias)


@app.route('/adicionarOcorrencias/', methods=["GET","POST"])
def adicionarOcorrencias():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = int(request.args.get('nif'))
    motivo= request.args.get('motivo')
    descricao = request.args.get('descricao')
    data = request.args.get('data')
    foto = request.form.get('foto')
    matricula = request.args.get('matricula')
    if matricula == "":
        matricula = None
    foto_blob = bytes.fromhex(foto)
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = """
            INSERT INTO ocorrencias (nif, motivo, descricao, dataOcorrencia, foto, matricula, idEstadoOcorrencias)
            VALUES (%s, %s, %s, %s, %s, %s, %s)
        """
    params = (nif, motivo, descricao, data, foto_blob, matricula, 0)
    cursor.execute(query, params)
    conexao.commit()
    conexao.close()

    return jsonify({"message": "Success"}), 200

@app.route('/confs/', methods=["GET"])
def configuracoes():
    api_key = request.args.get('api_key')
    if not api_key==(chave) :
        return jsonify({"error": "Chave de API inválida"}), 401
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = """
                SELECT * FROM papgestaofinal.confs;
            """
    cursor.execute(query)
    resultados = cursor.fetchall()
    conexao.close()
    return jsonify(resultados)
@app.route('/getInfo/', methods=["GET"])
def getInfo():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT * FROM papgestaofinal.utilizador WHERE nif={int(nif)}"
    cursor.execute(query)
    resultados = cursor.fetchall()
    infos = []
    for linha in resultados:
        info_json = {
            "nome": linha[1]+" " +linha[2],
            "morada": linha[3],
            "dataNascimento": linha[4].strftime("%d-%m-%Y"),
            "email": linha[5],
            "foto": linha[6].hex(),
            "numero": linha[8],
            "nocorrencias": linha[10]

        }
        infos.append(info_json)
    conexao.close()

    return jsonify(infos)

@app.route('/lugar/', methods=["GET"])
def lugar():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT Nlugar,idOcupacao FROM papgestaofinal.lugar WHERE nif={int(nif)}"
    cursor.execute(query)
    resultados = cursor.fetchall()
    lugar = []
    for linha in resultados:
        if linha[1]==0:
            ocupacao="Desocupado"
        else:
            ocupacao="Ocupado"
        lugar_json = {
            "lugar": int(linha[0]),
            "ocupacao": ocupacao
        }
    lugar.append(lugar_json)
    conexao.close()

    return jsonify(lugar)

@app.route('/pagamentoLink/', methods=["GET"])
def pagamentoLink():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    pagamentoId = request.args.get('id')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT paypal_email FROM papgestaofinal.pagamento WHERE idPagamento={int(pagamentoId)}"
    cursor.execute(query)
    resultado = cursor.fetchall()
    conexao.close()
    return jsonify({"link": resultado[0][0]})

@app.route('/getCarros/', methods=["GET","POST"])
def getCarros():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = request.args.get('nif')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    query = f"SELECT carro.idCarro,carro.matricula,carro.marca FROM carro,carroutilizador WHERE carroutilizador.idUtilizador={int(nif)} and" \
            f" carroutilizador.idCarro=carro.idCarro "
    cursor.execute(query)
    resultados = cursor.fetchall()
    carros = []
    for linha in resultados:
        carros_json = {
            "id": linha[0],
            "matricula": linha[1],
            "marca":linha[2]
        }
        carros.append(carros_json)
    conexao.close()

    return jsonify(carros)

@app.route('/adicionarCarros/', methods=["GET","POST"])
def adicionarCarros():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = int(request.args.get('nif'))
    matricula = request.args.get('matricula')
    marca = request.args.get('marca')
    if marca == "":
        marca = None
    conexao = conectar_bd()
    cursor = conexao.cursor()
    querySelect = "SELECT * FROM papgestaofinal.carro where matricula=%s;"
    params = (matricula,)
    cursor.execute(querySelect, params)
    resultado=cursor.fetchall()
    if resultado:
        query = """
            INSERT INTO carroutilizador (idUtilizador, idCarro)
            VALUES (%s, %s)
                        """
        params1 = (nif, resultado[0])
        cursor.execute(query, params1)
        conexao.commit()
    else:
        query = """
                INSERT INTO carro (matricula, marca)
                VALUES (%s, %s)
            """
        params = (matricula,marca)
        cursor.execute(query, params)
        idCarro = cursor.lastrowid
        query1 = """
                    INSERT INTO carroutilizador (idUtilizador, idCarro)
                    VALUES (%s, %s)
                """
        params1 = (nif, idCarro)
        cursor.execute(query1, params1)
        conexao.commit()
        conexao.close()

    return jsonify({"message": "Success"}), 200

@app.route('/removerCarros/', methods=["GET","POST"])
def removerCarros():
    api_key = request.args.get('api_key')
    if api_key.__eq__(chave) is False:
        return jsonify({"error": "Chave de API inválida"}), 401
    nif = int(request.args.get('nif'))
    idCarro = request.args.get('idCarro')
    conexao = conectar_bd()
    cursor = conexao.cursor()
    querySelect = "SELECT * FROM papgestaofinal.carro,papgestaofinal.carroutilizador where carro.idCarro=%s and carroutilizador.idCarro=carro.idCarro"
    params = (idCarro,)
    cursor.execute(querySelect, params)
    resultado=cursor.fetchall()
    linhas =cursor.rowcount
    querydelet = "delete from carroutilizador where idCarro=%s and idUtilizador=%s"
    paramsdelet = (idCarro, nif)
    cursor.execute(querydelet, paramsdelet)
    if linhas < 2:
        querydelet = "delete from carro where idCarro=%s "
        paramsdelet = (idCarro, )
        cursor.execute(querydelet, paramsdelet)
    conexao.commit()
    conexao.close()

    return jsonify({"message": "Success"}), 200


@app.route('/criarEvento/')
def criarEvento():
    conexao = conectar_bd()
    cursor = conexao.cursor()
    nif = int(request.args.get('nif'))
    intervalo = request.args.get('intervalo')
    sqlEvento = f"""
            CREATE EVENT IF NOT EXISTS evento_{str(nif)}
            ON SCHEDULE EVERY {intervalo}
            DO
            BEGIN
                DECLARE valor DECIMAL(10, 2);
                DECLARE Frequencia VARCHAR(255);

                SELECT p.nome INTO Frequencia
                FROM Planos p
                JOIN Utilizador u ON p.idPlano = u.idplano
                WHERE u.nif = {nif}
                LIMIT 1;

                SELECT p.valor INTO valor
                FROM Planos p
                JOIN Utilizador u ON p.idPlano = u.idplano
                WHERE u.nif = {nif}
                LIMIT 1;

                INSERT INTO Pagamento (titulo, dataPagamentoRecebido, valorPagamento, estado, nif, email)
                VALUES (CONCAT('Pagamento ', Frequencia), NOW(), valor, 0, {nif}, 0);
            END
        """

    # Executar o comando SQL para criar o evento
    cursor.execute(sqlEvento)
    conexao.commit()
    conexao.close()
    return jsonify({"message": "Success"}), 200

@app.route('/dropEvento/')
def dropEvento():
    conexao = conectar_bd()
    cursor = conexao.cursor()
    nif = int(request.args.get('nif'))
    sqlEvento = f"""
                Drop event evento_{str(nif)}
            """

    # Executar o comando SQL para criar o evento
    try:
        cursor.execute(sqlEvento)
        conexao.commit()
    except:
        ...
    conexao.close()
    return jsonify({"message": "Success"}), 200


@app.route('/abrir_portao/')
def abrir_portao():
    # aqui inicia-se a porta no programa ligando á com3.
    porta_serial = serial.Serial('COM3', 9600)
    # esta pausa serve para ter a certeza que estabelece corretamente a porta
    time.sleep(2)
    # aqui envia-se o código estabelecido pelo código do portão (neste caso 0)
    porta_serial.write("0".encode())
    # aqui com tudo encerrado fecha a porta serial
    porta_serial.close()
@app.route('/fechar_portao/')
def fechar_portao():
        # aqui inicia-se a porta no programa ligando á com3.
        porta_serial = serial.Serial('COM3', 9600)
        # esta pausa serve para ter a certeza que estabelece corretamente a porta
        time.sleep(2)
        # aqui envia-se o código estabelecido pelo código do portão (neste caso 0)
        porta_serial.write("1".encode())
        # aqui com tudo encerrado fecha a porta serial
        porta_serial.close()
if __name__ == '__main__':
    app.run(debug=True,host="0.0.0.0")