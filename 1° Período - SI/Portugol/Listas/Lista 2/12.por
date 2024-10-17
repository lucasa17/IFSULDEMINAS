programa {
  funcao inicio() {
   
    inteiro cod

    cadeia nome

      escreva("Digite seu nome: ")  
      leia(nome)

    escreva("\n  Código |         Curso          ")
    escreva("\n    1    | Sistemas de Informação ")
    escreva("\n    2    |       Agronomia        ")
    escreva("\n    3    |     Administração      ")
    escreva("\n    4    |       Nutrição         ")

      escreva("\n\nDigite o código: ")  
      leia(cod)

escolha(cod){

    caso 1:

      escreva("\n", nome ," faz o curso de Sistemas de Informação")  
  
    pare

    caso 2:

      escreva("\n", nome ," faz o curso de Agronomia")  

    pare

    caso 3:

      escreva("\n", nome ," faz o curso de Administração")  

    pare
    
    caso 4:

      escreva("\n", nome ," faz o curso de Nutrição")  

    pare

    caso contrario:

      escreva("\nCódigo inválido")  
  
  }

  }
}
