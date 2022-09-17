// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"max = {num1}");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine($"max = {num2}");
// }
// else
// {
//     Console.WriteLine($"Оба числа равны");
// }



// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());

// int max = Math.Max(num3, Math.Max(num1, num2));

// Console.WriteLine(max);


// 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }

// 4.Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int a = 1;

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}

