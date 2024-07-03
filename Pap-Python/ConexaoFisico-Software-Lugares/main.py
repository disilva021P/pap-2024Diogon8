import time

from PesquisaSQL import *
def le_serial():
    import serial
    porta_serial = serial.Serial('COM4', 9600)  # Substitua 'COM3' pela porta serial que está usando
    dados_recebidos = False
    lugares = []
    try:
        while not dados_recebidos:
            if porta_serial.in_waiting > 0:
                while True:
                    lugar = porta_serial.readline().decode('utf-8')
                    lugares.append([int(lugar[0]), int(lugar[2])])
                    if int(lugar[0]) == 2: # == 2 pois é para exemplificar no caso real
                        # deveria fazer uma query para ver quantos lugares o parque possui
                        # esta seria a query:SELECT MAX(nLugar) AS ultimoLugar FROM lugar;
                        dados_recebidos = True
                        break
    except KeyboardInterrupt:
        porta_serial.close()
    finally:
        return lugares


if __name__ == '__main__':
    while True:
        lugares = le_serial()
        lugaresbd = selecionarEstado()
        for lugar_bd in lugaresbd:
            for lugar_recebido in lugares:
                if lugar_bd[0] == lugar_recebido[0] and lugar_bd[1] != lugar_recebido[1]:
                    updateLugar(lugar_bd[0],lugar_recebido[1])

        time.sleep(2)