string[] Array(int size)
{
    string [] arr = new string [size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
void ShowArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int Number(string[] arr)
{
    int count = 0;
    int limit = 4;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < limit)
        count++;
    }
    return count;
}
string[] Final(string[] arr, int size)
{
    string [] fin = new string [size];
    int i = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length < 4)
            {
                fin[i] = arr[j];
                i++;
            }    
    }
    return fin;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] first = Array(size);
ShowArray(first);
Console.WriteLine();
int second = Number(first);
ShowArray(Final(first, second));