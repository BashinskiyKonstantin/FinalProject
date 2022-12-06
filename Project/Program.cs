string[] array = new string[6] { "hello", "2", "world", ":-)", "computer science", "-2" };

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

void ChangeArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) array[i] = string.Empty;
    }
}

PrintArray(array);
Console.Write("Результат нового массива: ");
ChangeArray(array);
PrintArray(array);

