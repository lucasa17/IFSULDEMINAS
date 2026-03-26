# Solicita um número
numero = int(input("Digite um número para verificar se é primo: "))

if numero < 2:
    print(f"{numero} não é primo")
else:
    eh_primo = True
    
    for divisor in range(2, int(numero ** 0.5) + 1):
        if numero % divisor == 0:
            eh_primo = False
            break
    
    if eh_primo:
        print(f"{numero} É PRIMO!")
    else:
        print(f"{numero} NÃO é primo")
        
        divisores = []
        for i in range(1, numero + 1):
            if numero % i == 0:
                divisores.append(i)
        print(f"Divisores: {divisores}")
