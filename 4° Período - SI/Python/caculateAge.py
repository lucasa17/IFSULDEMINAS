from datetime import datetime

ano_atual = datetime.now().year

ano_nascimento = int(input("Em que ano você nasceu? "))

idade = ano_atual-ano_nascimento

print(f"Você tem {idade} anos ou fará {idade} anos este ano!")
