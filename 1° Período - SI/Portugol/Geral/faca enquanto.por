programa {
  funcao inicio() {
    
    real a, soma, val, i=1

soma = 0

escreva("Escreva a quantidade de n�meros a serem digitados: ")
leia(val)

faca {  

    escreva("\nDigite o ",i++,"� n�mero:")
    leia(a)

      se(a >= 0){

        soma = a + soma
      }

      val--

} 

enquanto(val > 0)
    

  escreva("\nA soma final dos n�meros positivos � ", soma)



  }
}
