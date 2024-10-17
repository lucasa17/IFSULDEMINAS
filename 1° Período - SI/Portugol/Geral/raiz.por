programa {

  inclua biblioteca Matematica-->m 

  funcao inicio() {
    
    real num


    escreva("Digite um valor: ")
    leia(num)


    se(num > 0){

      escreva(m.raiz(num,2))
    }

    senao{
      escreva("Número inválido")
    }

  }
}
