// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Нельзя использовать Math.Pow.

// Если использовать только один метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Pow(int a, int b) 
{
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int pow = firstNumber;

    for (int i = 1; i < secondNumber; i++)
    {
        pow = pow * firstNumber;
    }
    Console.WriteLine($"{firstNumber} в степени {secondNumber} = " + pow);
}

int a = 0;
int b = 0;
Pow(a, b);


// Если использовать несколько методов.
// Подзадачи:
// 1. Ввод числа пользователем (double).
double GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

// 2. Формула возведения в корень.
double NewPow(double a, double b)
{
    double pow = a;

    for (double i = 1; i < b; i++)
    {
        pow = pow * a;
    }

    return pow;
}

// 3. Вывод на печать результата.
void Print(string text)
{
    Console.WriteLine(text);
}

double firstNumber = GetNumber("Введите первое число: ");
double secondNumber = GetNumber("Введите второе число: ");
double result = NewPow(firstNumber, secondNumber);
Print($"{firstNumber} в степени {secondNumber} = " + result);