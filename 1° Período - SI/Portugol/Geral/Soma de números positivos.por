programa {
  funcao inicio() {
    
    real a, soma, val

soma = 0

escreva("Escreva a quantidade de n�meros a serem digitados: ")
leia(val)

para (inteiro i = 1; i <= val; i++)  
{  

    escreva("\nDigite o ",i,"� n�mero:")
    leia(a)

      se(a >= 0){

        soma = a + soma
      }

    //escreva(soma)
} 
    

  escreva("\nA soma final dos n�meros positivos � ", soma)



  }
}
