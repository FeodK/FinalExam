Console.Clear();

System.Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] GetArray(int n)
{
    string[] array = new string[n];
    System.Console.WriteLine("Введите массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] firstArray = GetArray(size);

void PrintArray(string[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write(arrayToPrint[i]);
        if (i<arrayToPrint.Length - 1)
        {
            Console.Write ( ", ");
        }
    }
    System.Console.Write("]");
}

string[] GetNewArray(string[] array)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) newSize++;
    }

    string[] newArray = new string[newSize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        } 
    }
    return newArray;
}

string[] secondArray = GetNewArray(firstArray);

PrintArray(firstArray);
System.Console.WriteLine();
System.Console.WriteLine("Новый массив: ");
PrintArray(secondArray);