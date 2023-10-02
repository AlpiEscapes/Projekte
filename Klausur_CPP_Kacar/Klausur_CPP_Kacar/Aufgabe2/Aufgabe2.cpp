// Aufgabe2.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
#include <string>

void pruefziffer(int* arr);
void pruefziffertest(int* arr);

int main()
{
    int* dyn = new int;
    cout << "Bitte Zahl angeben \n";
    cin >> *dyn;
    
        pruefziffer(dyn);
        pruefziffertest(dyn);
}

void pruefziffer(int* arr) {

    string s = to_string(*arr);
    if (s.length() <= 10) {
        int tmp = 0;
        for (int i = 0; i < s.length(); i++) {
            tmp += (int)s.at(i) - 48;
        }
        int tmp2 = 0;
        while (tmp % 10 != 0) {
            tmp2++;
            tmp++;
        }

        s += to_string(tmp2);
        *arr = stoi(s);
        cout << "die Neue Zahl ist " << s << " die " << tmp2 << " wurde rangehangen \n";
    }
    else {
        cout << "Bitte eine zahl die kleiner als 11 ist eingeben \n";
    }
}

void pruefziffertest(int* arr) {

    string s = to_string(*arr);
    if (s.length() <= 10) {
        int tmp = 0;
        for (int i = 0; i < s.length() - 1; i++) {
            tmp += (int)s.at(i) - 48;
        }
        int tmp2 = 0;
        while (tmp % 10 != 0) {
            tmp2++;
            tmp++;
        }

        if (s.at(s.length() - 1) == (char)tmp2 + 48) {
            s += to_string(tmp2);
            *arr = stoi(s);
            cout << "Das ist eine Pruefzahl \n";
        }
        else {
            cout << "keine Pruefzahl \n";
        }
    }
    else {
        cout << "Bitte eine zahl die kleiner als 11 ist eingeben \n";
    }
}
