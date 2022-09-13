Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));

int Sum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}



// Console.WriteLine("Введите число");
// string arr  = Console.ReadLine();
// Console.WriteLine(arr[0]);

// int a = Convert.ToInt32(arr[0]);
// System.Console.WriteLine(a);
