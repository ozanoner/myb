
/* 
Konu: mantiksal operatorler
*/


#include <stdio.h>

int main() {
	int i=0;
	int y=0;

	if(i && y) {
		printf("dogru\n");
	}
	else {
		printf("yanlis\n");
	}

	i=0;
	y=1;

	// ternary operator
	printf( i || y ? "dogru\n": "yanlis\n" ); 

	return 0;
}
