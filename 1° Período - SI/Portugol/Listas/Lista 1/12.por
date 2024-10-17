programa {
  funcao inicio() {
    

    real dep, tax

    escreva("Digite o valor do depósito: ")
    leia(dep)

    escreva("Digite o valor da taxa de juros: ")
    leia(tax)

    escreva("\nO rendimento será de R$", dep * tax/100)

    escreva("\n\nO total após o rendimento será de R$", dep + (dep * tax/100))
  }
}
