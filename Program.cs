/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] Snake()
{
    int[,,] snake = new int[5, 6, 3];
    snake[0, 0, 0] = 10;
    for (int k = 0; k < 3; k++)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i > 0 && j == 0) snake[i, j, k] = snake[i - 1, 5, k] + 1;
                if (i == 0 && j == 0 && k > 0) snake[i, j, k] = snake[4, 5, k-1] + 1;
                if (j > 0) snake[i, j, k] = snake[i, j - 1, k] + 1;
            }
        }
    }
    return snake;
}

void PrintArray(int[,,] array)
{
    System.Console.WriteLine();
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    System.Console.WriteLine();
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
                System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,,] snake = Snake();
PrintArray(snake);