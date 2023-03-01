void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}

string[] NewArray(string[] array, int size)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) count++;
    }

    
    string[] newArray = new string[count];
    int newArrayCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) 
        {
            newArray[newArrayCount] = array[i];
            newArrayCount++;
        }
    }

    return newArray;
}

string[] array = {"Hello", "12345", "2023Year", "Go!", "Hi", "@"};

string[] newArray = NewArray(array, 3);

PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);