// Задача: Написать программу, которая из имеющегося массива
// строк, формирует массив из строк, длина которых меньше либо
// равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] array = new string[6] { "hello", "2", "world", ":-)", "computer science", "-2" };

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


void Changearray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) array[i] = "delete";
    }
}

void PrintChangeArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1 && array[i].Length <= 3) Console.Write($"{array[i]}, ");
        else if (array[i].Length <= 3) Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


PrintArray(array);
Console.WriteLine("Результат нового массива: ");
Changearray(array);
PrintChangeArray(array);
