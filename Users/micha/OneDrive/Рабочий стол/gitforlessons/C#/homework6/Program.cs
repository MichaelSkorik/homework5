Console.Clear();
int[] numbers;
int ans = 0;
int num = new Random().Next(2, 11);
Console.WriteLine($"Enter {num} numbers");
numbers = new int[num];
for (int i = 0; i < num; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0)
    {
        ans++;
    }
}
Console.WriteLine(ans);