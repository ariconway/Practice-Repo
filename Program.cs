//ari_conway
//Assignment 7

//1

//a
using System;

int[] num = new int[10];

for (int i = 0; i < num.Length; i++)
{
    num[i] = i + 1;
}

//b
for (int i = 0; i < num.Length; i++)
{
    num[i] *= num[i];
}

//c
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum = sum + num[i];
}
Console.WriteLine($"The sum of the values of array num is {sum}");

//---------------------------------

//2

//a
Console.WriteLine("How many students are in the class?");
int numStudents = Convert.ToInt32(Console.ReadLine());

float[] students = new float[numStudents];

float max = Single.MinValue;
float min = Single.MaxValue;
float avg = 0f;

for (int i = 0; i < students.Length; i++)
{
    Console.Write($"Please enter the grade for student {i+1}: ");
    students[i] = Convert.ToSingle(Console.ReadLine);
}

for (int i = 0; i < students.Length; i++)
{
    if (students[i] > max)
    {
        max = students[i];
    }
    if (students[i] < min)
    {
        min = students[i];
    }
    avg = students[i] + avg;
}

avg = avg / numStudents;

Console.WriteLine($"The minimum grade is {min}.\n" +
    $"The maximum grade is {max}.\n" +
    $"The average is {avg}.");

//b

//--------------------------------------

//3

//a
char[] arrayA = { 'a', 'b', 'c', 'd', 'e' };

for (int i = 4; i >= 0; i--)
{
    Console.WriteLine(arrayA[i]);
}

//b
char[] arrayB = new char[5];

for (int i = 4; i >= 0; i--)
{
    arrayB[i] = arrayA[i];
}

foreach (char element in arrayA)
{
    Console.Write($"{element} ");
}

Console.WriteLine("\n");

foreach (char element in arrayB)
{
    Console.Write($"{element} ");
}

//------------------------------------------

//4

//int smallestNum = 100;
//int biggestNum = 0;
int biggestDiff = 0;
int smallestDiff = 100;
int biggestDifMaxI = 0;
int biggestDifMinI = 0;
int smallestDifMaxI = 0;
int smallestDifMinI = 0;

int[] arrayC = { 7, 17, 13, 2, 3, 11, 40, 30, 27, 15 };

for (int i = 0; i < arrayC.Length - 1; i++)
{
    int diff = Math.Abs(arrayC[i] - arrayC[i + 1]);
    //Console.WriteLine($"{arrayC[i]}, {arrayC[i + 1]}");
    if (diff < smallestDiff)
    {
        smallestDiff = diff;
        smallestDifMinI = arrayC[i];
        smallestDifMaxI = arrayC[i + 1];
    }

    if (diff > biggestDiff)
    {
        biggestDiff = diff;
        biggestDifMinI = arrayC[i];
        biggestDifMaxI = arrayC[i + 1];
    }
}
Console.WriteLine($"Biggest difference = {biggestDiff}, Smallest difference = {smallestDiff}.\n" +
    $"First i of smallest difference is {smallestDifMinI}, second i of biggest difference is {smallestDifMaxI}.\n" +
    $"First i of biggest difference is {biggestDifMinI}, second i of biggest difference is {biggestDifMaxI}.");

//b
for (int i = 0; i < arrayC.Length - 1; i++)
{
    Console.WriteLine($"Outer loop iteration {i}:");
    for (int j = i + 1; j < arrayC.Length; j++)
    {
        Console.WriteLine($"{arrayC[i]}, {arrayC[j]}");
    }
    Console.WriteLine($"End of outer loop iteration {i}\n");
}

//5

//6

//a
int[] array6a = {41, 3, 74, 2, 83};

for (int i = 0; i <= array6a.Length; i++)
{
    if (array6a[i] > array6a[i + 1])
    {
        Console.WriteLine(array6a[i]);  
    }
}



int[] array6b = {10, 34, 96, 5, 2};



//-----------------------------------

//7

string id = "2334664";

int idInt = (int)id;

//---------------------------------

//8



//9

