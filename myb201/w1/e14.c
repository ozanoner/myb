
/* 
konu: call-by-value / call-by-reference
*/

#include <stdio.h>

void yazdir_degerle(int i) {
	printf("yazdir_degerle: %d\n", i++);
}

void yazdir_referansla(int* ip) {
	printf("yazdir_referansla: %d\n", (*ip)++);
}

int main() {
	int i=1;
	yazdir_degerle(i);
	printf("main: %d\n", i);
	yazdir_referansla(&i);
	printf("main: %d\n", i);

	return 0;
}
