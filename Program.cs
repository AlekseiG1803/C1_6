﻿int number1 = new Random().Next(1, 10);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);
int number3 = new Random().Next(1, 10);
Console.WriteLine(number3);
int number4 = new Random().Next(1, 10);
Console.WriteLine(number4);
int number5 = new Random().Next(1, 10);
Console.WriteLine(number5);

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;
if (number4 > max) max = number4;
if (number5 > max) max = number5;

Console.Write("Максимум равен: ");
Console.Write(max);

