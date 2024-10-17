programa {

  inclua biblioteca Matematica-->m

  funcao inicio() {
    

    real termo1, razao, termon


    escreva("Digite o primeiro termo da PG: ")
    leia(termo1)

    escreva("Digite a razão da PG: ")
    leia(razao)

    escreva("Digite qual termo da PG deseja ser mostrado: ")
    leia(termon)

    escreva("O valor do ",termon ," na PG é de ", termo1 * m.potencia(razao, termon-1))
  }
}
