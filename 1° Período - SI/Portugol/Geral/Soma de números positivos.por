programa {
  funcao inicio() {
    
    real a, soma, val

soma = 0

escreva("Escreva a quantidade de números a serem digitados: ")
leia(val)

para (inteiro i = 1; i <= val; i++)  
{  

    escreva("\nDigite o ",i,"° número:")
    leia(a)

      se(a >= 0){

        soma = a + soma
      }

    //escreva(soma)
} 
    

  escreva("\nA soma final dos números positivos é ", soma)



  }
}
