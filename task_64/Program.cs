/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;
using static System.Console;

Clear();                                                          // Очищаем терминал

ShowNumbers(AllNums(ArrInd("Введите число: ")));                  // Вызываем метод выводящий в терминал результат ему передаём метод возвращающий строку с результатом

int ArrInd(string text)                                           // Метод ввода-вывода данных с передачей ему текста
{
    Write(text);
    int num = int.Parse(ReadLine()!);
    return num;
}

string AllNums(int n)                                             // Рекурсивный метод передающий строку с числами от заданного до единицы
{
    if (n == 1)
    {
        return "1";
    }
    string s = n.ToString() + ", " + AllNums(n - 1);
    return s;
}

void ShowNumbers(string a)                                        // Метод вывода в терминал строки с результатом
{
    Write(a);
}