programa {

  inclua biblioteca Matematica

  funcao inicio() {
    

    real x1, x2, y1, y2 ,resultado, aux
    
    escreva("Digite um ponto para x1\n")
    leia(x1)

    escreva("Digite um ponto para y1\n")
    leia(y1)

    escreva("\nDigite um ponto pra x2\n")
    leia(x2)

    escreva("\nDigite um ponto para y2\n")
    leia(y2)


  aux = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))

  resultado = Matematica.raiz(aux,2)

  escreva("O resultado é ",resultado)
  }
}
