programa {
  funcao inicio() {
    
    inteiro idade

    escreva("Digite sua idade: ")
    leia(idade)

    se(idade <= 10){

      escreva("\nSua categoria é Infantil")

    }

    senao se(idade > 10 e idade <= 17){

      escreva("\nSua categoria é Juvenil")

    }
    
    senao se(idade > 17){

      escreva("\nSua categoria é Sênior")
      
    }
  }
}
