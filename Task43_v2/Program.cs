// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// version#2 - enter numbers once as a string, separated by commas

using System.Linq;
TextColorDarkGreen();
Console.Write("There are two equations: y = k1 * x + b1, y = k2 * x + b2\n"
              + "Enter values for k1, b1, k2, b2 separated by commas (e.g. '1,5, 2, 3, 4'): ");
int arrayLength = 4;
double[] yourArray = EnterArrayOf4NumbersSeparatedByCommas(arrayLength);
PrintPointOfIntersectionTwoLines(yourArray);
Console.ResetColor();

void PrintPointOfIntersectionTwoLines(double[] yourArray)
{
    double k1 = yourArray[0]; double b1 = yourArray[1];
    double k2 = yourArray[2]; double b2 = yourArray[3];
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

double[] EnterArrayOf4NumbersSeparatedByCommas(int length)
{
    double[] yourArray = EnterArrayNumbersSeparatedByCommas();
    while (yourArray.Length != length)
    {
        TextColorRed();
        Console.Write("This is not a list of 4 numbers separated by commas, try again: ");
        yourArray = EnterArrayNumbersSeparatedByCommas();
    }
    TextColorDarkGreen();
    return yourArray;
}

double[] EnterArrayNumbersSeparatedByCommas() // Parse into array elements that can be parsed, skip others
{
    double[] yourArray = Console.ReadLine().Split(", ")
                                           .Where(e => double.TryParse(e, out _))
                                           .Select(e => double.Parse(e))
                                           .ToArray();
    return yourArray;
}

void TextColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void TextColorDarkGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}