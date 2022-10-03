/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

int Count(int n)
{
    int k = 0;
    for(int i=0; i<n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
                k++;
        }
    return k;    
}

Console.Write("Введите количество чисел для обработки ");
 int M = int.Parse(Console.ReadLine());
 Console.WriteLine("Вводите числа по одному");
 int c = Count(M);
 Console.WriteLine("Количество положительных чисел равно " + c);