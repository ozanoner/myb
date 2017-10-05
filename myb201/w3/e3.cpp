/*
Konu: namespace
*/

#include <iostream>
using namespace std;

// ilk namespace
namespace ilk_bolge {
   void func(){
      cout << "ilk_bolge deki fonksiyon" << endl;
   }
}

// second name space
namespace ikinci_bolge {
   void func(){
      cout << "ikinci_bolge deki fonksiyon" << endl;
   }
}

int main () {
 
   // ilk bolgedeki fonksiyonun cagrilmasi
   ilk_bolge::func();
   
   // ikinci_bolgedeki fonksiyonun cagrilmasi
   ikinci_bolge::func(); 

   return 0;
}