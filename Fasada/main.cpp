#include <iostream>

using namespace std;

class VacuumCleanerBag {
public:
    void changeCleanerBag();
};

class Battery {
public:
    void chargeBattery();
};


class ErrorPanel {
public:
    void showError(bool x);
};



class roboticVacuumCleaner {
public:
    void turnON();
    void turnOFF();
private:
    Battery battery;
    VacuumCleanerBag vacuumCleanerBag;
    ErrorPanel errorPanel;
};


void Battery::chargeBattery() {
    cout<<"The battery is charging\n";
}


void ErrorPanel::showError(bool x) {
    if(x==1){
        cout<<"ERROR!!!\n";
    }
}

void roboticVacuumCleaner::turnON() {
    cout<<"Robot is cleaning\n";
}

void roboticVacuumCleaner::turnOFF() {
    cout<<"Robot is off\n";
}

void VacuumCleanerBag::changeCleanerBag() {
    cout<<"Bag changed\n";
}


int main() {
    roboticVacuumCleaner robot;
    robot.turnON();
    robot.turnOFF();
    return 0;
}
