programa {
  funcao inicio() {
   

    real num1, par = 0, imp = 1, cont = 0

escreva("ENCERRE O PROGRAMA DIGITANDO O VALOR '0'\n\n")
faca
{  


  escreva("\n\nDigite uma valor: ")
  leia(num1)


  se(num1 %2 == 0){


    par = num1 + par

  }
  senao{

    imp = num1 * imp
  }

cont++

}


enquanto(num1 != 0)


escreva("\nA soma dos pares é de ", par)
escreva("\nO produto dos ímpares é de ", imp)

  }
}
