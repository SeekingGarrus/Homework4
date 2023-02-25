// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// Если использовать только один метод, который будет принимать на вход число и выдавать сумму цифр в числе
int Summa()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number != 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}
Console.WriteLine($"Сумма всех чисел равна {Summa()}");


// Если использовать несколько методов.
// Подзадачи:
// 1. Ввод числа
int GetInt(string text) // функция для ввода числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Вычисление суммы цифр
int Sum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}

// 3. Вывод на печать результата
void AddText(string message)
{
    Console.WriteLine(message);
}


int value = GetInt("Введите любое целое число: ");
int summa = Sum(value);
AddText($"Сумма всех чисел равна {summa}");