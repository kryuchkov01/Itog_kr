// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в 
// натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B =  Convert.ToInt32(Console.ReadLine());

int result = A;
for (int i = 2; i <= B; i++)
{
    result *= A;
    
}
Console.Write(result);



// if (A>0 && B>0)
// {
//     double result = Math.Pow(A, B);
//     Console.Write(result);
// }
