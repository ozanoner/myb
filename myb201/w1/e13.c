
/*
Konu: dynamic memory allocation
*/

#include <stdio.h>
#include <stdlib.h> // hafiza yonetimi fonksiyonlari

struct Nokta {
	int x_k, y_k;
};

int main() {
	struct Nokta* np;

	np = (struct Nokta*)malloc(sizeof(struct Nokta));
	np->x_k=1;
	np->y_k=2;

	printf("(%d, %d)\n", np->x_k, np->y_k);

	free(np);

	return 0;
}
