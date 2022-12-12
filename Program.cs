// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* int level (int A, int B)
{
    int result = 1;
    for (int step = 1; step <= B; step++)
    {
        result *= A;
    }
    if (B == 0) result = 1;
    if (B == 1) result = A;
    return result;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numC = level(numA,numB);
Console.WriteLine($"{numA} в степени {numB} = {numC}");
*/

//Вариант 2 с отрицательной степенью 

/* void level (int A, int B)
{
    int result = 1;
    for (int step = 1; step <= Math.Abs(B); step++)
    {
        result *= A;
    }
    
    if (B > 1)
    {
        Console.WriteLine("$ Число А в степени В = {result}");
    }
    else if (B == 0) 
    {
        Console.WriteLine("$ Число А в степени В = 0");
    }
    else if (B == 1) 
        Console.WriteLine("$ Число А в степени В = {A}");
    else 
    {
        Console.WriteLine($" Число А в степени В = 1/{result}");
    }
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

level (numA,numB );
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int summ(int num)
{
    int result = 0;
    int endNum = 0;
    while(Math.Abs(num) > 0)
    {
        endNum = num % 10;
        result += endNum;
        num /= 10;
    }
    return Math.Abs(result);
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());

int summNum = summ(newnum);
Console.WriteLine($"Сумма цифр в числe {newnum} = {summNum}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[]CreateArray(int size)
{
    
    int[]array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.Write($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}  
void ShowArray(int[] array)
{
   
    for (int i = 0;i<array.Length;i++)
    {
        if (i==0) Console.Write("[" + array[i] + ",");
        else if (i==array.Length-1) Console.Write(array[i]+"]");
        else
        Console.Write(+ array[i]+",");
    }
}
Console.Write("Введите размер массива: ");
int newnum = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(newnum);
ShowArray(myArray);
*/