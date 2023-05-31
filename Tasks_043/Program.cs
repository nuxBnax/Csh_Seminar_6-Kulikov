// Задача 43: 

// Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4, -> (-0,5; -0,5)


void Main()
{
    double k1 = ReadInt("We have function of line 1 (y = k1 * x + b1) please enter a value of k1: ");
    double b1 = ReadInt("We have function of line 1 (y = k1 * x + b1) please enter a value of b1: ");
    double k2 = ReadInt("We have function of line 2 (y = k2 * x + b2) please enter a value of k2: ");
    double b2 = ReadInt("We have function of line 2 (y = k2 * x + b2) please enter a value of b2: ");
    double coordX = PointIntersectionLines(k1, b1, k2, b2);
    if (k1 == k2) System.Console.WriteLine("Sorry, Your lines don't intersect!");
    else
    {
        Console.WriteLine("Coordinates of point intersection of these lines: " +
                         "(" + coordX + "; " + Math.Round(k1 * coordX + b1, 1) + ")");
    }
}

double ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double PointIntersectionLines(double K1, double B1, double K2, double B2)
{
    double x = 0;
    if (K1 != K2) x = Math.Round((B1 - B2) / (K2 - K1), 1);
    return x;
}

Main();
