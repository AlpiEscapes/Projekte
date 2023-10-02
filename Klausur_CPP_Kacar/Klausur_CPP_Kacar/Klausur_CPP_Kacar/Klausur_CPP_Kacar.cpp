#include <iostream>
#include "Header.h"
#include <string>
#include <math.h>

//Alpaslan Kacar bbm2h19akc

using namespace std;

int main()
{
    
	datum d;
	datum* da = &d;

	bool re = datumLesen(da);
	if (re == false) {
		cout << "bitte geben sie ein gueltiges Datum ein \n";
	}

	ausgabe(da);

}

bool datumLesen(datum* d) {
	int pruefung[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		

	cout << "Tag: " << endl;
	cin >> d[0].day;

	cout << "Monat: " << endl;
	cin >> d[0].month;

	cout << "Jahr: " << endl;
	cin >> d[0].year;

	if (stoi(d[0].year) % 4 == 0) {
		if (stoi(d[0].year) % 100 != 0 && stoi(d[0].year) % 400 == 0) {
			pruefung[1]++;
		}

	}
	 
	if (stoi(d[0].day) > pruefung[stoi(d[0].month) - 1])
		return false;
	if (stoi(d[0].month) > 12)
		return false;


	

	return true;
}

void ausgabe(datum* d){
	cout << d->day << "." << d->month << "." << d->year << endl;
}

