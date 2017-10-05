
/*
Konu: typedef tip tanimlama
*/

#include <stdio.h>
#include <string.h>

// kitap numarasi ureticisi
int yeni_no=0;

// kitap tipi tanimlama
typedef struct _Kitap {
	int no;
	char adi[50];
	char yazari[50];
} Kitap;

// yeni kitap olusturur
Kitap kitap_olustur(char* adi, char* yazari) {
	Kitap yeni_kitap;
	yeni_kitap.no = ++yeni_no;
	strcpy(yeni_kitap.adi, adi);
	strcpy(yeni_kitap.yazari, yazari);
	return yeni_kitap;
}

// kitap bilgilerini ekrana yazdirir
void kitap_yazdir(Kitap kitap) {
	printf("------------\n");
	printf("No: %d\nAdi: %s\nYazar: %s\n",\
		kitap.no, kitap.adi, kitap.yazari);	
}

int main() {
	Kitap k;
	k = kitap_olustur("The C Programming Language",\
		"Brian W. Kernighan");
	kitap_yazdir(k);

	k = kitap_olustur("The C++ Programming Language",\
		"Bjarne Stroustrup");
	kitap_yazdir(k);

	return 0;
}
