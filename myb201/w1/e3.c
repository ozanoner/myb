
/* 
Konu: matematik operatorler
*/

#include <stdio.h>

int main() {
	float f=5;
	float f2=4;
	float sonuc;

	sonuc=f-f2;
	printf("%.2f\n", sonuc);
	printf("%.2f\n", f+f2);
	printf("%.2f\n", f*f2);
	printf("%.2f\n", f/f2);

	printf("%d\n", 5%4);

	return 0;
}
