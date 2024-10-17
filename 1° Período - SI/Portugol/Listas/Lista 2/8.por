programa {
  funcao inicio() {
   
    inteiro cod

    real horas

      escreva("Digite as horas trabalhadas: ")  
      leia(horas)

    escreva("\n  Código |    Nível    |   Hora/Aula  ")
    escreva("\n    1    |      1      |    R$12,00   ")
    escreva("\n    2    |      2      |    R$17,00   ")
    escreva("\n    3    |      3      |    R$25,00   ")

      escreva("\n\nDigite o código: ")  
      leia(cod)

escolha(cod){

    caso 1:

      escreva("\nSálario: R$ ", 12 * horas)  
  

    pare

    caso 2:

      escreva("\nSálario antigo: R$ ", 17 * horas)  

    pare

    caso 3:

      escreva("\nSálario antigo: R$ ", 25 * horas)  

    pare
    
    caso contrario:

      escreva("\nCódigo inválido")  
  
  }

  }
}
