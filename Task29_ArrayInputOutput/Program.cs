// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] createRandArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        arr[i] = random.Next(min, max+1);
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
    return arr;
}

int[] createArr(int size)
{
    int[] arr = new int[size];
    for (int i=0; i < size; i++)
    {
        arr[i] = IntInput("arr[" + i + "]");
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
    return arr;
}

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

void printArr(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.Write(str);
}


Console.WriteLine();
Console.WriteLine();

//int[] myArr = createRandArr(5, 0, 99); //заполнение случайными числами от 0 до 100 массива размерностью 5
int[] myArrManual = createArr(5);
Console.WriteLine();
//printArr(myArr);
printArr(myArrManual);

//Console.WriteLine("Hello, World!");
