﻿//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.[345, 897, 568, 234] -> 2
Console.WriteLine("Введите число");
int[]array=new int[6];
int count = 0;
for (int i = 0; i < 6; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i]+", ");
    
    if (array[i] % 2 == 0)  
    {
        count++;
    }
}
Console.WriteLine($"Всего 6 чисел, {count} из них четные");