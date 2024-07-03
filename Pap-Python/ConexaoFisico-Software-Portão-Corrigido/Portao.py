import serial
import time


# esta função é utilizada pelo LerPlacas para caso encontre a placa na bd abra o portao
def abrir_portao():
    # aqui inicia-se a porta no programa ligando á com3.
    porta_serial = serial.Serial('COM3', 9600)
    # esta pausa serve para ter a certeza que estabelece corretamente a porta
    time.sleep(2)
    # aqui envia-se o código estabelecido pelo código do portão (neste caso 0)
    porta_serial.write("0".encode())
    # aqui com tudo encerrado fecha a porta serial
    porta_serial.close()
def fechar_portao():
    # aqui inicia-se a porta no programa ligando á com3.
    porta_serial = serial.Serial('COM3', 9600)
    # esta pausa serve para ter a certeza que estabelece corretamente a porta
    time.sleep(2)
    # aqui envia-se o código estabelecido pelo código do portão (neste caso 0)
    porta_serial.write("1".encode())
    # aqui com tudo encerrado fecha a porta serial
    porta_serial.close()
