// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

// сама программа

int numberA;
int numberB;
double res = 1;

Console.WriteLine();
Console.WriteLine();

numberA = IntInput("A");
numberB = IntInput("B");

for(int i = 1; i <= numberB; i++)
{
    res = res * numberA;
}

Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine($"Число {numberA} в степени {numberB} равно: {res}");
Console.WriteLine();
Console.WriteLine();