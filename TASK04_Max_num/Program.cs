using System;
using System.Windows.Input;

/*
Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
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

// HAND INPUT VERSION

Console.WriteLine("HAND INPUT VERSION... Press any key to continue ->\n");
Console.ReadKey(true);

Console.Write("Enter your first number (or type 'Q'): ");
string text = Console.ReadLine() ?? "";
StopExe(text);
int a = CheckInput(text);

Console.Write("Enter your second number (or type 'Q'): ");
text = Console.ReadLine() ?? "";
StopExe(text);
int b = CheckInput(text);

Console.Write("Enter your third number (or type 'Q'): ");
text = Console.ReadLine() ?? "";
StopExe(text);
int c = CheckInput(text);

//Asing max to a first num
int max_num = a;

//Cрecking if b or c value is greater than a
if (b > a & b >c) max_num = b;
else if (c > a & c > b) max_num = c;

//
Console.Write("Max number from your input is " + max_num);
Console.WriteLine("\n");

// ARRAY VERSION

Console.WriteLine("RANDOM ARRAY VERSION... Press any key to continue ->\n");
Console.ReadKey(true);

int arrSize = 3;
int [] nums = new int[arrSize];
int index = 0;
int max_index = 0;


// Fill up an array with nums
while (index < nums.Length) {
    nums[index] = new Random().Next(1, 100);
    index ++;
}

// Printing an array to be evaluated
Console.Write("Your array: ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

index = 0;
while (index < nums.Length) {
    if (nums[index] > nums[max_index]){
        max_index = index;
        }   
index ++;
}

// Printing result
Console.WriteLine();
Console.Write("... and max number from your array: " + nums[max_index]);
