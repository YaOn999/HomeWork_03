// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// запрос координат
int x1 = EnterData("введите координаты X1: ");
int y1 = EnterData("введите координаты y1: ");
int z1 = EnterData("введите координаты z1: ");
int x2 = EnterData("введите координаты X2: ");
int y2 = EnterData("введите координаты y2: ");
int z2 = EnterData("введите координаты z2: ");
// 2. анализ данных
double result = FindDistance(x1, y1, z1, x2, y2, z2);

// 3. вывод информации
Console.WriteLine($"расстояние между данными точками равно {result}");