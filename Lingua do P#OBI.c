#include <stdio.h>
#define MAX 1001
int main (void)
{
    char c[MAX];
    while(scanf("%[^\n]", c)== 1){};
    int cont = 1;
    int i = 0;
    while(c[i] != '\0')     
    { 
        if(cont % 2 == 0)
        {
            printf("%c", c[i]);
        }
        cont++; 
         if (c[i] == ' ')
        {
            printf("%c", c[i]);
            cont= 1;
        }
        
        
        i++;
    }
    return 0;
}
