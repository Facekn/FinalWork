void SelectArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        Console.Write (array[i] + " ");
        else
        Console.Write ("");
    }
}

string [] array = {"hello", "2", "world", ":-)", "123", "no", "yes", "stop", "product", "git"};
SelectArray (array);