// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число : ");
int number =  Convert.ToInt32(Console.ReadLine());

if(number>=10000 & number<100000)
{
    string num = Convert.ToString(number);
    if(num[0]==num[4] & num[1]==num[3])
    {
        Console.Write("Да");
    }
    else {Console.Write("Нет");}

}
else
{
    Console.Write("Введите 5тизначное число");
}