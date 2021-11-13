// See https://aka.ms/new-console-template for more information

// Задание 1
Console.Write("Введи число больше 7: ");
if (Convert.ToInt16(Console.ReadLine()) > 7)
    Console.WriteLine("Привет\n"); 
else Console.WriteLine("Nope\n");

//Задание 2
Console.Write("Введи свое имя, Вячеслав: ");
if (Console.ReadLine() == "Вячеслав")
    Console.WriteLine("Привет, Вячеслав\n");
else Console.WriteLine("Нет такого имени\n");

//Задание 3
Console.Write("Массив чисел, пожалуйста: ");
int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.Write("Кратные 3: ");
foreach (var item in array)
{
    if (item % 3 == 0)
        Console.Write("{0} ", item);
}
Console.WriteLine("\n");

//Задание про скобки
BalancedBrackets.checking();

