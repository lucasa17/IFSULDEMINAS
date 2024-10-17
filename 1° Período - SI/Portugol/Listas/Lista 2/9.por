programa {
  funcao inicio() {
    
    real a, aux

    escreva("Digite um valor: ")
    leia(a)

aux = a / 2 

    se(aux >= 50 e aux <= 100){

      escreva("\nO valor ", a," esta entre 100 e 200")

    }

    senao{

      escreva("\nO valor ", a," não esta entre 100 e 200")

    }
  }
}
