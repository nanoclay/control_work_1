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
    Console.Write("[");
    for(int i = 0; i < Arrey.Length; i++) 
    {
        Console.Write($"\"{Arrey[i]}\"");
        if(i < Arrey.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}
int LengthNewArrey(string[] Arrey)
{
    int result = 0;

    for (int i = 0; i < Arrey.Length; i++)
    {
        int length = Arrey[i].Length;
        if (length < 4)
           result++;
    }
    return result;
}
string[] ArreyNew(int numLength, string[] ArreyOld)
{
    string[] ArreyNew = new string[numLength];
    int j = 0;
    for (int i = 0; i < ArreyOld.Length; i++)
    {
        int length = ArreyOld[i].Length;
        if (length < 4)
        {
           ArreyNew[j] = ArreyOld[i];
           j++;
        }   
    }
    return ArreyNew;
}

bool flag = true;
int n = 0;

Console.Write("Введите длину масcива: ");
int length = Convert.ToInt32(Console.ReadLine());

while (flag)
{
    Console.Write($"Введите цифру {1}, чтобы задать значения вручную или цифру {2}, чтобы сгенерировать автоматически: ");
    string choiceString = Console.ReadLine();
    if (choiceString == "1" || choiceString == "2")
    {
        flag = false;
        n = Convert.ToInt32(choiceString);
    }
    else Console.WriteLine("Некорректный ввод");
    
}

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
Console.Write("Полученный массив: ");
PrintArrey(Mas);
Console.WriteLine();
int lenghtNewMas = LengthNewArrey(Mas);
string[] NewMas =  ArreyNew(lenghtNewMas, Mas);
Console.Write("Новый массив: ");
PrintArrey(NewMas);