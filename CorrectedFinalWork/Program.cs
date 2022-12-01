void CreatedArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void ResultingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите элементы массива через пробел: ");
string[] array1 = Console.ReadLine().Split();
string[] array2 = new string[array1.Length];
CreatedArray(array1, array2);
Console.WriteLine();
Console.Write("Получившийся массив с элементами <=3 символов: ");
ResultingArray(array2);