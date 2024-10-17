programa {
  funcao inicio() {
    

    real valor

    escreva("Digite o valor de saque: ")
    leia(valor)

    se(valor <= 1000){

      escreva("Seu saque será efetivado, restante em conta R$ ", 1000 - valor)
    }
    senao{

      escreva("Valor maior que o saldo em conta, saque recusado.")
    }
  }
}
