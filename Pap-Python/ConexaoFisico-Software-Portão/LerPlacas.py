import time
import cv2
import easyocr
import Portao

leitor_ocr = easyocr.Reader(['pt'])  # aqui inicio o leitor de imagem (coloca a imagem em texto)
def lerplaca():
    camara = cv2.VideoCapture(0)
    texto=""
    camara.set(3, 640)
    camara.set(5, 480)
    nao_encontrou = True
    while nao_encontrou:
        success, img = camara.read()
        plate_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_russian_plate_number.xml")
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
                    symbols = {'`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '[',
                               '}', '}', '|', '\\',':',';', ',','"','<',',','>','.','?','/'}

                    for chars in symbols:
                        texto = texto.strip(chars)
                    if len(texto) == 6:
                        if texto == "AB75BA":
                            nao_encontrou = False
                    print(texto)

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
        plate_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_russian_plate_number.xml")
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
                    print(texto)

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
            print("carro parado")
        Portao.fechar_portao()
        time.sleep(2)

main()



