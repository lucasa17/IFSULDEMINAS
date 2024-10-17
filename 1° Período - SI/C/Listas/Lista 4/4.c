#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
int num, chute = 0, cont = 0;

srand(time(0));

num = 1 + (rand() % 100);

while(num != chute) {

printf("Digite um valor entre 1 e 100: ");
scanf("%d", &chute);

if(chute > num) {

printf("O chute foi mais alto que o número\n\n");

}

else if(chute < num) {

printf("O chute foi mais baixo que o número\n\n");

}

cont++;
}

printf("Você acertou com %d", cont);

return 0;
}
