/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;

Clear();                                                          // Очищаем терминал

ShowSumm(SummNums(ArrInd("Введите число A: "), ArrInd("Введите число B: ")));

int ArrInd(string text)                                           // Метод ввода-вывода данных с передачей ему текста
{
    Write(text);
    int num = int.Parse(ReadLine()!);
    return num;
}

int SummNums(int a, int b)                                       // Рекурсивный метод вычисляет сумму чисел между ними включительно
{
    int summ = 0;
    if (a > b)                                                   // Условие проверки отношения величины чисел к друг другу
    {
        if (a == b)
        {
            return b;
        }
        summ = b + SummNums(a, b + 1);
        Write($"{summ}\n");
    }
    else
    {
        if (b == a)
        {
            return a;
        }
        summ = a + SummNums(a + 1, b);
        Write($"{summ}\n");
    }
    return summ;
}

void ShowSumm(int x)                                             // Метод выводит сумму чисел в терминал
{
    Write($"Сумма чисел равна: {x}.");
}