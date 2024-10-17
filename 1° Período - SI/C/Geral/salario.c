#include <stdio.h>

int main ()
{

  int func, horas;
  double salario;



  scanf ("%d", &func);
  scanf ("%d", &horas);
  scanf ("%lf", &salario);




  printf ("NUMBER = %d\n", func);
  printf ("SALARY = U$ %.2lf\n", horas*salario);

  return 0;
}
