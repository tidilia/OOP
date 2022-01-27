#include <iostream>
#include <typeinfo>
using namespace std;


class Base {
protected:
    void second_method(){
        cout << "Base::second method\n";
    }
public:
    virtual string classname(){
        return "Base";
    }
    virtual bool isA(string classname){
        if(classname == "Base") return true;
        else return false;
    }
    void first_method(){
        cout << "first_method -> ";
        second_method();
    }
    virtual void NameOf(){ // Virtual function.
        cout << "Base::NameOf\n";
    }
    void InvokingClass(){  // Nonvirtual function.
        cout << "Invoked by Base\n";
    }
    virtual ~Base(){
        cout << "Base's destructor\n";
    }
};

class Derived : public Base {
protected:
    void second_method(){
        cout << "Derived::second_method\n";
    }
public:
    string classname() override;
    bool isA(string classname) override;
    void NameOf() override;   // Virtual function.
    void InvokingClass();   // Nonvirtual function.
    ~Derived() override;
};


string Derived::classname() {
    return "Derived";
}

bool Derived::isA(string classname) {
    return((classname == "Derived") || Base::isA(classname));
}

void Derived::NameOf() {
    cout << "Derived::NameOf\n";
}

void Derived::InvokingClass() {
    cout << "Invoked by Derived\n";
}

Derived::~Derived() noexcept {
    cout << "Derived's destructor\n";
}

class Point {
protected:
    int x;
    int y;
public:
    Point() {
        x = 0;
        y = 0;
        printf("Point()\n");
    }
    virtual void Draw(){
        cout << x << " " << y;
    }
    ~Point(){
        printf("x = %d, y = %d\n", x, y);
        printf("~Point()\n");
    }
};

class ColoredPoint: public Point{
protected:
    int Color;
public:
    void Draw() override{
        cout << x << " " << y << " " << Color;
    }
};

class C: public Base{};
class D: public C{};
class Other{ virtual void fooo(){};};


int main() {
    // Declare an object of type Derived.
    Derived aDerived;

    cout<<"\nПроверки на принадлежность типам\n" << "Принадлежит ли объект aDerived классу Base?\n" << "Проверка classname() -> ";
    if (aDerived.classname() == "Base") cout << "Да.\n";
    else cout << "Нет.\n";
    cout<< "Принадлежит ли объект aDerived классу Base?\n" << "Проверка isA() -> ";
    if (aDerived.isA("Base")) cout << "Да.\n";
    else cout << "Нет.\n";
    cout << "Принадлежит ли объект aDerived классу Derived?\n" << "Проверка isA() -> ";
    if (aDerived.isA("Derived")) cout << "Да.\n";
    else cout << "Нет.\n";

    // Declare two pointers, one of type Derived * and the other
    //  of type Base *, and initialize them to point to aDerived.
    Derived *pDerived = &aDerived;
    Base    *pBase    = &aDerived;

    // Call the functions.
    cout << "\nДемонстрация работы виртуальных и невиртуальных методов с помощью указателей разного типа\n";
    pBase->NameOf();           // Call virtual function.
    pBase->InvokingClass();    // Call nonvirtual function.
    pDerived->NameOf();        // Call virtual function.
    pDerived->InvokingClass(); // Call nonvirtual function.
    aDerived.first_method();

    cout << "\nВиртуальный деструктор для Derived\n";
    {
        Derived newDerived;
    }



    cout << "\nБезопасное приведение типов с помощью dynamic_cast\n";
    D *pd = new D;
    C *pc = dynamic_cast<C*>(pd);
    cout << typeid(pc).name() << endl; //Type: C
    Base *pb = dynamic_cast<Base*>(pd);
    cout << typeid(pb).name() << "\n"; //Type: Base

    //Нельзя производить преобразование вниз по иерархии если базовый класс не содержит virtual
    C* pc2 = dynamic_cast<C*>(pb);
    cout << typeid(pc2).name() << endl; //Type: C

    //Проверка класса во время выполнения
    Other *otherptr = new Other();
    if(dynamic_cast<Base*>(otherptr))
        cout << "Base\n";
    else if(dynamic_cast<Other*>(otherptr))
        cout << "Other\n";

    ColoredPoint *p = new ColoredPoint;
    Point *p2 = dynamic_cast<Point*>(p);
    p2->Draw();

}
