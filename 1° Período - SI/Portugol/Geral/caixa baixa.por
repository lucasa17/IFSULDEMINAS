programa {

    inclua biblioteca Texto --> t    

  funcao inicio() {
    

    cadeia opcao

    escreva("Digite uma letra: ")
    leia(opcao)

  opcao = t.caixa_baixa(opcao)

    escolha(opcao){


      caso 'a':
        escreva("A de Arara")
      pare

      caso 'b':
        escreva("B de Baleia")
      pare

      caso 'c':
        escreva("C de Cachorro")
      pare

      caso 'd':
        escreva("D de Dragão")
      pare

      caso 'e':
        escreva("E de Escola")
      pare

      caso contrario:
        escreva("Essa letra, ainda não foi cadastrada")
    }
  }
}
