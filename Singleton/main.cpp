#include <iostream>
#include <string>


using namespace std;


class PlanTreningowy {
public:
    void dodajCw();
    void usunCw();
    void pokazPlan();
    static PlanTreningowy& getInstance() {
        static PlanTreningowy instance;
        return instance;
    }
private:
    string plan;
    PlanTreningowy(){};
};

void PlanTreningowy::dodajCw() {
    string cwiczenie;
    while(cwiczenie!="0") {
        cin >> cwiczenie;
        if(cwiczenie!="0") {
            plan += cwiczenie;
            plan += " ";
        }
    }
}

void PlanTreningowy::usunCw() {
    int nr,nr2;
    cin>>nr;
    cin>>nr2;
    plan.erase(nr,nr2);
}


void PlanTreningowy::pokazPlan() {
    cout<<plan<<"\n";
}


int main() {
    PlanTreningowy::getInstance().dodajCw();
    PlanTreningowy::getInstance().pokazPlan();
    PlanTreningowy::getInstance().usunCw();
    PlanTreningowy::getInstance().pokazPlan();
    return 0;
}
