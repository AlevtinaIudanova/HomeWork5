// Написать программу копирования массива

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
}

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 15);
}
Print(array);
Console.WriteLine();

int[] copy = new int[array.Length];
array.CopyTo(copy, 0);

Console.WriteLine($"new array: {String.Join(", ", copy)}");

