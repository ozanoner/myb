
/*
Konu: Pointers
*/

#include <stdio.h>

int main() {
	int i=5;
	int* ip = &i;

	printf("%d %p\n", *ip, ip);

	i++;
	printf("%d %p\n", *ip, ip);

	(*ip)++;
	printf("%d %p\n", *ip, ip);


	return 0;
}
