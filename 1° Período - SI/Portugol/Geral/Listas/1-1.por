programa {
  funcao inicio() {
  
    real d, h, m, s

    escreva("Digite a quantia de dias: ")
    leia(d)

    escreva("Digite a quantia de horas: ")
    leia(h)	

    escreva("Digite a quantia de minutos: ")
    leia(m)

    escreva("Digite a quantia de segundos: ")
    leia(s)

    escreva("\nPortanto são ", (d * 86400) + (h * 3600) + (m * 60) + s, " segundos")
  }
}
