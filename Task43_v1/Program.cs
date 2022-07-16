// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// version#1 - enter every number separately

TextColorDarkGreen();
Console.Write("Enter the slope for the 1st line: ");
double k1 = EnterInteger();
Console.Write("Enter the offset for the 1st line: ");
double b1 = EnterInteger();
Console.Write("Enter the slope for the 2st line: ");
double k2 = EnterInteger();
Console.Write("Enter the offset for the 2st line: ");
double b2 = EnterInteger();
PrintPointOfIntersectionTwoLines(k1, b1, k2, b2);
Console.ResetColor();

void PrintPointOfIntersectionTwoLines(double k1, double b1, double k2, double b2)
{
    double intersectionX;
    double intersectionY;
    if (k1 == k2 && b1 != b2)
        Console.WriteLine($"Lines y = {k1}x + {b1} and y = {k2}x + {b2} are parallel");
    else if ((k1 == k2 && b1 == b2))
        Console.WriteLine($"Lines y = {k1}x + {b1} and y = {k2}x + {b2} are identical - they match");
    else
    {
        intersectionX = (b2 - b1) / (k1 - k2);
        intersectionY = k1 * intersectionX + b1;
        Console.WriteLine($"Lines y = {k1}x + {b1} and y = {k2}x + {b2} intersect at point ({intersectionX}, {intersectionY})");
    }
}

double EnterInteger()
{
    double number;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        TextColorRed();
        Console.WriteLine("This is not a number, try again");
    }
    TextColorDarkGreen();
    return number;
}

void TextColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void TextColorDarkGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}