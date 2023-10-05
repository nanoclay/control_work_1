void RandomArrey(string[] Arrey, int min, int max)
{
    for(int i = 0; i < Arrey.Length; i++)
    {
        Arrey[i] = Convert.ToString(new Random().Next(min, max + 1));
    }
}
void GenerateArrey(string[] Arrey)
{
    for(int i = 0; i < Arrey.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        Arrey[i] = Console.ReadLine();
    }
}
void PrintArrey(string[] Arrey)
{
    for(int i = 0; i < Arrey.Length; i++)
        Console.WriteLine(Arrey[i]);
}

Console.Write("Введите длину масива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите {1}, чтобы задачть значения вручную или {2}, чтобы сгенерировать автоматически: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] Mas = new string[length];
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