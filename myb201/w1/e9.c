/*
Konu: struct - yapilar
*/

#include <stdio.h>

struct Nokta {
	int x_k;
	int y_k;
};

struct Cizgi {
	int x1_k;
	int y1_k;
	int x2_k;
	int y2_k;
};

struct Cizgi2 {
	struct Nokta n1;
	struct Nokta n2;
};


struct Cizgi cizgiYap(struct Nokta n1, struct Nokta n2) {
	struct Cizgi c1 = {n1.x_k, n1.y_k, n2.x_k, n2.y_k};
	return c1;
}

void printCizgi(struct Cizgi c1) {
	printf("(%d, %d) - (%d, %d)",\
		c1.x1_k, c1.y1_k, c1.x2_k, c1.y2_k);
}

void printCizgi2(struct Cizgi2 c1) {
	printf("(%d, %d) - (%d, %d)",\
		c1.n1.x_k, c1.n1.y_k, c1.n2.x_k, c1.n2.y_k);
}

int main() {

	struct Nokta nokta1 = {1, 1};
	struct Nokta nokta2 = {3, 3};

	struct Cizgi cizgi1 = cizgiYap(nokta1, nokta2);
	printCizgi(cizgi1);

	printf("\n");

	struct Cizgi2 c2 = { nokta1, nokta2 };
	printCizgi2(c2);

	return 0;
}
