// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string EnterNumber(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}

string PalindDef(string n)
{
    if (n.Length == 5)
    {
        if (n[0] == n[4] && n[1] == n[3]) return "это палиндром";
        else
        {
            return "это не палиндром";
        }
    }
    else return "Вы ввели не пятизначное число";
}

// 1. ввод данных
string number = EnterNumber("введите пятизначное число для проверки на палиндром: ");

// 2. анализ данных
string palind = PalindDef(number);

// 3. вывод информации
Console.WriteLine(palind);