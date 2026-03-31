
#include<iostream>

#include"func.h"

void fff();

void fff999()
{
	std::cout << "fff999" << std::endl;
}

void fff999_1()
{
	std::cout << "fff999_1" << std::endl;
}

int main()
{
	print();
	fff();
}

void fff()
{
	std::cout << "FFF" << std::endl;
}