// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//!!!проверка на неповтор
void FillArray(int[,,] matrix, int m, int n, int k )
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int t = 0; t < k; t++)
            {
                matrix[i, j, t] = new Random().Next(10, 100);
                Console.Write($"{matrix[i, j, t]}({i},{j},{t}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите размер массива: ");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());
int k =  Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int [m, n, k];
Console.WriteLine("Ваш массив: ");
FillArray(matrix, m, n, k);
Console.WriteLine();

