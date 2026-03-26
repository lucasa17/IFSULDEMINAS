nota1 = float(input("Digite a primeira nota: "))
nota2 = float(input("Digite a segunda nota: "))
nota3 = float(input("Digite a terceira nota: "))

media = (nota1 + nota2 + nota3) / 3

print(f"Sua média é: {media:.2f}")

if media >= 7:
    print("Parabéns! Você foi APROVADO!")
elif media >= 5:
    print("Você está em RECUPERAÇÃO")
else:
    print("Infelizmente você foi REPROVADO")
