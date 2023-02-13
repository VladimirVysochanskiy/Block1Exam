


void Print1DArray(string[] array)
{
    Console.Write("| ");
    Console.Write(string.Join(" | ", array));
    Console.WriteLine(" |");
}

string[] FillArrayManual(string text)
{
    string[] array = {};
    while(true)
    {
        Console.Write(text);
        string? txt = (Console.ReadLine());
        if (txt == "") break;
        array = array.Append(txt !).ToArray();
    }
    return array;
}

string[] CreateAndFillRandomArray(int length, int strMax, int fromChar, int toChar)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        string text = "";
        int strLen = new Random().Next(1, strMax);
        for (int j = 0; j < strLen; j++)
        {
            text += Convert.ToChar(new Random().Next(fromChar, toChar));
        }
        array[i] = text;
    }
    return array;
}

// string[] myArray = CreateAndFillRandomArray(10, 10, 1040, 1103);
// string[] myArray = FillArrayManual("Введите любые символы или ВВОД для выхода:\n");
// Console.WriteLine();
// Print1DArray(myArray);