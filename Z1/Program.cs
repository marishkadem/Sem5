/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет
 количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GenerateArray(int length)
{
    var array = new int[length];
    var random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(99, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int Chetnie(int[] array)
{
    int N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            N++;
        }
    }
    return N;
}

var array = GenerateArray(10);
PrintArray(array);
System.Console.WriteLine(Chetnie(array));
