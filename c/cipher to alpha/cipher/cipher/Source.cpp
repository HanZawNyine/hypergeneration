#include<stdio.h>
#include<conio.h>

int main()
{
	char alpha[27] = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
	char subs[27] = { '!','@','#','$','%','^','&','*','(',')','_','+','<','>','.','?','/','-','=','{','}','1','2','3','4','5' };

	char plain[1000];
	char cipher[1000];

	for (int j = 0; j < 1000; j++)
	{
		cipher[j] = '\n';
	}
	printf("enter your cipher text \n");
	int index = 0;
	int index1 = 0;
	int status = 0;
	int i;
	int ch;
	do {
		ch = getc(stdin);
		if (ch == '\n')
		{
			plain[index1] = '\n';
			cipher[index1++] = '\n';
			status = 0;
			break;
		}
		for (i = 0; i < 27; i++)
		{
			if (alpha[i] == ch)
			{
				status = 1;
				break;
			}

		}
		if (status == 1)
		{
			subs[index1] = cipher[i];
			status = 0;
		}
		plain[index1++] = ch;
	} while (ch != '\n');
	int index2 = 0;
	while (plain[index2] != '\n')
	{
		printf("%c		----->>>>>		", plain[index2]);
		printf("%c\n", alpha[index2++]);
	}



	return 0;
}