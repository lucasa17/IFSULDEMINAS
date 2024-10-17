programa {
  funcao inicio() {
    
    real valor, taxa, tempo

    escreva("Digite o valor original da prestação: ")
    leia(valor)

    escreva("Digite a taxa de juros: ")
    leia(taxa)

    escreva("Digite o número de meses atrasados: ")
    leia(tempo)

    escreva("\nO valor final da prestação é de R$", valor+(valor*(taxa/100)*tempo))
  }
}
