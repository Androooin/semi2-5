/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

int [] CreateNewArray(int size)
{
int [] newArray = new int [size];
for (int i = 0; i < size; i++)
{
    newArray[i] = new Random().Next(-99,100);
}
  return newArray;
} 

void PrintNewArray(int [] array)
{
    int index = array.Length -1;
    Console.Write("[");
   for(int i = 0; i < array.Length -1; i++) 
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[index]}] ");
}



void OddSumNewArray(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array [i];
    }
    Console.WriteLine($"-> {sum}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int number = 4;
int [] arraystart = CreateNewArray(number);

PrintNewArray(arraystart);

OddSumNewArray(arraystart);

Lutsenko();

