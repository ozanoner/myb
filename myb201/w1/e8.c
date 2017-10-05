
/* 
Konu: diziler
*/


#include <stdio.h>


int main()  {
	int i[5];

	i[0]=1;
	i[1]=3;
	i[2]=5;
	i[3]=9;
	i[4]=-1;

	for(int idx=0; idx<5; idx++) {
		printf("%d ", i[idx]);
	}
	printf("\n");

	return 0;
}
