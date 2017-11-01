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

class Sira {
public:
	Sira(SiraTipi tip, int sira_no): _tip(tip), _sira_no(sira_no) { }
	bool kontrol(SiraTipi t, int s) const {
		return s==this->_sira_no && t==this->_tip;
	}
	string str() {
		return "";
	}
private:
	int _sira_no;
	SiraTipi _tip;
};


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
		return *this->_sira;
	}

private:
	int _musteri_no;
	string _adi, _soyadi;
	const Sira* _sira; 
};


class Banka {
public:
	Banka(): _gise_sirano(0), _bireysel_sirano(0),\
		_gise_sira_onu(1), _bireysel_sira_onu(1) { }

	void gise_sira_ver(Musteri* musteri) {
		Sira* s= new Sira(SiraTipi::Gise, ++this->_gise_sirano);
		this->_siralar.insert(s);
		musteri->sira_al(*s);
		this->_gise.push_back(musteri);
	}

	bool gise_islem(const Sira& sira) {
		if(sira.kontrol(SiraTipi::Gise, this->_gise_sira_onu)) {
			Musteri* m = this->_gise.front();
			cout << "Gise Islem yapiliyor: " << m->str() << endl;
			this->_gise.pop_front();
			cout << "Gise Islem tamamlandi\n";

			this->_gise_sira_onu++;
			auto it = this->_siralar.find(&sira);
			if(it!=this->_siralar.end()) {
				delete *it;
				this->_siralar.erase(it);
			}
			else 
				cout << "sira bulunamadi\n";

			return true;
		}
		else {
			cout << "hata: siranizi bekleyiniz..\n";
			return false;
		}
	}

	void bireysel_sira_ver(Musteri* musteri) {
	}
	bool bireysel_islem(const Sira& sira) {
	}
private:
	int _gise_sirano;
	int _gise_sira_onu;
	deque<Musteri*> _gise;

	int _bireysel_sirano;
	int _bireysel_sira_onu;
	deque<Musteri*> _bireysel;

	set<const Sira*> _siralar;
};

int main() {
	Banka banka;

	Musteri* ali = new Musteri(234, "ali", "yanmaz");
	Musteri* ayse = new Musteri(111, "ayse", "sonmez");

	banka.gise_sira_ver(ali);
	banka.gise_sira_ver(ayse);


	banka.gise_islem(ayse->sira_soyle());
	banka.gise_islem(ali->sira_soyle());
	banka.gise_islem(ayse->sira_soyle());
}
