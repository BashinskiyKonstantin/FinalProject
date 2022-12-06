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

