// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine("Add first number");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond) 
{
    Console.WriteLine("Первое число больше второго!");
} else {
    Console.WriteLine("Второе число больше первого!");
}

// ........................................................................................................................................

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

 Console.WriteLine("Add first number");
int numberFirst2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add second number");
int numberSecond2 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Add third number");
int numberThird2 = Convert.ToInt32(Console.ReadLine());

int max = numberFirst2;

if (numberSecond2 > max ) {
    max = numberSecond2;
} 
if (numberThird2 > max) {
    max = numberThird2;
}
Console.WriteLine($"{max}");

// ........................................................................................................................................

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Add number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number3 % 2 == 0) {
    Console.WriteLine("Число четное!");
} else {
    Console.WriteLine("Число нечетное!");
}


// ........................................................................................................................................

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Add number: ");
int number4 = Convert.ToInt32(Console.ReadLine());

number4 =Math.Abs(number4);

for (int i = 2; i <= number4; i++)
{
    Console.Write($"{i}, ");
    i++;
} 