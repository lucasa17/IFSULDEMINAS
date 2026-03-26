n = int(input("Quantos números da sequência de Fibonacci você quer ver? "))

if n <= 0:
    print("Por favor, digite um número positivo")
elif n == 1:
    print("Sequência de Fibonacci: 0")
else:
    fibonacci = [0, 1]
    
    for i in range(2, n):
        proximo = fibonacci[i-1] + fibonacci[i-2]
        fibonacci.append(proximo)
    
    print(f"Sequência de Fibonacci com {n} números:")
    print(fibonacci)
    
    soma = sum(fibonacci)
    print(f"Soma dos números: {soma}")
