// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

int number1 = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int number2 = GetNumberFromUser("Введите целое число В: ", "Ошибка ввода!");
double res = NumberOfDegree(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {res}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double NumberOfDegree(int num1, int num2)
{
    double result = 1;
    double result1 = 1;

    if (num2 == 0)
    {
       return result; 
    } 
    else if (num2 > 0)
    {
        while (num2 > 0)
        {
            result = result * num1;
            num2--;
        }
        
    }
    else if (num2 < 0)
    {
        while (num2 < 0)
        {
            result1 = result1 * num1;
            num2++;
        }
        result = 1 / result1;
    }
    
    return result;
}