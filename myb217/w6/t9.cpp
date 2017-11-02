/*
 * DEQUE ve SET ornegi: Banka sirasi
 * Baska STL kutu: QUEUE
 */

#include <iostream>
#include <deque>
#include <set>
#include <string>
#include <functional>

using namespace std;

enum class SiraTipi {
	Gise,
	Bireysel
};

// Sira olusturulduktan sonra degistirilemez.
class Sira {
public:
	Sira(SiraTipi tip, int sira_no): _tip(tip), _sira_no(sira_no) { }
// banka gorevlisi kullanimi icin
	bool kontrol(SiraTipi t, int s) const {
		return s==this->_sira_no && t==this->_tip;
	}
// guncellenmesi gerekiyor
	string str() {
		return "";
	}
private:
	int _sira_no;
	SiraTipi _tip;
};

// banka musterisi
// gise veya musteri temsilcisinden sira alir
// soruldugunda aldigi sirayi soyler
class Musteri {
public:
	Musteri(int no, const string& adi, const string& soyadi):
		_musteri_no(no), _adi(adi), _soyadi(soyadi) { }
	string str() {
		return "No: "+to_string(this->_musteri_no)+\
			" Adi: "+this->_adi+" Soyadi: "+this->_soyadi;
	}
	void sira_al(const Sira& s) {
		this->_sira = &s;
	}
	const Sira& sira_soyle() const {
		cout << ">> Ben " << this->_adi << ". islem yapmak istiyorum" << endl;
		return *this->_sira;
	}

private:
	int _musteri_no;
	string _adi, _soyadi;
	const Sira* _sira; 
};

// banka islemleri
// 1- musteriye sira verir 
// 2- gise islemi veya bireysel islem yapar
class Banka {
public:
	Banka(): _gise_sirano(0), _bireysel_sirano(0),\
		_gise_sira_onu(1), _bireysel_sira_onu(1) { }

	// yeni sira numarasi olusturup gelen musteriye verir
	// musteriyi de siraya ekler
	void gise_sira_ver(Musteri* musteri) {
		Sira* s= new Sira(SiraTipi::Gise, ++this->_gise_sirano);
		this->_siralar.insert(s);
		musteri->sira_al(*s);
		this->_gise.push_back(musteri);
		cout << "[bilgi]: yeni sira no verildi (" << this->_gise_sirano << ")\n";
	}

	// gelen musterinin sirasini kontrol edip
	// sira ondaysa islem yapar
	bool gise_islem(const Sira& sira) {
		// belirtilen sira numarasi, siranin basinda mi?
		if(sira.kontrol(SiraTipi::Gise, this->_gise_sira_onu)) {
			// musteri kabul edildi
			Musteri* m = this->_gise.front();
			cout << ">> Hosgeldiniz\n";
			cout << "[bilgi]: Gise Islem yapiliyor: " << m->str() << endl;
			// islem yapildi ve siradan cikarildi
			this->_gise.pop_front();
			cout << "[bilgi]: Gise Islem tamamlandi\n";

			// sira onu bir sonraki numarada
			this->_gise_sira_onu++;

			// sira bileti listeden cikarildi
			auto it = this->_siralar.find(&sira);
			if(it!=this->_siralar.end()) {
				delete *it;
				this->_siralar.erase(it);
			}
			else 
				cout << "[hata]: sira bulunamadi\n";

			return true;
		}
		else {
			cout << ">> Siranizi bekleyiniz lutfen..\n";
			return false;
		}
	}

	void bireysel_sira_ver(Musteri* musteri) {
	}
	bool bireysel_islem(const Sira& sira) {
	}
private:
	// giseden verilen en son sira-no
	int _gise_sirano;
	// siranin en basindaki numara
	int _gise_sira_onu;
	// musteri sirasi
	deque<Musteri*> _gise;

	int _bireysel_sirano;
	int _bireysel_sira_onu;
	deque<Musteri*> _bireysel;

	// verilen siralarin tutuldugu set
	set<const Sira*> _siralar;
};

int main() {
	Banka banka;

	Musteri* ali = new Musteri(234, "ali", "yanmaz");
	Musteri* ayse = new Musteri(111, "ayse", "sonmez");

	// once ali sonra ayse sira aldi
	banka.gise_sira_ver(ali);
	banka.gise_sira_ver(ayse);


	// ayse once islem yapamaz, sirasini beklemeli
	banka.gise_islem(ayse->sira_soyle());

	banka.gise_islem(ali->sira_soyle());
	banka.gise_islem(ayse->sira_soyle());


	// gorev: sira biletlerini bastirma
	// gorev: bireysel islemlerin kodlanmasi
	// gorev: bireysel islemlerin sirasina musteri ekleme ve islemler
}



