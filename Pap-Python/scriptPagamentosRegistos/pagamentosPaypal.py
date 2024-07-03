import paypalrestsdk
ip = "http://125.0.0.1:5000"
paypalrestsdk.configure({
  "mode": "sandbox",
  "client_id": "AXOPHiCMaFO0BPekWv0E2Ee-gMz2LzU9ZosZHbeNjaFMmswwEhSfc4mSXSPE44CD5CqGu2ZXPM9mwHTK",
  "client_secret": "EMpM5e4jD67XVjLGqiRgaoPjnyx7jhOwKOJpF7bGS50V6iOZBOfDdrJHUGhw-ZrwPqPtsapUz4HQ-JSD" })

def criarPagamento(preco):
    payment = paypalrestsdk.Payment({
        "intent": "sale",
        "payer": {
            "payment_method": "paypal"},
        "redirect_urls": {
            "return_url": f"{ip}/payment/execute/",
            "cancel_url": f"{ip}/payment/canceled/"},
        "transactions": [{
            "item_list": {
                "items": [{
                    "name": "item",
                    "sku": "item",
                    "price": str(preco),
                    "currency": "EUR",
                    "quantity": 1}]},
            "amount": {
                "total": str(preco),
                "currency": "EUR"},
            "description": "Pagamento Parque Pap."}]})
    payment.create()
    for link in payment.links:
        if link.rel == "approval_url":
            approval_url = link.href
            return[payment.id,approval_url]


def pagamentoEstado(idPagamento)->bool:

    payment = paypalrestsdk.Payment.find(idPagamento)
    if payment.state == "approved":
        return True
    else:
        return False

