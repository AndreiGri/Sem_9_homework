/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using System;
using static System.Console;

Clear();
string text1="Введите первое передаваемое число функциии Аккермана: ";
string text2="Введите второе передаваемое число функциии Аккермана: ";

ShowAckerFunct(AckermanFunction(ArrInd(text1), ArrInd(text2)));                           // Вызов метода выводящего результат с передачей ему методов возвращающих данные

int ArrInd(string text)                                                                   // Метод ввода-вывода данных с передачей ему текста
{
    Write(text);
    int num = int.Parse(ReadLine()!);
    return num;
}

int AckermanFunction(int m, int n)                                                        //Метод вычисления функции Аккермана
{
    int num = 0;
    if (m == 0) num = n += 1;
    else if (n == 0) num = AckermanFunction(m - 1, 1);                                    // Рекурсия метода при n = 0
    else if (n != 0 && m != 0) num = AckermanFunction(m - 1, AckermanFunction(m, n - 1)); // Рекурсия метода при m и n больше 0
    return num;
}

void ShowAckerFunct(int r)                                                               // Метод выводит в терминал текст с результатом
{
    Write($"Результат: {r}");
}