﻿/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int count = 1;
    int length = cube.Length;
    while (count < length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++; 
    }
}
void PrintRes(int[] coll)
{
    int index = 1;
    int count = coll.Length;
    while (index < count)
    {
        Console.WriteLine(coll[index]+ " ");
       index++; 
    }
}
int[] arr = new int[cube+1];
Cube(arr);
PrintRes(arr);

