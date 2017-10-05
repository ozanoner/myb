
/* 
Konu: fonksiyonlar
*/


#include <stdio.h>

int ekle(int i, int j) {
	return i+j;
}

int main()  {
	int z;

	z=ekle(1, 2);
	printf("z=%d\n", z);

	int x=1, y=5;
	z=ekle(x, y);
	printf("z=%d\n", z);

	return 0;
}
