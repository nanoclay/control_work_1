void RandomArrey(int[] Arrey, int min, int max)
{
    for(int i = 0; i < Arrey.Length; i++)
    {
        Arrey[i] = new Random().Next(min, max + 1);
    }
}
void GenerateArrey(int[] Arrey)
{
    for(int i = 0; i < Arrey.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        Arrey[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArrey(int[] Arrey)
{
    for(int i = 0; i < Arrey.Length; i++)
        Console.WriteLine(Arrey[i]);
}

Console.Write("Введите длину масива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите {1}, чтобы задачть значения вручную или {2}, чтобы сгенерировать автоматически: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] Mas = new int[length];
if (n == 2)
{
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());
    RandomArrey(Mas, min, max);
}
else
{
    GenerateArrey(Mas);
}
PrintArrey(Mas);