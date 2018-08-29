	//this program computes the area of a circle
#include <iostream>
using namespace std;

int main()
{
	//constant
	const double pi = 3.14159;
	//variable definition
	double radius, area;
	char ch;

		cout << "Enter Radius Value Here";
		cin >> radius;

		area = pi * (radius*radius);

		cout << "The Area of This Circle Is:"
			<< area << endl;

		system("pause");
		return 0;
}