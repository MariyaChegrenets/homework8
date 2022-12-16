// (1) Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 1472      7421
// 5923 -->  9532
// 8424      8442
 
// (2) Задача 62: Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

// (3) Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// матриц 1:  2 4     матрица 2: 3 4
//            3 2                3 3
// Результирующая матрица будет: 18 20
//                               15 18

// (4) Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// (5) Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// (6) Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите номер задачи: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1) Task54();
else if(n == 2) Task62();
else if(n == 3) Task58();
else if(n == 4) Task60();
else if(n == 5) Task56();
else if(n == 6) Task61();

void Task54()  // (1)
{
    Console.WriteLine("Введите m и n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array2d = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array2d[i,j] = new Random().Next(1,10);
            Console.Write($"{array2d[i,j]} ");
        }    
    Console.WriteLine();
    }
    Console.WriteLine();
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            for (int k=0; k < n-1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                } 
            }       
        }
    } 
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
            Console.Write($"{array2d[i,j]} "); 
    Console.WriteLine();
    }
}

void Task62()  // (2)
{
    int n = 4;
    int m = 4;
    int[,] array2d = new int[m,n]; 
    int a = 1;    // a меняется от 1 до m*n a++ (в массиве 4х4 16 ячеек)
    int i = 0;
    int j = 0;
    while(a<= m*n)
    {
        array2d[i,j] = a;
        if(i == 0 && j < 3)
            j++;
        else if(j == 3 && i < 3)
            i++;
        else if(i == 3 && j > 0)
            j--;
        else if(j == 0 && i > 1)
            i--;
        else if(i == 1 && j < 2) 
            j++;
        else if(j == 2 && i < 22)
            i++;
        else if(i == 2 && j > 0)
            j--;    
        a++;
    } 
    for(i = 0; i < m; i++)
    {
        for(j = 0; j < n; j++)
            Console.Write($"{array2d[i,j]} ");
    Console.WriteLine();        
    }
}

void Task58() // (3)
{
    Console.WriteLine("Введите размерность матрицы 1 (MxN):");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array1 = new int[m,n];
    //Console.WriteLine("Введите значения в матрицу 1 через запятую:");
    for(int i=0; i<m; i++)
    {
        //string[] text1 = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for(int j=0; j<n; j++)
        {
            //array1[i,j] = Convert.ToInt32(text1[j]);
            array1[i,j] = new Random().Next(0,10);
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine(); 
    }

    Console.WriteLine("Введите размерность матрицы 2 (AxB):");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] array2 = new int[a,b];
    //Console.WriteLine("Введите значения в матрицу 2 через запятую:");
    for(int i=0; i<a; i++)
    {
        //string[] text2 = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for(int j=0; j<b; j++)
        {
            //array2[i,j] = Convert.ToInt32(text2[j]);
            array2[i,j] = new Random().Next(0,10);
            Console.Write($"{array2[i,j]} ");
        }
        Console.WriteLine(); 
    }
    int[,] result = new int[m,b];
    if(n != a)
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        Environment.Exit(0); 
    }    
    else
       for (int i = 0; i<m; i++)
            {
                for (int j = 0; j<b; j++)
                {
                    result[i,j] = 0;
                    for (int k = 0; k<n; k++)
                        result[i,j] += array1[i, k] * array2[k, j];
                }
            }
    Console.WriteLine();         
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<b; j++)
            Console.Write($"{result[i,j]} ");
        Console.WriteLine();
    }           
}

void Task60()  //(4)
{
    Console.WriteLine("Введите размерность массива M x N x L");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] array3d = new int[m,n,l];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            for(int k=0; k<l; k++)
            {
                array3d[i,j,k] = new Random().Next(10,100);
                Console.Write("{0}({1},{2},{3}) ", array3d[i,j,k],i,j,k);
            }
            Console.WriteLine();
        }
    }
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            for (int k=0; k<l; k++)
            {
                for(int a=0; a < l-1; a++)
                {
                    if (array3d[i,j,k] < array3d[i,j,k+1])
                        Console.WriteLine("Числа в массиве повторяются, задайте новый массив");
                        else Console.WriteLine("Числа в массиве не повторяются"); 
                }        
            }
        }  
    }      
}

void Task56()  // (5)
{
Console.WriteLine("Введите m и n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array2d = new int[m,n];
    
    if(m != n)
    {
    for(int i=0; i<array2d.GetLength(0); i++)
    {
        for(int j=0; j<array2d.GetLength(1); j++)
        {
            array2d[i,j] = new Random().Next(1,10);
            Console.Write($"{array2d[i,j]} ");
        }   
    Console.WriteLine();
    }
    }
    else
    {   Console.WriteLine("Массив не прямоугольный");
        Environment.Exit(0); 
    } 
    int sum = 0;
    int minSum = 0;
    int minRow = 0;
    for (int k=0; k<n; k++)
        minSum += array2d[0, k]; //сумма  первой строки назовем ее минимальной
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
            sum += array2d[i,j];  //сумма каждой строки
        if(sum < minSum)
        {
            minSum = sum;
            minRow = i; 
        }
        sum = 0;        
    }
     Console.Write($"{minRow + 1} строка с наименьшей суммой элементов {minSum}");
}
     
void Task61() // (6)
{
    Console.Write("Введите количество строк треугольника Паскаля: ");
    int n = Convert.ToInt32(Console.ReadLine());
    // int[,] triangle = new int[n,n]; 
    // const int cellWidth = 3; // cellWidth - количество символов для вывода одного элемента массива 
    // for(int i=0; i<n; i++)
    // {
    //     triangle[i,0] = 1; 
    //     triangle[i,i] = 1;     
    // }
    // for(int i=2; i<n; i++)
    // {
    //     for(int j=1; j<i; j++)
    //     triangle[i,j]= triangle[i-1,j] + triangle[i-1,j-1];
    // }
    // int a = cellWidth * n;
    // for(int i=0; i<n; i++)
    // {
    //     for(int j=0; j<n; j++)
    //     {
    //         // Console.SetCursorPosition(a, i+1);
    //         if(triangle[i,j] != 0)
    //             Console.Write($"{triangle[i,j], cellWidth}"); // вместо {cellWidth} можно вставить пробел
    //     }
    //     Console.WriteLine();
    // }
    int rows = n;
    int columns = n + 2;
    int [,] triangle = new int [rows, columns];
    triangle[0,0] = 0;
    triangle[0,1] = 1;
    triangle[0,2] = 0;
    for (int i = 1; i<rows; i++)
    {
        for (int j = 1; j<columns; j++)
        {
            triangle[i,j] = triangle[i-1,j] + triangle[i-1,j-1];
        }
    }    
    for (int i=0; i<rows; i++)
        {
            for (int k=rows; k>i; k--)
            {
                Console.Write("  "); // 2 пробела
            }
            for (int j=0; j<columns; j++)
            {
                if(triangle[i,j] != 0)
                    Console.Write("{0,4}", triangle[i, j]);
            }
        Console.WriteLine();
        } 
}


    
    

