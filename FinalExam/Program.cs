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