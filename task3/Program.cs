﻿// напишите прогу, кот-я принимает на вход трехзначное целое число 
// и на выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

int N = 758;
int A = N / 100;
int B = N % 10;
int result = A + B;

Console.Write(result);


