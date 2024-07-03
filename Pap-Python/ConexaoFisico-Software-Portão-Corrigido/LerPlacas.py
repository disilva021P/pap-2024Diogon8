import datetime
import time
import cv2
import easyocr
import Portao
import logging
import string
from datetime import datetime
from PesquisasSql import *

logging.basicConfig(filename='logfile.txt', level=logging.INFO)

leitor_ocr = easyocr.Reader(['pt'])  # aqui inicio o leitor de imagem (coloca a imagem em texto)
all_characters = string.printable
letters_and_numbers = string.ascii_letters + string.digits
special_characters = [char for char in all_characters if char not in letters_and_numbers]


def lerplaca():
    camara = cv2.VideoCapture(0)
    texto=""
    camara.set(3, 640)
    camara.set(5, 480)
    nao_encontrou = True
    while nao_encontrou:
        success, img = camara.read()
        plate_cascade = cv2.CascadeClassifier("modelo/haarcascade_russian_plate_number.xml")
        img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        placa = plate_cascade.detectMultiScale(img_gray, 1.1, 4)

        for (x, y, w, h) in placa:
            area = w * h
            if area > 500:
                cv2.rectangle(img, (x, y), (x + w, y + h), (0, 255, 0), 2)
                cv2.putText(img, "Number Plate", (x, y - 5), cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (255, 0, 255), 2)
                img_roi = img[y: y+h, x:x+w]
                cv2.imshow("Placa", img_roi)
                resultado = leitor_ocr.readtext(img_roi)
                for detection in resultado:
                    texto = detection[1].strip()
                    translation_table = str.maketrans("", "", str(special_characters))
                    texto = texto.translate(translation_table)
                    if len(texto) == 6:
                        user = pesquisaMatricula(str(texto))
                        if user is not None:
                            if len(user)==1 and user[0][1]==0 and user[0][2]==1:#o carro só tiver 1 utilizador e estiver fora e estiver ativo
                                updateLocalusers(user[0][0])
                                logging.info(
                                    f'O utilizador {user[0][0]} entrou no parque com a matricula {texto}: ' + str(
                                        datetime.now()))
                                nao_encontrou = False
                            elif len(user) == 1 and user[0][1] == 1 and user[0][
                                2] == 1:  # o carro só tiver 1 utilizador e estiver fora e estiver ativo
                                updateLocalusersSair(user[0][0])
                                logging.info(
                                    f'O utilizador {user[0][0]} saiu no parque com a matricula {texto}: ' + str(
                                        datetime.now()))
                                nao_encontrou = False

                            elif len(user)==2 and (user[0][1]==0 or user[1][1]==0) and (user[1][2]==1 or user[1][2]==1):
                                if user[0][1]==0 and user[0][2]==1:
                                    updateLocalusers(user[0][0])
                                    logging.info(f'O utilizador {user[0][0]} entrou no parque com a matricula {texto}: ' + str(
                                            datetime.now()))
                                    nao_encontrou = False
                                elif user[1][1]==0 and user[1][2]==1:
                                    logging.info(
                                        f'O utilizador {user[1][0]} entrou no parque com a matricula {texto}: ' + str(
                                            datetime.now()))
                                    updateLocalusers(user[1][0])
                                    nao_encontrou = False

                            elif len(user)==2 and (user[0][1]==1 and user[1][1]==1) and (user[1][2]==1 or user[1][2]==1):
                                if user[0][1]==1 and user[0][2]==1:
                                    updateLocalusersSair(user[0][0])
                                    logging.info(f'O utilizador {user[0][0]} saiu no parque com a matricula {texto}: ' + str(
                                            datetime.now()))
                                    nao_encontrou = False
                                elif user[1][1]==1 and user[1][2]==1:
                                    logging.info(
                                        f'O utilizador {user[1][0]} saiu no parque com a matricula {texto}: ' + str(
                                            datetime.now()))
                                    updateLocalusersSair(user[1][0])
                                    nao_encontrou = False



        cv2.imshow("Result", img)
        key = cv2.waitKey(1)
        if key == ord('q'):
            break
    Portao.abrir_portao()
    camara.release()
    cv2.destroyAllWindows()
    return texto


def verificarCarro(placaRecebida):
    camara = cv2.VideoCapture(0)
    camara.set(3, 640)
    camara.set(5, 480)

    tentativas = 100
    while tentativas > 0:
        success, img = camara.read()
        plate_cascade = cv2.CascadeClassifier("modelo/haarcascade_russian_plate_number.xml")
        img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        placa = plate_cascade.detectMultiScale(img_gray, 1.1, 4)
        for (x, y, w, h) in placa:
            area = w * h
            if area > 500:
                cv2.rectangle(img, (x, y), (x + w, y + h), (0, 255, 0), 2)
                cv2.putText(img, "Number Plate", (x, y - 5), cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (255, 0, 255), 2)
                img_roi = img[y: y + h, x:x + w]
                cv2.imshow("Placa", img_roi)
                resultado = leitor_ocr.readtext(img_roi)
                for detection in resultado:
                    texto = detection[1].strip()
                    texto = texto.strip('.')
                    texto = texto.strip('-')
                    if len(texto) == 6:
                        if texto == placaRecebida:
                            return True

        cv2.imshow("Result", img)
        key = cv2.waitKey(1)
        if key == ord('q'):
            break
        tentativas -= 1
    camara.release()
    cv2.destroyAllWindows()
    return False


def main():
    while True:
        placaAtual = lerplaca()
        time.sleep(2)
        carroParado = verificarCarro(placaAtual)
        while carroParado:
            carroParado = verificarCarro(placaAtual)
        Portao.fechar_portao()
        time.sleep(2)

main()



