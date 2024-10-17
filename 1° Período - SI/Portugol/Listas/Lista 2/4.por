programa {
  funcao inicio() {

    inteiro cod

    real sal

      escreva("Digite seu sálario atual: ")
      leia(sal)

    escreva("\n  Código |       Cargo       |  Percentual  ")
    escreva("\n   101   |      Gerente      |     10%      ")
    escreva("\n   102   |      Engenheiro   |     20%      ")
    escreva("\n   103   |      Técnico      |     30%      ")

      escreva("\n\nDigite o código: ")
      leia(cod)

escolha(cod){

    caso 101:

      escreva("\nSálario antigo: R$ ", sal)
      escreva("\nSálario novo: R$ ", sal * 1.1)
      escreva("\nDiferença: R$ ", (sal * 1.1) - sal)

    pare

    caso 102:

      escreva("\nSálario antigo: R$ ", sal)
      escreva("\nSálario novo: R$ ", sal * 1.2)
      escreva("\nDiferença: R$ ", (sal * 1.2) - sal)

    pare

    caso 103:

      escreva("\nSálario antigo: R$ ", sal)
      escreva("\nSálario novo: R$ ", sal * 1.3)
      escreva("\nDiferença: R$ ", (sal * 1.3) - sal)

    pare

    caso contrario:

      escreva("\nSálario antigo: R$ ", sal)
      escreva("\nSálario novo: R$ ", sal * 1.4)
      escreva("\nDiferença: R$ ", (sal * 1.4) - sal)

  }

  }
}
