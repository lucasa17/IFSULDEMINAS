lista_compras = []

print("LISTA DE COMPRAS INTERATIVA")
print("Comandos: adicionar, remover, listar, sair")

while True:
    comando = input("\nO que deseja fazer? ").lower()
    
    if comando == "adicionar":
        item = input("Digite o item para adicionar: ")
        lista_compras.append(item)
        print(f"'{item}' foi adicionado à lista")
    
    elif comando == "remover":
        if lista_compras:
            print("Itens na lista:")
            for i, item in enumerate(lista_compras, 1):
                print(f"{i}. {item}")
            
            numero = int(input("Digite o número do item para remover: "))
            if 1 <= numero <= len(lista_compras):
                removido = lista_compras.pop(numero-1)
                print(f"'{removido}' foi removido da lista")
            else:
                print("Número inválido!")
        else:
            print("A lista está vazia!")
    
    elif comando == "listar":
        if lista_compras:
            print("\nSua lista de compras:")
            for i, item in enumerate(lista_compras, 1):
                print(f"{i}. {item}")
            print(f"Total de itens: {len(lista_compras)}")
        else:
            print("A lista está vazia!")
    
    elif comando == "sair":
        print("Programa encerrado!")
        break
    
    else:
        print("Comando não reconhecido!")
