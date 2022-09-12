// Console.WriteLine("Введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DegreeNumber(a,b));

// int DegreeNumber(int number, int deg)
// {
//     int result = number;
//     for (int i = 1; i < deg; i++)
//     {
//         result *= number;
//     }
//     return result;
// }


Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DegreeNumber(a, b));

double DegreeNumber(int number, int deg)
{
    double result = Math.Pow(number, deg);
    return result;
}

// Почему функция Math.Pow отказывается работать с int типом????