#include <stdio.h>
int main()
{
	int alt[100000];
     int qtd;
	int i;
     int j;
	int resp = 0;
     int maiorn = 0;
     int pri;
     int ult;
     int dimi = 2     
	scanf("%d", &qtd);
	for (i = 0; i < qtd; i++)
	 {
	 	scanf("%d", &alt[i]);
          if (i == 0)
           {
               pri = alt[i];
           }
           if (i == qtd - 1)
            {
                 ult = alt[i];
            }
            if (i != 0 || i != qtd - 1)
             {
                  if (alt[i] == pri || alt[i] == ult)
                  {
                       dimi++;
                  }
             } 
	 }
      i = 0;
     for (i = 1; i < qtd; i++)
     {
     	if (alt[i] < alt[i - 1] || alt[i] == alt[i - 1])
     	{
     		alt[i] = 'd';
          }
     }

     for (j = 1; j < qtd; j++)
     {
          i = 1;
     	if (alt[j] < alt[j + 1] || alt[j] == alt[j + 1])
     	{
     		if (alt[j] == alt[i] && alt[i] == 'd')
               {
                  resp++;  
               }
          }

          i++;
     }
     
     if (dimi == 2)
     {
          printf("%d", resp);
     }
     if (dimi > 2)
     {
          resp = resp - dimi;
          printf("%d", resp);
     }
    
     
     return 0;
}
