﻿void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; // position вместо index
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10]; //определить массив из 10 элементов

FillArray(array); // наполнили массив случайными числами
PrintArray(array); // вывести массив