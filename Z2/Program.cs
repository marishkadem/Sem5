/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] GenerateArray(int length)
{
    var array = new int[length];

    var random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 11);
    }

    return array;
}
    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ",");
        }
        Console.Write(array[array.Length - 1]);
    }
    int SumNechetnih(int[] array)
    {
        var result = 0;
        for (var i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                result += array[i];
            }
        }
        return result;
    }
    var array = GenerateArray(7);
    PrintArray(array);
    Console.WriteLine($"\nСумма: {SumNechetnih(array)}");

