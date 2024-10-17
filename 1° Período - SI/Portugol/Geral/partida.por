programa {
  funcao inicio() {
    
    inteiro pessoas

    escreva("Digite a quantidade de pessoas que assistiram a partida: ")
    leia(pessoas)


    se(pessoas <= 1000){

      escreva("Público baixo")

    }

    senao se(pessoas >= 1001 e pessoas < 10000){

      escreva("Público médio")

    }

    senao se(pessoas >= 10000){

      escreva("Público bom")
    }
  }
}
