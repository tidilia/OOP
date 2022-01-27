#include <iostream>
#include <string>
using namespace std;

class GrandParent {
protected:
    string str = "GrandParent";
public:
    virtual string get_str(){
        return "GrandParent";
    }
    void greeting(){
        cout << "Hello, Granny!\n";
    }
};

class Parent: public GrandParent{
public:
    virtual string get_str() override{
        str = "Parent";
        return str;
    }
    void greeting(){
        cout << "Hello, Mom and Dad!\n";
    }
};

class Child: public Parent{
public:
    string get_str() override{
        str = "Child";
        return get_str();
    }
    void greeting(){
        cout << "Hello, Child!\n";
    }
};

int main() {
    GrandParent Granny = GrandParent(); //создаем объект grandparent
    Parent parent = Parent(); //создаем объект parent
    GrandParent *parent_ptr = &parent; //помещаем объект parent в указатель родительского типа

    cout << "Функция greeting без ключевого слова virtual:\n";
    cout << "Для объекта типа grandparent:\n";
    Granny.greeting();
    cout << "Для объекта типа parent:\n";
    parent.greeting();
    cout << "Для объекта типа parent в указателе типа grandparent:\n";
    parent_ptr->greeting();

    cout << "\nРабота virtual функции get_str:\n";
    cout << "Для объекта типа grandparent:\n" << Granny.get_str() << "\n";
    cout << "Для объекта типа parent:\n" << parent.get_str() << "\n";
    cout << "Для объекта типа parent в указателе типа grandparent:\n" << parent_ptr->get_str();
    return 0;
}
