programa {
  funcao inicio() {
   
    inteiro sal, beb, quantsal, quantbeb, ped

    real salval = 0, bebval = 0, salvalfim = 0, bebvalfim= 0, total

faca{


    escreva("\nProdutos:")
    escreva("\n  Cod  |     Salgados    | Valor")
    escreva("\n  101  |     Coxinha     | 4.50 ")
    escreva("\n  102  |     Joelho      | 5.50 ")
    escreva("\n  103  |      Pizza      | 6.00 ")

      escreva("\nDigite o código: ")  
      leia(sal)


escolha(sal){

    caso 101:

    escreva("\nQuantos salgado deseja: ")  
    leia(quantsal)

        salval = 4.50 * quantsal

        salvalfim = salval + salvalfim
    pare

    caso 102:

    escreva("\nQuantos salgado deseja: ")  
    leia(quantsal)

        salval = 5.50 * quantsal

        salvalfim = salval + salvalfim
    pare

    caso 103:

    escreva("\nQuantos salgado deseja: ")  
    leia(quantsal)

        salval = 6.00 * quantsal

        salvalfim = salval + salvalfim
    pare

    caso contrario:
      escreva("\nCódigo inválido de salgado.")
  }






      escreva("\n")

    escreva("\n  Cod  |     Bebidas     | Valor")
    escreva("\n  201  |      Água       | 3.00 ")
    escreva("\n  202  |  Refrigerante   | 4.50 ")
    escreva("\n  203  |      Suco       | 5.50 ")


      escreva("\nDigite o código: ")  
      leia(beb)

     
   
 escolha(beb){

    caso 201:

      escreva("\nQuantos bebidas deseja: ")  
      leia(quantbeb)

        bebval = 3.00 * quantbeb

        bebvalfim = bebval + bebvalfim
    pare

    caso 202:

      escreva("\nQuantos bebidas deseja: ")  
      leia(quantbeb)
     
        bebval = 4.50 * quantbeb

        bebvalfim = bebval + bebvalfim
    pare

    caso 203:

      escreva("\nQuantos bebidas deseja: ")  
      leia(quantbeb)
     
        bebval = 5.50 * quantbeb

        bebvalfim = bebval + bebvalfim
    pare

    caso contrario:
      escreva("\nCódigo inválido de bebida.")
  }


          escreva("\nDeseja encerrar o pedido?")
          escreva("\n|  1   | Sim |")
          escreva("\n|  0   | Não |")
          leia(ped)

      escreva("\n\n")
  limpa()

}
enquanto(ped == 0)

            total = salvalfim + bebvalfim

            se(total > 100){

                escreva("Seu pedido com desconto ficou em R$ ", total * 0.90)

            }
            senao{

                  escreva("Seu pedido ficou em R$ ", total)

            }

  }
}
