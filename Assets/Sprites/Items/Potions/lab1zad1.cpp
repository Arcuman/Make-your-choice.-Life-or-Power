﻿#include "pch.h"
#include <stdio.h>
#include <iostream>
using namespace std;
int dopi, dopc, dopb;
int funplus(int n, int m) {
	if (0 < m)
		return funplus(n + 1, m - 1);
	else
		return n;
}

int funminus(int n, int m) {
	if (0 < m)
		return funminus(n - 1, m - 1);
	else
		return n;
}

int multi(int n, int m) {
	if (0 == m)
		return 0;
	else if (1 == m)
		return n;
	else
		return funplus(multi(n, m - 1), n);
}

int power(int n, int m) {
	if (0 == m)
		return 1;
	else
		return multi(n, power(n, m - 1));
}

int zad1() {
	int m, n;
	cout << "n: ";
	cin >> n;
	cout << "m: ";
	cin >> m;
	if ((0 <= n) && (0 <= m))
	{
		cout << "plus = " << funplus(n, m) << endl;
		cout << "minus = " << funminus(n, m) << endl;
		cout << "multi = " << multi(n, m) << endl;
		cout << "power = " << power(n, m) << endl;
	}
	return 0;
}

int calc(int n, int x)
{
	if (n == 0)
		return 0;
	else if (n == 1)
		return 2 * x;
	else
		return ((((2 * n) / (n - 1))*calc(n - 1, x)) + ((n - 1) / 2 * n)*calc(n - 2, x));
}

int zad2()
{
	int n;
	int x;
	cout << "n: ";
	cin >> n;
	cout << "x: ";
	cin >> x;
	cout << calc(n, x) << endl;
	return 0;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int choose;
	do
	{
		cout << "Выберете задание:\n1) Задание 1\n2) Задание 2\n3) Доп.Задание\nВаш выбор: ";
		cin >> choose;
		switch (choose)
		{
		case 1:
		{
			zad1();
			break;
		}
		case 2:
		{
			zad2();
			break;
		}
		default:
		{
			return 0;
			cout << "Неверный ввод";
		}
		}
	} while (1);
}



