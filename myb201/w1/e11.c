
/* 
Konu: pointer
*/

#include <stdio.h>

int main() {
	int i[5] = {10, 2, 3, 4, 50};
	int* ip = i;

	for(int idx=0; idx<5; ip++, idx++)
		printf("%d ", *ip);

	return 0;
}
