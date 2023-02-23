// Найти точку пересечения двух прямых заданных 
//уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Enter number k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number k2: ");
int k2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number b2: ");
int b2 = int.Parse(Console.ReadLine());

int y;
int x;

if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine($"point: A ({x},{y})");
}
else
{
    Console.WriteLine($"parallel");
}