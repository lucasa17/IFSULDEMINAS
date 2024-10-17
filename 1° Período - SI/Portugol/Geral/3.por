programa {
  funcao inicio() {
    
    inteiro num, i, pos = 0, neg = 0


    para (inteiro i = 0; i < 5; i++){

        escreva("Digite um número: ")
        leia(num)

        se(num >= 0){
          pos++
        }
        senao{
          neg++
        }

    }

    escreva("\nNúmeros negativos: ",neg)
    escreva("\nNúmeros positivos: ",pos)
  }
}
