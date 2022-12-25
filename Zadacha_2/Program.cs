// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int[,] numbers = new int[a, b];
void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(0, 100);
        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
}
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
if(rows > a || colums > b)
{
    Console.Write("Таких элементов нет" + " " + (rows, colums));
}
else
{
    void ArrayOp(int[,] array)
    {
    Console.Write(array[rows, colums]);
    }
    ArrayOp(numbers);
}