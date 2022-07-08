/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Random random = new Random();
int sum = 0;
int[,] a = new int[100, 1000];
for (int i = 0; i < 1000; i++)
    {
        for (int j = 0; j < 1000; j++) 
        Console.Write("{100,1000}", a[j, i] = random.Next(100, 1000));
        Console.WriteLine();
     }
Console.ReadLine();
