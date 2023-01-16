// Задача 28: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

//просто строчное клерковское решение

// Console.Write("Введите число : ");
// int N =  Convert.ToInt32(Console.ReadLine());
// int product = 1;

// for (int i = 1; i<=N; i++)
// {
//     product *= i;
// }
// Console.WriteLine(product);

//решение для крутых челов через метод
Console.WriteLine("Введите число : ");
int A =  Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 1;
    for (int i = 1; i<= A; i++)
    {
        sum *= i;
    }
    return sum;
}


Console.WriteLine(Sum(A));