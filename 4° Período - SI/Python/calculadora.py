import math

def adicao(a, b):
    return a + b

def subtracao(a, b):
    return a-b

def multiplicacao(a, b):
    return a * b

def divisao(a, b):
    if b != 0:
        return a / b
    else:
        return "Erro: divisão por zero!"

def potencia(a, b):
    return a ** b

def raiz_quadrada(a):
    if a >= 0:
        return math.sqrt(a)
    else:
        return "Erro: número negativo!"

print("CALCULADORA PYTHON")
print("-" * 30)

while True:
    print("\nOperações disponíveis:")
    print("1. Adição (+)")
    print("2. Subtração (-)")
    print("3. Multiplicação (*)")
    print("4. Divisão (/)")
    print("5. Potência (^)")
    print("6. Raiz quadrada (√)")
    print("7. Sair")
    
    escolha = input("\nEscolha uma operação (1-7): ")
    
    if escolha == "7":
        print("Calculadora encerrada!")
        break
    
    if escolha in ["1", "2", "3", "4", "5"]:
        try:
            num1 = float(input("Digite o primeiro número: "))
            num2 = float(input("Digite o segundo número: "))
        except ValueError:
            print("Erro: Digite apenas números!")
            continue
       
        # Faz algo dependendo da escolha do usuário
        if escolha == "1":
            resultado = adicao(num1, num2)
            print(f"{num1} + {num2} = {resultado}")
        elif escolha == "2":
            resultado = subtracao(num1, num2)
            print(f"{num1} - {num2} = {resultado}")
        elif escolha == "3":
            resultado = multiplicacao(num1, num2)
            print(f"{num1} * {num2} = {resultado}")
        elif escolha == "4":
            resultado = divisao(num1, num2)
            print(f"{num1} / {num2} = {resultado}")
        elif escolha == "5":
            resultado = potencia(num1, num2)
            print(f"{num1} ^ {num2} = {resultado}")
    
    elif escolha == "6":
        try:
            num = float(input("Digite o número: "))
            resultado = raiz_quadrada(num)
            print(f"√{num} = {resultado}")
        except ValueError:
            print("Erro: Digite apenas números!")
    
    else:
        print("Opção inválida!")
