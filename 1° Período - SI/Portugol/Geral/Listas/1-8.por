programa {

  inclua biblioteca Matematica-->m

  funcao inicio() {

    inteiro a, b, c, d, x

    escreva("Digite o valor de 'a' na equação: ")
    leia(a)

    escreva("Digite o valor de 'b' na equação: ")
    leia(b)

    escreva("Digite o valor de 'c' na equação: ")
    leia(c)

    escreva("Digite o valor de 'd' na equação: ")
    leia(d)

    escreva("Digite o valor de 'x' na equação: ")
    leia(x)

    escreva("O resultado da equação polinomial de quarto grau é ", (a * m.potencia(x,4)) + (b * m.potencia(x,3)) + (c * m.potencia(x,2)) + (d * x) + 0)
  }
}
