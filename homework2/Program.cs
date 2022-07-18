//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов

class Program
{
    public static void CreateArray(int[,] myArray)
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\n{0}:", i);
            for (int j = 0; j < 20; j++)
            {
                myArray[i, j] = rnd.Next(10, 99);
                Console.Write("{0}  ", myArray[i, j]);
            }
        }
    }
    static void Main(string[] args)
    {
        int[,] myArray = new int[10, 20];
        int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
        CreateArray(myArray);

        for (int i = 0; i < 10; i++) 
        {
            Sum2 = 0;
            for (int j = 0; j < 20; j++) 
            { Sum2 += myArray[i, j]; } 
            if (Sum2 < Sum1)
            { Sum = Sum2; Row = i; }
            Sum1 = Sum2;
        }
        Console.WriteLine("\n\t Наименьшаяя сумма = {0}", Sum);
        Console.WriteLine("\n\t Номер строки = {0}", Row);
    }
}