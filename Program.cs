﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Вводим данные. Объявляем массив1 (array1) и массив2(array2), в который будет записываться результат
string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

// Создаем метод для выполнения условия задачи
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

// Создаем метод для вывода нового массива в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Вызываем методы
SecondArray(array1, array2);
PrintArray(array2);