// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2) 
{ Console.WriteLine ("Первое число больше второго числа");}
    else
    {
      if (number1 < number2 ) 
{ Console.WriteLine ("Второе число больше первого числа");}
    else
    {
    { Console.WriteLine ("Первое число равно второму числу");}}}

