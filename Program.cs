// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

string numInLine = InputString("Введите числа через запятую: ");
int count = CountPositivNum(numInLine);
Console.WriteLine($"Среди введенных чисел {count} больше 0.\n");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Две прямые заданны уравнениями: \ny = k1 * x + b1\ny = k2 * x + b2");
double b1 = InputDouble("Введите b1: ");
double k1 = InputDouble("Введите k1: ");
double b2 = InputDouble("Введите b2: ");
double k2 = InputDouble("Введите k2: ");
double x,y;

if(k1 == k2 )
{
    Console.WriteLine("Прямые параллельны.");
}
else
{
    x = (b2 - b1) / (k1 - k2) ;
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: x = {x} , y = {y}");
}

//Методы

int CountPositivNum(string inputStrNum)
{
    string tempString = string.Empty;
    char tempChar;
    int countPositiveNum = 0;
    for (int i = 0; i < inputStrNum.Length; i++)
    {
        tempChar = inputStrNum[i];
        if(tempChar == '-' )
        {
            tempString += tempChar;
            continue;
        }
        else if(tempChar == ',' )
        {
            countPositiveNum += GreaterZeroOrNo(tempString);
            tempString = string.Empty;
            continue;
        }
        else if(i == inputStrNum.Length - 1)
        {
            tempString += tempChar;
            countPositiveNum += GreaterZeroOrNo(tempString);
            continue;
        }
        tempString += tempChar; 
    }
    return countPositiveNum;
}

int GreaterZeroOrNo(string str)
{
    if(Convert.ToInt32(str) > 0)
    {
        return 1;
    }
    return 0;
}

string InputString(string str)
{
    Console.Write(str);
    return Console.ReadLine();
}

double InputDouble(string str)
{
    Console.Write(str);
    return Convert.ToDouble(Console.ReadLine());
}