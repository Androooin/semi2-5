/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76


*/
int[] CreateNewArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int MinNewArray(int [] array)
{
   int min = array [0];
    for(int i = 0; i < array.Length; i++)
    {
        
        if (array[i] < min)
        min = array [i];
    }
    return min;

}

int MaxNewArray(int [] array)
{
   int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array [i];
    }
    return max;

}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sizearray = ReadInt(" Write size array ");
int minarray = ReadInt("Write minimum digit in array ");
int maxarray = ReadInt("Write maximum digit in array ");

if (minarray >= maxarray)
{
    Console.WriteLine("Your maximum digit in array  < minimum digit in array. Try again! ");
    
}
else
{
int [] arraystart = CreateNewArray(sizearray, minarray, maxarray);

PrintNewArray(arraystart);

int difference = MaxNewArray(arraystart) - MinNewArray(arraystart);

Console.WriteLine($"-> {difference}");
}

Lutsenko();
