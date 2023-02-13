


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

string[] myArray = FillArrayManual("Введите любые символы или ВВОД для выхода:\n");
Console.WriteLine();
Print1DArray(myArray);