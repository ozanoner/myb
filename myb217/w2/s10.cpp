
#include <iostream>
#include <memory>

class A {
	public:
	A() { std::cout << "A ctor\n"; }
	~A() { std::cout << "A dtor\n"; }
};

std::unique_ptr<A> foo(std::unique_ptr<A> a) {
	return a;
}

int main() {
	std::unique_ptr<A> ua(new A);
	auto ub = foo(std::move(ua));
	// auto ub = foo(ua); // HATA
}
