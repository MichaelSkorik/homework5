//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int arraySize = new Random().Next(2,8);
int[] array = new int[arraySize];
int evenCount = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
}
var str = string.Join(" ", array);
Console.WriteLine($"Количество четных чисел в массиве [{str}]  --> " + evenCount);
