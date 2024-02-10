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
                        break
                for lugar in lugares:
                    print(f'Lugar: {str(lugar[0])}')
                    print(f'Estado {str(lugar[1])}')


    except KeyboardInterrupt:
        porta_serial.close()


if __name__ == '__main__':
    while True:
        le_serial()
