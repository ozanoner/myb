
#include <iostream>

using namespace std;

template <typename ...Args>
auto wrapLog(auto f)
{
    return [f](Args... args){
        cout << "start" << endl;
        f(args...);
        cout << "finish" << endl;
    };
}

void foo() {
	cout << "in foo" << endl;
}

template <typename T>
void goo(T i) {
	cout << i << endl;
}

int main() {
	auto loggedFoo = wrapLog(foo);
	loggedFoo();

	auto loggedGoo = wrapLog(goo<int>);
	loggedGoo();
}
