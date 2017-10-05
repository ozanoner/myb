
/*
Konu: typedef tip tanimlama
*/

#include <stdio.h>
#include <stdlib.h>
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

/* liste operasyonlari */

// liste elemani
typedef struct _KitapEleman {
	Kitap* kitap;
	struct _KitapEleman* sonraki;
} KitapEleman;

// kitap listesi
KitapEleman* baslangic;

// listeye kitap ekler
void kitap_ekle(Kitap* kp) {
	KitapEleman* ke;
	ke = baslangic;
	baslangic = (KitapEleman*)malloc(sizeof(KitapEleman));
	baslangic->kitap=kp;
	baslangic->sonraki=ke;
}

void kitap_liste_yazdir() {
	KitapEleman* ke=baslangic;
	while(ke!=NULL) {
		kitap_yazdir(*(ke->kitap));
		ke = ke->sonraki;
	}
}

// listedeki kitaplarin hafizasini birakir
// tekrarlayan fonksiyon
void kitap_liste_birak(KitapEleman* ke) {
	if(ke==NULL)
		return;
	KitapEleman* se;
	se = ke->sonraki;
	free(ke);
	kitap_liste_birak(se);
}

int main() {
	baslangic = NULL;
	Kitap k1=kitap_olustur("The C Programming Language",\
		"Brian W. Kernighan");
	kitap_ekle(&k1);

	Kitap k2=kitap_olustur("The C++ Programming Language",\
		"Bjarne Stroustrup");
	kitap_ekle(&k2);

	kitap_liste_yazdir();

	kitap_liste_birak(baslangic);

	return 0;
}
