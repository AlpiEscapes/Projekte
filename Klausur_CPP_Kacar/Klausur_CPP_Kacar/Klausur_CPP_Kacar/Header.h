#pragma once
struct datum {

	std::string day;
	std::string month;
	std::string year;

};
bool datumLesen(datum* d);
void ausgabe(datum* d);
