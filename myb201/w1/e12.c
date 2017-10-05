
/* 
Konu: pointer & struct
*/

#include <stdio.h>

struct Nokta {
	int x_k, y_k;
};

int main() {
	struct Nokta n1 = {1, 2};
	struct Nokta* np = & n1;

	printf("(%d, %d)\n", (*np).x_k, np->y_k);

	return 0;
}
