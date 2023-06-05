// Программа для формирования из имеющегося массива строк новый массив из строк, длина элементов которого будет равна или меньше 3 символам.

Console.Clear();

int arrayLength = GetValueFromUser("Введите желаемую длину массива, не равную 0: ", "Ошибка ввода!Повторите попытку!");
Console.WriteLine();

string[] array = GetAndFillArrayByUser(arrayLength);
Console.WriteLine();
PrintArray(array);

string[] result = GetSortedArray(array);

Console.WriteLine();
PrintReport(result);

////////////////////////////////////////////////////////////////////////////////////////////////////////////

int GetValueFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue) && userValue > 0)
            return userValue;
        Console.WriteLine(errorMessage);
    }
}

string[] GetAndFillArrayByUser(int size)
{
    string[] res = new string[size];

    for (int i = 0; i < res.Length; i++)
    {
        Console.Write($"Введите элемент массива под номером {i + 1}: ");

        res[i] = Console.ReadLine()!;
    }
    return res;
}

void PrintArray(string[] arr)
{
    Console.WriteLine($"В результате полученных данных сгенерирован массив: [{String.Join(", ", arr)}]");
}

string[] GetSortedArray(string[] arr)
{
    int i = 0;
    string[] res = new string[i];

    foreach (string el in arr)
    {
        if (el.Length <= 3)
        {
            Array.Resize(ref res, res.Length + 1);
            res[i] = el;
            i++;
        }
    }
    return res;
}

void PrintReport(string[] res)
{
    if (res.Length > 0)
        Console.WriteLine($"В результате сортировки получен массив: [{String.Join(", ", res)}]");
    else
        Console.WriteLine("В данном массиве нет строчных элементов, длина которых меньше или равна 3 символам.");
}