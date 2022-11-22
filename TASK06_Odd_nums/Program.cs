using System;

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();

// Function checks whether the input correct or not
static int CheckInput (string text) {
    int number;
    while (true) {
        if (text == "Q") Environment.Exit(0);
        if (int.TryParse(text, out int num)) {
            number = num;
            break;
            }
        else {
            Console.WriteLine("This is not an int! ");
            Console.Write("Try again or type 'Q': ");
            text = Console.ReadLine() ?? "";
        }
    }   
return number;
}

//Function stops an execution code by a user challenge
static void StopExe (string text) {
    if (text == "Q") Environment.Exit(0); 
}

Console.Write("Enter your first number (or type 'Q'): ");
string text = Console.ReadLine() ?? "";
StopExe(text);
int a = CheckInput(text);

if (a % 2 == 0) Console.WriteLine($"{a} is an EVEN number.");
else Console.WriteLine($"{a} is an ODD number.");