texto = input("Digite uma palavra ou frase: ")

vogais = "aeiouAEIOU"

contador = 0

for letra in texto:
    if letra in vogais:
        contador += 1

print(f"O texto '{texto}' contém {contador} vogais")

vogais_encontradas = set()
for letra in texto.lower():
    if letra in "aeiou":
        vogais_encontradas.add(letra)

if vogais_encontradas:
    print(f"Vogais encontradas: {', '.join(sorted(vogais_encontradas))}")
