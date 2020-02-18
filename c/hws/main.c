#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a;
    int b;
    int c;
    int d;

    printf("Enter Your First Number : ");
    scanf("%d",&a);
    printf("your first number is %d\n",a);

    printf("Enter Your second Number : ");
    scanf("%d",&b);
    printf("your second number is %d\n",b);

    printf("Enter Your third Number : ");
    scanf("%d",&c);
    printf("your third number is %d\n",c);

    printf("Enter Your fourth Number : ");
    scanf("%d",&d);
    printf("your fourth number is %d\n",d);

    if(a>b||a>c||a>d)
    {
        printf("your largest number is %d",a);

    }
    else if(b>a||b>c||b>d)
    {
        printf("your largest number is %d",b);

    }
    else if(c>a||c>b||c>d)
    {
        printf("your largest number is %d",c);

    }
    else if(d>a||d>b||d>c)
    {
          printf("your largest number is %d",d);

    }
        else{
        printf("wrong something");
    }





    return 0;
}
