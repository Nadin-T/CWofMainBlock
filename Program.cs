//Функция создания массива строк с консоли
string[] CreateArrayOfString()
{
    Console.WriteLine("Введите элементы массива через запятую:");
    string input = Console.ReadLine()!;
    string[] inputArray = input.Split(',');
    return inputArray;
}

//Функция подсчета количества элементов массива со строкой меньшей или равной 3 символам
int CountNumberOfElementsStringInSizeUpToThree(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

//Функция проверки (строка в массиве <=3)
string[] GetArrayOfStringInSizeUpToThree(string[] array)
{
    int size = CountNumberOfElementsStringInSizeUpToThree(array);
    string[] newArray = new string[size];
    int newIndex = 0;

    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            newArray[newIndex] = item;
            newIndex++;
        }
    }
    return newArray;
}

//Функция вывода массива
void ShowArray(string[] array)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(($"{array[i]} "));
    }
}



string[] inputArray = CreateArrayOfString();
string[] newArray = GetArrayOfStringInSizeUpToThree(inputArray);
ShowArray(newArray);