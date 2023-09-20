//задача 2 : Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.Write("максимальнное число " + a);
// }
// else
// {
//     Console.Write("максимальное число " + b);
// }

//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b && a > c)
// {
//     Console.Write("максимальнное число " + a);
// }
// if (b > a && b > c)
// {
//     Console.Write("максимальное число " + b);
// }
// if (c > b && c > a)
// {
//     Console.Write("максимальнное число " + c);
// }


//задача 6  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 0 && number % 2 == 0)

// {
//     Console.Write("число " + number + " является четным ");
// }
// else
// {
//     Console.WriteLine("число " + number + " не является четным ");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (N > 1)
{
    while (i <= N)
    {
        Console.Write(i + ", ");

        i = i + 2;

    }

}