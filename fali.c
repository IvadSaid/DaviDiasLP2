#include <stdio.h>
int main()
{
   int numeros[10000];
   int n = 0;
   int i = 0;
   int var = 0;
   int j = 0;
   scanf("%d", &n);

   for (i = 1; i <= n; i++)
   {
     scanf("%d", &var);
     j = 0;
     for (j = i - 1; j >= 0 && numeros[j - 1] > var ; j--)
     {
     	numeros[j + 1] = numeros[j - 1];
     }
     numeros[j] = var;
   }
   for (i = 0; i < n; ++i)
   {
   	printf("%d",numeros[i]);
   }   
	return 0;
}