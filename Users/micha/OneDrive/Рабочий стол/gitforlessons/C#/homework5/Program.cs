// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int arraySize = new Random().Next(2,8);
int[] array = new int[arraySize];
int size = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
    if(i % 2 == 1)
    {
        size = size + array[i];
    }
}
var str = string.Join(" ", array);
Console.WriteLine($"сумма чисел  стоящих на нечетных позициях в массиве [{str}]  --> " + size);