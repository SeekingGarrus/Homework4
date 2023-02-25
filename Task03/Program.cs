// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

// Первый метод, если использовать только один метод, который задаёт рандомный массив из N элементов и выводит их на экран.
void Massive()
{
    Console.WriteLine("Введите число: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] num = new int[size];
    Console.Write("Массив: [");

    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-100, 101);
        Console.Write(" " + num[i] + " ");
    }
    Console.Write("]");
}
Massive();
Console.WriteLine();


// Второй метод, на рандомное заполнение массива for, min и max ставим свое
void fillRandomArray(int[] arr)
{
    Console.Write("Введите min число массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max число массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minValue, maxValue);
        Console.Write(arr[i] + ", "); 
    }
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
fillRandomArray(numbers);


// Решение с методами(функциями), заполнение массива пользователем. Делали с преподавателем.
// Подзадачи:
// 1. Создать массив
double[] CreateArray(int size)
  {
    // return Array.CreateInstance(typeof(int), 10);
    return new double[size];
  }

// 2. Заполнить массив руками
void Fill(double[] array)
  {
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
      array[i] = GetDataFromUser($"Введите значения массива[{i + 1}]");
    }
  }

// 3. Распечатать массив
string ArrayJoinToString(double[] array)
  {
    return $"[{String.Join(", ", array)}]";
  }


// 4. Считать данные от пользователя
double GetDataFromUser(string text)
  {
    double num = 0;
    bool flag = true;
    do
    {
      Console.Write($"{text}: ");
      flag = double.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
  }

// 5. Считать данные от пользователя с целыми числами
int GetIntValueFromUser(string text)
  {
    int num = 0;
    bool flag = true;
    do
    {
      Console.Write($"{text}: ");
      flag = int.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
  }

int count = GetIntValueFromUser("Количество элементов массива: ");
double[] numbers1 = CreateArray(count);
Fill(numbers1);
System.Console.WriteLine(ArrayJoinToString(numbers1));