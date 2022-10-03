/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

/*
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
 */


 /*
 Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

 void Lines(double k1, double b1, double k2, double b2)
{
    if(k1==k2 && b1==b2)
        Console.WriteLine("Прямые совпадают - не пересекаются");
    else
        if (k1==k2)
            Console.WriteLine("Прямые параллельны - не пересекаются");
        else
            {
                double x  = (b2-b1)/(k1-k2);
                double y  = k1*x + b1;
                Console.WriteLine($"({Math.Round(x,2)}; {Math.Round(y,2)})");
            }
}

Console.Write("Введите через пробел угловой коэффициент k и свободный член b первой прямой ");
string []s = Console.ReadLine().Split();
double k1 = double.Parse(s[0]);
double b1 = double.Parse(s[1]);

Console.Write("Введите через пробел угловой коэффициент k и свободный член b второй прямой ");
s = Console.ReadLine().Split();
double k2 = double.Parse(s[0]);
double b2 = double.Parse(s[1]);
Lines(k1,b1,k2,b2);

