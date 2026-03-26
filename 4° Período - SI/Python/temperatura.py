def celsius_para_fahrenheit(celsius):
    return (celsius * 9/5) + 32

def celsius_para_kelvin(celsius):
    return celsius + 273.15

def fahrenheit_para_celsius(fahrenheit):
    return (fahrenheit-32) * 5/9

def kelvin_para_celsius(kelvin):
    return kelvin-273.15

# Menu principal
print("CONVERSOR DE TEMPERATURA")
print("1. Celsius para Fahrenheit")
print("2. Celsius para Kelvin")
print("3. Fahrenheit para Celsius")
print("4. Kelvin para Celsius")

escolha = input("\nEscolha uma opção (1-4): ")
temperatura = float(input("Digite a temperatura: "))

if escolha == "1":
    resultado = celsius_para_fahrenheit(temperatura)
    print(f"{temperatura}°C = {resultado:.2f}°F")
elif escolha == "2":
    resultado = celsius_para_kelvin(temperatura)
    print(f"{temperatura}°C = {resultado:.2f}K")
elif escolha == "3":
    resultado = fahrenheit_para_celsius(temperatura)
    print(f"{temperatura}°F = {resultado:.2f}°C")
elif escolha == "4":
    resultado = kelvin_para_celsius(temperatura)
    print(f"{temperatura}K = {resultado:.2f}°C")
else:
    print("Opção inválida!")
