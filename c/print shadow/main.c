#include <stdio.h>

int main()
{
    int i;
    int  j;
    int a=25;

    for(i=1; i<=a; i++)
    {
        for(j=i; j<a; j++)
        {
            printf(" ");
        }

        for(j=1; j<=i; j++)
        {
            if(i==a || j==1 || j==i)
            {
                printf("*");
            }
            else
            {
                printf(" ");
            }
        }

        printf("\n");
    }

    return 0;
}
