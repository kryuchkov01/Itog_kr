// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
    int sum = 0;
    if(M-1 == N)
    {
        return sum;
    }
    return sum = N + SumNumbers(M, N - 1);
}


Console.WriteLine("Введите числа M и N: ");
int M =  Convert.ToInt32(Console.ReadLine());
int N =  Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(M, N);
Console.WriteLine(result);

