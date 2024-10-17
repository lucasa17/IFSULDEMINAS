programa {
  funcao inicio() {
   
    inteiro cod

    real valor, etiqueta



      escreva("\nDigite o valor da etiqueta: ")  
      leia(etiqueta)

    escreva("\n  Código |            Pagamento            |    Desconto  ")
    escreva("\n    0    |             A Vista             |     25%      ")
    escreva("\n    1    |      Cheque(30 dias)            |     20%      ")
    escreva("\n    2    |      Cartão de crédito(2x)      |     10%      ")
    escreva("\n    3    |      Cartão de crédito(3x)      |     5%       ")
    escreva("\n  outra  |      Negociada com o vendedor   | Sem desconto ")

      escreva("\nDigite o código: ")  
      leia(cod)


escolha(cod){

    caso 0:

      escreva("\nO valor dado foi de: R$ ", etiqueta * 0.75)  
       
    pare

    caso 1:

      escreva("\nO valor dado foi de: R$ ", etiqueta * 0.80)  

    pare

    caso 2:

      escreva("\nO valor dado foi de: R$ ", etiqueta * 0.90)  

    pare

    caso 3:

      escreva("\nO valor dado foi de: R$ ", etiqueta * 0.95)  

    pare
    caso contrario:
      escreva("\nO valor dado foi de: R$ ", etiqueta)  
  }

  }
}
