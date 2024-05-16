# Описание решения задачи
## Создание массивов
1. Создаем переменные `num` и `count`, которые будут определять количество элементов в массивах:

```sh
int num = new Random().Next(3,5);
int count = 0;
```

2. Создаем массив `InputString`, в который будут записаны исходные строки, введенные с клавиатуры:
```sh
string?[] InputStrings = new string[num];
```
2. Создаем массив `arrayResult`, в который будут записаны строки, длина которых меньше, либо равна 3 символам:
```sh
string?[] arrayResult = new string[count];
```

## Создание Метода `PrintInputArrayStr`, для заполнения массива путем введения строк с клавиатуры и вывода массива в консоль
```sh
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
```
## Создание Метода `GetArrayStrThreeSymbol`, который выбирает из исходного массива InputString строки, длина которых меньше, либо равна 3 символам и записывает в массив arrayResult.
1. Сначала отсчитывается количество строк, удовлетворяющих требованию, для определения длины массива.
2. Создается массив, в который заносятся строки, удовлетворяющие требованию.
```sh
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
```
## Создание Метода `PrintArrayStrThreeSymbol`, для вывода массива arrayResult в консоль (массив, в который записаны строки, длина которых меньше, либо равна 3 символам)
```sh
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
```
## Создание кода для вызова методов и отображения информации в консоли
```sh
System.Console.WriteLine("Введите массив строк:");
PrintInputArrayStr();
System.Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArrayStrThreeSymbol(GetArrayStrThreeSymbol(arrayResult));
```