programa {
  funcao inicio() {
   
    inteiro ano, aux

    real valor


      escreva("\nDigite o valor do carro: ")  
      leia(valor)

      escreva("\nDigite o ano do carro: ")  
      leia(ano)

aux = 2024 - ano

    se(aux <= 24){

        escreva("\nO valor dado foi de: R$ ", valor * 0.015)  

    }
    senao se(aux > 24){

        escreva("\nO valor dado foi de: R$ ", valor * 0.01)  

    }
  }
}
