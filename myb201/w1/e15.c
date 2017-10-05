/* 
Konu: string
*/

#include <stdio.h>
#include <string.h>

int main() {
	char s1[20] = {'t','e','s','t',0};
	char s2[] = {'d','e','n','e','m','e',0};
	char s3[] = "string test";

	char *cp = s3;

	printf("%s %d\n", s1, strlen(s1));
	printf("%s %d\n", s2, strlen(s2));
	printf("%s %d\n", s3, strlen(s3));
	printf("%s\n", cp);

	// s2 yi s1 e kopyalar
	printf("\nstrcpy:\n");
	strcpy(s1, s2);
	printf("%s %d\n", s1, strlen(s1));

	
	// s3 u s1 e ekler
	printf("\nstrcat:\n");
	strcat(s1, s3);
	printf("%s %d\n", s1, strlen(s1));

	printf("\nstrcmp:\n");
	printf("s1: %s\n", s1);
	s2[0]='a';
	printf("s2: %s\n", s2);
	printf("s1-s1 %d\n", strcmp(s1, s1));
	printf("s1-s2 %d\n", strcmp(s1, s2));
	printf("s2-s1 %d\n", strcmp(s2, s1));

	return 0;
}
