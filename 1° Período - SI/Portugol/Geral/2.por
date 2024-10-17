programa {
  funcao inicio() {
    
    inteiro a = 0, b = -1, i
    real s = 0

      para (inteiro i = 0; i < 50; i++){ 
      
      a++

      b = b + 2

      s = s + (b/a)

      escreva("\t",b,"/")
      escreva(a,"\t ||")

      }

      escreva("\nO valor de S equivale a ", s)
  }
}
