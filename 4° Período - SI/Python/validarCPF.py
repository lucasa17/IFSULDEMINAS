def validar_cpf(cpf):
    cpf_limpo = ''.join(filter(str.isdigit, cpf))
    
    if len(cpf_limpo) != 11:
        return False
    
    if cpf_limpo == cpf_limpo[0] * 11:
        return False
    
    soma = 0
    for i in range(9):
        soma += int(cpf_limpo[i]) * (10-i)
    
    resto = soma % 11
    digito1 = 0 if resto < 2 else 11-resto
    
    if digito1 != int(cpf_limpo[9]):
        return False
    
    soma = 0
    for i in range(10):
        soma += int(cpf_limpo[i]) * (11-i)
    
    resto = soma % 11
    digito2 = 0 if resto < 2 else 11-resto
    
    return digito2 == int(cpf_limpo[10])

cpf = input("Digite o CPF (apenas números ou com pontos e traço): ")

if validar_cpf(cpf):
    print("CPF VÁLIDO!")
    cpf_numeros = ''.join(filter(str.isdigit, cpf))
    cpf_formatado = f"{cpf_numeros[:3]}.{cpf_numeros[3:6]}.{cpf_numeros[6:9]}-{cpf_numeros[9:]}"
    print(f"CPF formatado: {cpf_formatado}")
else:
    print("CPF INVÁLIDO!")
    print("Verifique se digitou corretamente")
