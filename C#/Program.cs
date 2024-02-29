// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


{
    {
string[] startingArray = new string[] {"ank", "hello", "abc", "world", "smile"};
string[] resultArray = GenerateResultArray(startingArray);
PrintResultArray(resultArray);

    }
string[] GenerateResultArray(string[] startingArray)
    {
    int resultCount = CountStringSymbols(startingArray);
    string[] resultArray = new string[resultCount];
    int index = 0;

    for (int i = 0; i < startingArray.Length; i++)
        {
        if (startingArray[i].Length <= 3)
            {
                resultArray[index] = startingArray[i];
                index++;
            }
        }
        return resultArray;
    }

    void PrintResultArray(string[] resultArray)
    {
        Console.Write("[");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i]);
            if (i <= resultArray.Length - 1)
            {
                Console.Write(";");
                }
        }
    }
    Console.WriteLine("]");
}

int CountStringSymbols(string[] startingArray)
{
    int counter = 0;
    for (int i = 0; i < startingArray.Length; i++)
    {
        if (startingArray[i].Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
        