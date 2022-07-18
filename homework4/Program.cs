//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

int[] values = { 701, 185, 345, 128, 214 };
int[] indexes = Enumerable.Range(0, values.Length).ToArray();
 
Array.Sort(values, indexes);
for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine($"{values[i]} [{indexes[i]}]");
}