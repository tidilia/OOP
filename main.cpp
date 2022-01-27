#include <iostream>
#include "memory"
using namespace std;

class Base{

    int val = 0;
public:
    Base() {
        val = 0;
        cout << "Base()\n";
    };

    Base(Base *obj) {
        setVal(obj->getVal());
        cout << "Base(*obj)\n";
    };

    Base(Base &obj) {
        setVal(obj.getVal());
        cout << "Base(&obj)\n";
    };


    ~Base() {
        cout << "~Base()\n";
    }

    int getVal() const;

    void setVal(int val);;
};

class Desc: public Base{
public:
    Desc() {};

    Desc(Desc *obj) {
        setVal(obj->getVal());
        cout << "Desc(*obj)\n";
    };

    Desc(Desc &obj) {
        setVal(obj.getVal());
        cout << "Desc(&obj)\n";
    };

    ~Desc() {
        cout << "~Desc()";
    }
};

void func1(Base obj) {
    cout << "func1(obj). value = " << obj.getVal() << "\n";
};

void func2(Base *obj) {
    cout << "func2(*obj). value = " << obj->getVal() << "\n";
};

void func3(Base &obj) {
    cout << "func1(&obj). value = " << obj.getVal() << "\n";
};



Base* func1() {
    cout << "func1\n";
    Base obj;
    obj.setVal(5);
    return &obj;
};

Base* func2() {
    cout << "func2\n";
    Base *ptr = new Base();
    return ptr;
};

Base& func3() {
    cout << "func3\n";
    Base *ptr = new Base();
    return *ptr;
};

int Base::getVal() const {
    return val;
}

void Base::setVal(int val) {
    Base::val = val;
}

class A {
public:
    A() { cout << "A()" << endl; }
    ~A() { cout << "~A()" << endl; }
};

class B : public A {
public:
    B() { cout << "B()" << endl; }
    ~B() { cout << "~B()" << endl; }
};


int main() {

    A * pA = new B;
    delete pA;

    Base el1;
    el1 = func1();
    Base *el2 = func2();
    Base *el3 = &func3();
    Desc *d = new Desc();
    delete d;

    int *ptr1 = new int(5);
    unique_ptr<int> up(new int(5));
    unique_ptr<int> up2(ptr1);
    //unique_ptr<int> up2(up); так нельзя так как это уникальные указатели
    int *ptr2 = up2.get();
    up2.release(); //только up2 станет пустым
    //up2.reset() сотрет данные в целом и все указатели станут пустыми

    shared_ptr<string> sharedPtr1(new string("hello"));
    shared_ptr<string> sharedPtr2(sharedPtr1);


    cout << "\n";
    return 0;
}
