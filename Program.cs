using System.Globalization;

int num = new Random().Next(3,5);
int count = 0;
string?[] InputStrings = new string[num];
string?[] arrayResult = new string[count];
System.Console.WriteLine("Введите массив строк:");
PrintInputArrayStr();
System.Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArrayStrThreeSymbol(GetArrayStrThreeSymbol(arrayResult));

void PrintInputArrayStr()
{
    for (int i = 0; i < InputStrings.Length; i++)
    {
        InputStrings[i] = Console.ReadLine();       
    }
    System.Console.WriteLine("Введенный массив строк:");
    for (int i = 0; i < InputStrings.Length; i++)
    {
        System.Console.Write(InputStrings[i]);
        if (i < InputStrings.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine();
}

string[] GetArrayStrThreeSymbol(string?[] arrayResult)
{
    for (int i = 0; i < InputStrings.Length; i++)
    {
        string? stringFromArray = InputStrings[i];
        if (stringFromArray?.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayStrThreeSymbol = new string[count];
    int j = 0;
    for (int i = 0; i < InputStrings.Length; i++)
    {
        string? stringFromArray = InputStrings[i];
        if (stringFromArray?.Length <= 3)
        {
            arrayStrThreeSymbol[j] = stringFromArray;
            j++;
        }
    }
    return arrayStrThreeSymbol;
}



void PrintArrayStrThreeSymbol(string?[] arrayResult)
{
    for (int i = 0; i < arrayResult.Length; i++)
    {
        System.Console.Write(arrayResult[i]);
         if (i < arrayResult.Length-1)
        {
            System.Console.Write(", ");
        }
    }
}

