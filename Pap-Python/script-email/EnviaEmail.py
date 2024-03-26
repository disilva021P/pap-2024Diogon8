from email.message import EmailMessage
import ssl
import smtplib
from flask import Flask, request, jsonify
app = Flask(__name__)
app.config['DEBUG'] = True
app.config['ENV'] = 'development'

email_envio = "contatestepapdiogon8esca@gmail.com"
codigo= "atsl chzh mvme nglf"
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
@app.route('/', methods=['GET'])
def test():
    return "Test route"

if __name__ == '__main__':
    app.run(debug=True,host="0.0.0.0")