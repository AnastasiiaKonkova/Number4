// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int level (int A, int B)
{
    int result = 1;
    for (int step = 1; step <= B; step++)
    {
        result = result * A;
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



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.