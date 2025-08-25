#include <iostream>
using namespace std;

int main() {
    double num1, num2;
    char operation;

    // Ask the user to input two numbers
    cout << "Enter the first number: ";
    cin >> num1;

    cout << "Enter the second number: ";
    cin >> num2;

    // Ask the user to choose an operation
    cout << "Choose an operation (+ for addition, - for subtraction, * for multiplication): ";
    cin >> operation;

    // Perform the chosen operation
    if (operation == '+') {
        cout << "Result: " << (num1 + num2) << endl;
    }
    else if (operation == '-') {
        cout << "Result: " << (num1 - num2) << endl;
    }
    else if (operation == '*') {
        cout << "Result: " << (num1 * num2) << endl;
    }
    else {
        cout << "Invalid operation." << endl;
    }

    return 0;
}