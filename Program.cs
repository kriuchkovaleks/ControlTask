/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/


int GetArrayLenght(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0)
                return number;
            else
            {
                Console.WriteLine("Number must be more than 0. Input another number");
            }
        }
        else
        {
            Console.WriteLine("You have typed not number. Input number more than 0");
        }
    }
}

string[] FillArray(int lenght)
{
    string[] arr = new string[lenght];

    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine("Input array element");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] array)

{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] GetResultArray(string[] array)
{
    int resultArrayLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            resultArrayLength = resultArrayLength + 1;
        }
    }
    string[] resultArray = new string[resultArrayLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

string message = "Input array lenght";

int ararayLenght = GetArrayLenght(message);

string[] originalArray = FillArray(ararayLenght);

PrintArray(originalArray);

string[] result = GetResultArray(originalArray);

Console.WriteLine();
Console.WriteLine("RESULT ARRAY: ");
PrintArray(result);


