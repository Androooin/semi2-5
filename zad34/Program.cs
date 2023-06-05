/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int [] CreateNewArray(int size)
{
int [] newArray = new int [size];
for (int i = 0; i < size; i++)
{
    newArray[i] = new Random().Next(100,1000);
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

void EvenArray(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"-> {count}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}
 
 int number = 4;
int [] arraystart = CreateNewArray(number);

PrintNewArray (arraystart);

EvenArray (arraystart);

Lutsenko();