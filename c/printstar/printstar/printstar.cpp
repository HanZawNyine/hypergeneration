#include <stdio.h>
#include<conio.h>
void funPrintStar(char* ss, int s);


int main()
{
	int s1 = 10;
	int s2 = 5;
	int s3 = 3;
	char ss1[3] = "s1";
	char ss2[3] = "s2";
	char ss3[3] = "s3";
	funPrintStar(ss1, s1);
	funPrintStar(ss2, s2);
	funPrintStar(ss3, s3);
	return 0;

}

void funPrintStar(char* ss,int s)
{
	printf(ss);
	printf(" \n");

	for (int i ==j; i <= s; i++)
	{
		printf("*");
		printf(" \n");
	}
	printf("\n");

}