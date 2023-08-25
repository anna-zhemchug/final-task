// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры ,
// либо задать на старте выполнения алгоритма. При решении не рекоvендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
}

string[] newArray(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            count++;
    }

    string[] secondArray = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            secondArray[j] = stringArray[i];
            j++;
        }
    }
    return secondArray;
}

void PrintArray(string[] stringArray)
{
    Console.Write("[ ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
string[] arraySymbols = new string[sizeArray];
array(arraySymbols);
PrintArray(newArray(arraySymbols));