
/*
 * VECTOR ORNEGI: Kitap yigini
 * Baska STL kutu: STACK
 */

#include <iostream>
#include <vector>
#include <sstream>

using namespace std;

class Kitap {
public:
	Kitap(string&& adi, string&& yazari): _adi(adi), _yazari(yazari) {
		this->_id=++Kitap::_id_ureticisi;
	}
	~Kitap() { cout << "!! kitap silindi: " << this->str(); }
	string str() const {
		stringstream ss;
		ss << "Kitap no: "<<this->_id<<" Adi: "<<this->_adi<<\
			" Yazari: "<<this->_yazari;
		return ss.str();
	}

private:
	string _adi, _yazari;
	int _id;
	static int _id_ureticisi;
};
int Kitap::_id_ureticisi=0;



class KitapYigini {
public: 
	// yigina en fazla kapasite kadar kitap ekleyebilirim
	// degilse yikilacak
	KitapYigini(int kapasite): _kapasite(kapasite) { }
	
	// yigina kitap ekle
	bool ekle(Kitap* kitap) {
		if(this->_yigin.size()<this->_kapasite) {
			// en uste ekle
			this->_yigin.push_back(kitap);
			return true;
		}
		else {
			return false;
		}
	}
	
	// yigindan kitap al
	Kitap* al() {
		if(this->_yigin.size()==0)
			return nullptr;
		// en ustteki kitap
		Kitap* ptr = this->_yigin.back();
		// ustteki kitabi yigindan cikar
		this->_yigin.pop_back();
		// elemani don
		return ptr;
	}

	// en ustteki kitabi baskasina ver
	bool ver() {
		if(this->_yigin.size()==0)
			return false;
		// kitabi yigindan cikar
		delete this->_yigin.back();
		this->_yigin.pop_back();
	}

	// en ustteki kitaba bak
	string bak() {
		if(this->_yigin.size()==0)
			return string();
		return this->_yigin.back()->str();
	}

	// yiginda kac kitap var
	int kac_tane() {
		return this->_yigin.size();
	}

	// yiginla ilgili bilgiler
	void bilgi() {
		cout << "kitap sayisi: " << this->kac_tane() << endl;
		cout << "en ustte: " << this->bak() << endl;
		cout << "---------\n";
	}
private:
	vector<Kitap*> _yigin;
	int _kapasite;
};


int main() {
	KitapYigini yigin1 (5);
	KitapYigini yigin2 (5);

	yigin1.ekle(new Kitap("kitap1", "yazar1"));
	yigin1.ekle(new Kitap("kitap2", "yazar2"));
	yigin1.ekle(new Kitap("kitap3", "yazar3"));


	Kitap* k = yigin1.al();
	cout << k->str() << endl;
	yigin2.ekle(k);

	cout << "Yigin 1 bilgi:\n";
	yigin1.bilgi();
	cout << "Yigin 2 bilgi:\n";
	yigin2.bilgi();

	// Gorev: diger kitaplari da yigin-2 ye aktar
	// Gorev: yigin-2deki en ustteki kitabi baskasina ver ve sonra yigin-1e aktar
}





