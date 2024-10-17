programa {
  funcao inicio() {
    
    real a, soma, val, i=1

soma = 0

escreva("Escreva a quantidade de números a serem digitados: ")
leia(val)

faca {  

    escreva("\nDigite o ",i++,"° número:")
    leia(a)

      se(a >= 0){

        soma = a + soma
      }

      val--

} 

enquanto(val > 0)
    

  escreva("\nA soma final dos números positivos é ", soma)



  }
}
