string[] Array()
{
    Console.Write("Введите число элементов массива: ");
    string [] arr = new string [Convert.ToInt32(Console.ReadLine())];
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
ShowArray(Array());

