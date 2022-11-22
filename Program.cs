// Приграмма пишет код, который принимает числа и выдает его квадрат.

// Console.WriteLine("Add number");
// string numberStr = Console.ReadLine();
// int number = Convert.ToInt32(numberStr);

// int result = number * number;

// Console.WriteLine($"квадрат числа {number} = {result}");

/*Задача №2. Напишите программу, которая на вход 
принимает два числа и проверяет, 
является ли первое число квадратом второго.*/
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

// Console.WriteLine("Add 1 number");
// string number1Str = Console.ReadLine();
// int number1 = Convert.ToInt32(number1Str);

// Console.WriteLine("Add 2 number");
// string number2Str = Console.ReadLine();
// int number2 = Convert.ToInt32(number2Str);

// if(number1/number2 == number2) 
// {
//     Console.WriteLine("Yes");
// } 
// else 
// {
//     Console.WriteLine("No");
// }


// Задача №3. Напишите программу, 
// которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Add day");
// string numberStr = Console.ReadLine();
// int day = Convert.ToInt32(numberStr);

// if (day == 1) 
// {
//     Console.WriteLine("Понедельник!");
// } else if(day == 2){
//     Console.WriteLine("Вторник");
// }else if(day == 3){
//     Console.WriteLine("Среда");
// }else if(day == 4){
//     Console.WriteLine("Четверг");
// }else if(day == 5){
//     Console.WriteLine("Пятница");
// }else if(day == 6){
//     Console.WriteLine("Суббота");
// }else if(day == 7){
//     Console.WriteLine("Воскресенье");
// } else {
//     Console.WriteLine("Это не день недели!");
// }

// Задача №5. Напишите программу, 
// которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке 
// от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Add number");
// int number = Convert.ToInt32(Console.ReadLine());

// number =Math.Abs(number);

// for (int i = -number; i <= number; i++)
// {
//     Console.Write($"{i}, ");
// } 


// Задача №7. Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// int num = Int32.Parse(Console.ReadLine());
// if (num > 999 && num < 100) 
// {
//     Console.WriteLine("Wrong number");
//     return;
// }
//     int num2 = num % 10;
//     Console.WriteLine(num2);
