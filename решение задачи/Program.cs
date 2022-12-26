 // ЗАДАЧА:
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых либо меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Write("Введите количество элементов  ");
int size = System.Convert.ToInt32(ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    WriteLine($"Введите {i+1} элемент: ");
    string element = System.Convert.ToString(ReadLine());
    arrayStrings[i] = element;
}
