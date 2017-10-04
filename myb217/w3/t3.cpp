
#include <iostream>

class A {
public:
	virtual void test()=0;
};

class B : public A {
public:
	void test()=delete;
};

int main() {
}
