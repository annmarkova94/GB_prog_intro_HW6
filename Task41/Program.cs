// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2     // 1, -7, 567, 89, 223-> 3

TextColorDarkGreen();
int[] yourArray = EnterArray();
int numberPositiveInArray = CountPositiveNumbersInArray(yourArray);
Console.WriteLine($"Number of positive numbers in your array {PrintArray(yourArray)} is {numberPositiveInArray}");
Console.ResetColor();

int CountPositiveNumbersInArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

int[] EnterArray()
{
    Console.Write("How many numbers are you going to enter? ");
    int[] array = new int[EnterInteger()];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Enter an integer: ");
        array[i] = EnterInteger();
    }
    return array;
}

int EnterInteger()
{
    int x;
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        TextColorRed();
        Console.WriteLine("This is not a number, try again");
    }
    TextColorDarkGreen();
    return x;
}

string PrintArray(int[] array)
{
    return $"[{string.Join(", ", array)}]";
}

void TextColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void TextColorDarkGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}