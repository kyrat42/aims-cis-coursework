// Kyra Thomas
// 9/29/2023
// Sales Bar Chart

#include <iostream>
using namespace std;

int main()
{
    int store1, store2, store3, store4, store5;

    // get input
    cout << "Enter today's sales for store 1: ";
    cin >> store1;

    cout << "Enter today's sales for store 2: ";
    cin >> store2;

    cout << "Enter today's sales for store 3: ";
    cin >> store3;

    cout << "Enter today's sales for store 4: ";
    cin >> store4;

    cout << "Enter today's sales for store 5: ";
    cin >> store5;

    // output
    cout << "SALES BAR CHART";

    // store 1
    cout << "\nStore 1: ";
    for (int i = 0; i < (store1 / 100); i++)
        cout << "*";

    // store 2
    cout << "\nStore 2: ";
    for (int i = 0; i < (store2 / 100); i++)
        cout << "*";

    // store 3
    cout << "\nStore 3: ";
    for (int i = 0; i < (store3 / 100); i++)
        cout << "*";

    // store 4
    cout << "\nStore 4: ";
    for (int i = 0; i < (store4 / 100); i++)
        cout << "*";

    // store 5
    cout << "\nStore 5: ";
    for (int i = 0; i < (store5 / 100); i++)
        cout << "*";
}