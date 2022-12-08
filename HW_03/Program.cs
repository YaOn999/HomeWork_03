// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void FindNumbers(int number)
{
    double result = 0;
    int n = 1;
    while (n <= number)
    {
        result = Math.Pow(n, 3);
        Console.Write($"{result}, ");
        n++;
    }
        }

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// 2. запрос числа
int number = EnterData("Введите число: ");

// 3. вывод информации
FindNumbers(number);