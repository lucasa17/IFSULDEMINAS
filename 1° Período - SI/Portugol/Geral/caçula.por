programa {
  funcao inicio() {
 
    inteiro a, b, c


    escreva("digite a idade do Jonas: ")
    leia(a)

    escreva("digite a idade do Marcos: ")
    leia(b)

    escreva("digite a idade do Leandro: ")
    leia(c)

        se(a > b e c > b){

            escreva("Marcos é o caçula")
        }

        senao se(b > a e c > a){

            escreva("Jonas é o caçula")

        }

        senao se(b > c e a > c){

            escreva("Leandro é o caçula")

        }

        senao se(a == b e b == c){

          escreva("Todos tem a mesma idade")
        }

        senao se(a == b e b < c){

          escreva("Jonas e Marcos tem a mesma idade, e Leandro é mais velho")
        }

        senao se(a == c e a < b){

          escreva("Jonas e Leandro tem a mesma idade, e Marcos é mais velho")
        }

        senao se(c == b e b < a){

          escreva("Leandro e Marcos tem a mesma idade, e Jonas é mais velho")
        }



  }
}
