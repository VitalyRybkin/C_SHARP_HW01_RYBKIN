using System;

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
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

Console.Write("Enter your second number (or type 'Q'): ");
text = Console.ReadLine() ?? "";
StopExe(text);
int b = CheckInput(text);

if (a > b) Console.WriteLine($"{a} greater than {b}.");
else Console.WriteLine($"{b} greater than {a}.");