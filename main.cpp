#include <iostream>
using namespace std;

template <typename T>
class MyStorage {
private:
    int size = 0;
    int count = 0 ;
    T *array = new T[size];
    int index = 0;
    void increase_arr(){
        size += 10;
        T *new_arr = new T[size] ;
        for (int i = 0; i < count; ++i){
            new_arr[i] = array[i];
        }
        delete[] array;
        array = new_arr;
        delete[] new_arr;
        new_arr = nullptr;
    }
    void reduce(){
        /*size -= 10;
        T *new_arr = new T[size] ;
        for (int i = 0; i < count; ++i){
            new_arr[i] = array[i];
        }
        delete[] array;
        *array = *new_arr;
        delete[] new_arr;
        new_arr = nullptr;
         */
    }
    void reduced_arr(int i){
        --count;
        T new_arr[count - i];
        int old_ind = i+1;
        for(int j = 0; j < count-i; ++j){
            new_arr[j] = array[old_ind];
            old_ind++;
        }
        old_ind = 0;
        for(i; i < count; ++i){
            array[i] = new_arr[old_ind];
            ++old_ind;
        }
        //if (size - count > 30 && count != 0) this->reduce();
    }
public:
    MyStorage(){}
    MyStorage(int size){
        this->size = size + 10;
    }
    int get_count(){ return count;}
    void addObject(T new_el){ //добавляет новый элемент в конец хранилища
        if(count == size) this->increase_arr();
        array[count] = new_el;
        ++count;
    }
    void setObject(int i, T new_el){ //вставляем новый элемент в любое место в массиве
        if (!array[i]) array[i] = new_el;
        else {
            T new_arr[count - i];
            int old_ind = i;
            for(int j = 0; j < count-i; ++j){
                new_arr[j] = array[old_ind];
                old_ind++;
            }
            if(count == size) this->increase_arr();
            array[i] = new_el;
            ++count; old_ind = 0;
            for(int j = i+1; j < count; ++j){
                array[j] = new_arr[old_ind];
                old_ind++;
            }
        }
    }
    T getObject(int i){
        if (i > -1 && i < count) return array[i];
    }
    T getdelObject(int i){
        if (i > -1 && i < count){
            T ret_obj = array[i];
            this->reduced_arr(i);
            return ret_obj;
        }
    }
    T nextObj(){
        if (index < count - 1 && index >= 0){
            ++index;
            return array[index];
        };
    }
    T prevObj(){
        if (index > 0 && index < count){
            --index;
            return array[index];
        };
    }
    T curObj(){
        return array[index];
    }
    void print(T el){
        cout << el;
    }
};

class Human{
private:
    string name = "";
    int age = -1;
public:
    Human(){}
    Human(string nm, int ag){
        name = nm;
        age = ag;
    }
    Human(string nm){
        name = nm;
    }
    friend ostream& operator<<(ostream& os, const Human& man){
        if (man.age > -1){
            os << man.name << ' ' << man.age;
        } else {
            os << man.name << ' ';
        }
        return os;
    }
};

void rand_action(int d, MyStorage<int> store){
    switch (d){
        case 1:
        {
            int random = rand() % 99 + 1;
            store.addObject(random);
            break;
        }
        case 2:
        {
            int index = rand() % store.get_count();
            int random = rand() % 99 + 1;
            store.setObject(index, random);
            break;
        }
        case 3:
        {
            int index = rand() % store.get_count();
            store.getdelObject(index);
            break;
        }
        case 4:
        {
            int index = rand() % store.get_count();
            store.print(store.getObject(index));
            break;
        }
    }
}

int main() {
    MyStorage<int> storage(30);
    for(int i = 0; i < 30; ++i){
        storage.addObject(i);
    }
    storage.setObject(0,23);
    storage.getdelObject(0);
    storage.print(storage.getObject(0));
    int i = 0;
    while(storage.get_count() != i){
        storage.getdelObject(0);
    }
    cout << "\nвывод массива\n";
    i = 0;
    while (i != storage.get_count()) {
        storage.print(storage.getObject(i));
        cout << "\n";
        ++i;
    }
    MyStorage<Human> people_st;
    Human new_el("Ivan", 23);
    people_st.addObject(new_el);
    people_st.print(people_st.getObject(0));

    /*MyStorage<int> store;
    cout << "\nrandom actions\n";
    for(int i = 0; i < 100; ++i) {
        int random = rand() % 4 + 1;
        rand_action(random, store);
    }*/

    return 0;
}
