// Программа создает строчный массив и дает возможность либо заполнить его вручную,
// либо заполняет его строками случайной длины из случайных символов указанного диапазона
// кодовой таблицы.  Из полученного массива формируется массив из строк, длина которых задается
// переменными.


int arrLen = 20;       // Размер генерируемого массива
int strLenMax = 10;     // Максимальная длина генерируемой строки
int chMin = 33;        // Диапазон символов кодовой таблицы используемый генератором
int chMax = 127;
int selStrLenMin = 1;  // Минимальная длина строки для выборки
int selStrLenMax = 3;  // Максимальная длина строки для выборки

Console.Clear();
Console.WriteLine("Создаём строчный массив. \nЗаполнить его автоматически строками из случайных "
                 +"символов или заполните его вручную?");
Console.WriteLine("Для автоматического заполнения нажмите 1. \nДля заполнения вручную нажмите 2.");

string[] myArray = {};
link1:
Console.Write(">>> ");
string? mode = Console.ReadLine();
switch (mode)
{
    case "1":
        ResizeAndFillRandomArray(arrLen, strLenMax, chMin, chMax);
        break;
    case "2":
        Console.WriteLine("Вводите любой текст или символы подтверждая окончание ввода кнопкой ВВОД \n"
                         +"или просто кнопку ВВОД с пустой строкой для выхода.");
        FillArrayManual("Новая строка: ");
        break;
    default:
        Console.WriteLine("Выбрано неверное значение. Попробуйте ещё раз.");
        goto link1;
    }

Console.WriteLine();
Console.WriteLine("Исходный массив:");
Print1DArray(myArray);

string[] myArraySelected = SelectItemFromArrayByLength(myArray, selStrLenMin, selStrLenMax);
Console.WriteLine();
Console.WriteLine($"Выбранные строки длиной от {selStrLenMin} до {selStrLenMax} символов:");
Print1DArray(myArraySelected);
Console.WriteLine();


void Print1DArray(string[] array)
{
    Console.Write("[ ");
    Console.Write(string.Join(" ][ ", array));
    Console.WriteLine(" ]");
}

void FillArrayManual(string text)
{
    while(true)
    {
        Console.Write(text);
        string? txt = (Console.ReadLine());
        if (txt == "") break;
        myArray = myArray.Append(txt !).ToArray();
    }
}

void ResizeAndFillRandomArray(int length, int strMax, int fromChar, int toChar)
{
    for (int i = 0; i < length; i++)
    {
        string text = "";
        int strLen = new Random().Next(1, strMax);
        for (int j = 0; j < strLen; j++)
        {
            text += Convert.ToChar(new Random().Next(fromChar, toChar));
        }
        myArray = myArray.Append(text !).ToArray();
    }
}

string[] SelectItemFromArrayByLength(string[] array, int lenMin, int lenMax)
{
    string[] newArray = {};
    for (int i = 0; i < array.Length; i++)
    {
        if (lenMin <= array[i].Length & array[i].Length <= lenMax) newArray = newArray.Append(array[i]).ToArray();
    }
    return newArray;
}
