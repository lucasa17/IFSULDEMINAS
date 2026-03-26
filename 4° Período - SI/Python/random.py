import random

numero_secreto = random.randint(1, 100)
tentativas = 0
max_tentativas = 10

print("JOGO DE ADIVINHAÇÃO")
print(f"Tente adivinhar o número entre 1 e 100")
print(f"Você tem {max_tentativas} tentativas")

while tentativas < max_tentativas:
    tentativas += 1
    tentativas_restantes = max_tentativas-tentativas
    
    try:
        palpite = int(input(f"\nTentativa {tentativas}: "))
    except ValueError:
        print("Por favor, digite apenas números!")
        continue
    
    if palpite == numero_secreto:
        print(f"PARABÉNS! Você acertou em {tentativas} tentativas!")
        break
    elif palpite < numero_secreto:
        print(f"Muito baixo! Tente um número maior.")
        if tentativas_restantes > 0:
            print(f"Restam {tentativas_restantes} tentativas")
    else:
        print(f"Muito alto! Tente um número menor.")
        if tentativas_restantes > 0:
            print(f"Restam {tentativas_restantes} tentativas")
    
    if tentativas == max_tentativas // 2:
        if numero_secreto <= 50:
            print("Dica: O número está na primeira metade (1-50)")
        else:
            print("Dica: O número está na segunda metade (51-100)")

if tentativas == max_tentativas:
    print(f"\nVocê perdeu! O número era {numero_secreto}")
