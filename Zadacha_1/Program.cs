// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double[,] arr = new double [3,4];
void PrintArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + Math.Round(array[i, j], 2));

        }
        Console.WriteLine();
    }
}
void FillArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().NextDouble();
        }
        Console.WriteLine();
    }
}
PrintArray(arr);
FillArray(arr);
Console.WriteLine();
PrintArray(arr);