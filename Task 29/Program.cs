// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Числа из консоли
Console.WriteLine("Введите элементы массива: ");

int[] array1 = new int[8];

FillArray(array1);
PrintArray(array1);
Console.Write($" -> ");
PrintArray2(array1);

void FillArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
        array[i] = int.Parse(Console.ReadLine() ?? "");
}


void PrintArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
}


void PrintArray2(int[] array)
{
    Console.Write($"[");
    for (int i=0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
        
    Console.Write($"]");
}
