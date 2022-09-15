/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] GenerateArray(int length)
{
    double[] array = new double[length];
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 2000 - 1000, 3);
    }
    return array;
}
/* void PrintArray(double[] array)
{
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
} */

string PrintArrayToStr(double[] array)
{
    string result = "[";

    for (int i = 0; i < array.Length - 1; i++)
    {
        result += $"{array[i]}, ";
    }

    return result + $"{array[array.Length - 1]}]";
}

double MaxMin(double[] array)
{
    double max = 0;
    double min = 0;
    double result = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    return Math.Round(result = max - min, 3);
}

var array = GenerateArray(5);
//PrintArray(array);


Console.WriteLine($"\nИсходный массив: {PrintArrayToStr(array)}\n\nРазница между максимальным и минимальным элементами массива равна: {MaxMin(array)}");