﻿
// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8



Console.WriteLine("Введите число");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);
int result = a % 10;
Console.WriteLine(result);


// Console.WriteLine("Введите число");
// string example = Console.ReadLine();
// int a = Convert.ToInt32(example);
// int result = a % 10;
// Console.WriteLine(result);