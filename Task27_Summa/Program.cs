// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
{
    int num;
    Console.Write("Введите число : ");

    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

int sumOfDigits(int inp)
{
    int numRes = 0;
    //int tempNum = inp;
    while (inp > 0)
    {
        //tempNum = inp % 10;
        numRes = numRes + (inp % 10);
        //tempNum = 
        inp = inp / 10;
    }
    return numRes;
}

Console.WriteLine();
Console.WriteLine();

int number = IntInput("");
int totalSum = sumOfDigits(number);

Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine($"Сумма цифр числа {number} равна {totalSum}");
Console.WriteLine();
Console.WriteLine();
