using System;

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
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

//Setting the range of nums
Console.Write("Enter number to set your range of numbers: ");
string text = Console.ReadLine() ?? "";
int interval_num = CheckInput(text);
int interval_start = 1;

if (interval_num == 1) Console.WriteLine("No even nums in this range!");

while (interval_start <= interval_num) {
    if (interval_start % 2 == 0) {
        Console.WriteLine(interval_start);
    }
    interval_start ++;
}
