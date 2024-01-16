// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

static string ReadLineFromConsole()
{
    Console.Write("Введите целое число: ");
    return Console.ReadLine();
}

static int SumNumbers(string str)
{
    Int32.TryParse(str, out int number);
    int result = 0;
    do
    {
        result += number % 10;
        number /= 10;
    } while (number > 0);
    return result;
}

static bool CheckStringForExit(string str)
{
    if (str == "q" || SumNumbers(str) % 2 == 0) return false;
    else return true; 
}

//метод Main начинается здесь, выше методы

Console.WriteLine("Для выхода необходимо ввести 'q' или сумма цифр числа дает четное число.");
string str;
do
{
    str = ReadLineFromConsole();

    
} while (CheckStringForExit(str));

Console.WriteLine("Спасибо за использование программы.");