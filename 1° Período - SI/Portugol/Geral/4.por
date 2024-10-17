programa {
  funcao inicio() {
    
    inteiro num, i, aux = 0

escreva("Digite um valor: ")
leia(num)

    para(inteiro i = 1; i <= num; i++){


      se(num %i == 0 e num != i){

        aux = i + aux

      }


    }

    se(aux == num){

      escreva("\nO número é perfeito.")
    }
    senao{

      escreva("\nO número é imperfeito.")
    }

  }
}
