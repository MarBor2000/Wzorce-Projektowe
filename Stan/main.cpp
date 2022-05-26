#include <iostream>

using namespace std;

class Stan {
public:
    void virtual zrob() = 0;
};

class Szklanka {
public:
    void napelnij();
    void wylej();
    Stan* stan;
    Szklanka(int pojemnosc);
private:
    int pojemnosc;
};



class Pusta : public Stan {
    void Pelna(Szklanka* szklanka);
    void zrob(){
        cout<<"Szklanka jest pusta\n";
    }
};

class Pelna : public Stan {
    void Pusta(Szklanka* szklanka);
    void zrob(){
        cout<<"Szklanka jest pelna\n";
    }
};



void Szklanka::napelnij() {
    this->stan = new Pelna();
    cout<<"Napelnanie szklanki\n";
}

void Szklanka::wylej() {
    this->stan = new Pusta();
    cout<<"Wylewanie wody ze szklanki\n";
}

Szklanka::Szklanka(int pojemnosc) {
    this->pojemnosc=pojemnosc;
    this->stan=new Pusta();
}

int main() {
    Szklanka* szklanka = new Szklanka(200);
    szklanka->stan->zrob();
    szklanka->napelnij();
    szklanka->stan->zrob();
    szklanka->wylej();
    szklanka->stan->zrob();
    return 0;
}
