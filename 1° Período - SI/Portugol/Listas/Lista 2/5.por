programa {
  funcao inicio() {
    

    real valor

    escreva("Digite o valor da compra: ")
    leia(valor)

    se(valor > 1500){

      escreva("Sua compra foi taxada em 5%, custando então R$ ", valor * 1.05)
    }
    senao{

      escreva("Sua compra esta dentro dos conformes.")
    }
  }
}
