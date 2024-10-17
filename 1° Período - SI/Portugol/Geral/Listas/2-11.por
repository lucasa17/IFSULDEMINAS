programa {
  funcao inicio() {
   
    caracter cod

    real a, b

      escreva("Digite um número: ")  
      leia(a)

    escreva("\n  Código |    Operador      ")
    escreva("\n    +    |      Soma        ")
    escreva("\n    -    |     Subtração    ")
    escreva("\n    *    |   Multiplicação  ")
    escreva("\n    /    |     Divisão      ")

      escreva("\n\nDigite o código: ")  
      leia(cod)

escolha(cod){

    caso '+':

      escreva("Digite outro número: ")  
      leia(b)

      escreva("\nResultado: ", a + b)  
  
    pare

    caso '-':

      escreva("Digite outro número: ")  
      leia(b)

      escreva("Resultado: ", a - b)  
    pare

    caso '*':

      escreva("Digite outro número: ")  
      leia(b)

      escreva("Resultado: ", a * b)  
    pare
    
    caso '/':

      escreva("Digite outro número: ")  
      leia(b)

      escreva("Resultado: ", a / b)  
    pare

    caso contrario:

      escreva("\nCódigo inválido")  
  
  }

  }
}
