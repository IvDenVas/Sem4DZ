// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
int number = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int result = SumNumber(number);
Console.Write($"{number} -> {result}");


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.Write(errorMessage);
    }
}


int SumNumber(int num)
{
    int sum = 0;
    if (num == 0) return sum;
    else if (num > 0)
    {
        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    else if (num < 0)
    {
        int sum1=-1;
        while (num < 0)
        {
            sum = (sum + num % 10);
            num = num / 10;
        }
        sum = sum1 *sum;
    }
    return sum;
}