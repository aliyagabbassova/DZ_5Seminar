// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите число");
int[]array=new int[4];
int count = 0;
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i]+", ");
    
    if (array[i] % 2 == 1)  
    {
        count = count + array[i];
    }
    
}
Console.WriteLine($"Всего 4 числа, сумма нечетных чисел равна: {count} ");