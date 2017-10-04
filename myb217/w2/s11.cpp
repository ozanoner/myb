
#include <iostream>
#include <memory>

class A {
	public:
		A() { std::cout << "A ctor\n"; }
		~A() { std::cout << "B dtor\n"; }
};

int main() {
	{
		auto sp = std::shared_ptr<A>(new A);
		std::cout << sp.use_count() << std::endl;
		{
			auto sp2 = sp;
			std::cout << sp.use_count() << std::endl;
		}
		std::cout << sp.use_count() << std::endl;
	}
}
