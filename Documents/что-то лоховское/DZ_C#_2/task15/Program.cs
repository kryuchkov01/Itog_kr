// Задача 15: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число : ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number>=1 & number<=5)
{
    Console.Write("Нет");
}
else if(number==6 ^ number==7)
{
    Console.Write("Да");
}
else
{
    Console.Write("Такого дня не существует");
}