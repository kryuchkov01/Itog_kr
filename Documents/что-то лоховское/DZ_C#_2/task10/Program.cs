// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число : ");
int number =  Convert.ToInt32(Console.ReadLine());
if(number>99 & number<1000)
{
    int digit1 = number%100;
    int digit3 = number%10;
    int digit2 = (digit1-digit3)/10;
    Console.Write(digit2);
}
else
{
    Console.Write("Введите 3х значное число");
}
