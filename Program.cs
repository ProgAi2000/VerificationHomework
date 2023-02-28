// выбор из массива строк в новый массив все строки длиной <= 3 символов

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] TextArray = FillArray(size);
string[] NewTextArray = FillNewArray(TextArray);
PrintArray(NewTextArray);

string[] FillArray(int size)
{
    string[] arr = new string[size];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{i+1}: ");
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}

string[] FillNewArray(string[] TextArray)
{
    string text = string.Empty;
    for (int i = 0; i < TextArray.Length; i++)
    {
        if (TextArray[i].Length<4) 
        {
            text += TextArray[i];
            if (i != TextArray.Length-1) text += ";";
        }
    }
    string[] NewArr = text.Split(";");
    return NewArr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]");
}
