#include <stdio.h>

int
main ()
{

  double raio, aux;



  scanf ("%lf", &raio);

  aux = (raio * raio) * 3.14159;

  printf ("A=%.4lf\n", aux);
  return 0;
}
