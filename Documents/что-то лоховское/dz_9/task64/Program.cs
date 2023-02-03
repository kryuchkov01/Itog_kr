// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int PrintNumbers(int number1, int number2)
{
    if(number1 == number2)
    {
        return number1;
    }
    else Console.Write(PrintNumbers(number1, number2+1) + " ");
    return number2;
}


Console.WriteLine("Введите число: ");
int n =  Convert.ToInt32(Console.ReadLine());
int m = 0;
PrintNumbers(n, m);
