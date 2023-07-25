Console.WriteLine("Введите значения k1, b1, k2 и b2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");

// Читаем значения k1, b1, k2 и b2, введенные пользователем
double k1, b1, k2, b2;
if (!double.TryParse(Console.ReadLine(), out k1) ||
    !double.TryParse(Console.ReadLine(), out b1) ||
    !double.TryParse(Console.ReadLine(), out k2) ||
    !double.TryParse(Console.ReadLine(), out b2))
{
    Console.WriteLine("Ошибка ввода. Введите числовые значения.");
    Console.ReadKey();
    return;
}

// Проверка на параллельность прямых
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
    Console.ReadKey();
    return;
}

// Находим точку пересечения прямых
double xIntersection = (b2 - b1) / (k1 - k2);
double yIntersection = k1 * xIntersection + b1;

Console.WriteLine("Точка пересечения прямых: ");
Console.WriteLine("x = " + xIntersection);
Console.WriteLine("y = " + yIntersection);

Console.ReadKey();