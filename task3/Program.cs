// Console.WriteLine("Введите массив");
// string arr = Console.ReadLine();
// Console.WriteLine(arr);

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
       arr[i]=new Random().Next(100); 
    }
    return arr;
}
int[] arrey = GetArray(8);
Console.WriteLine($"[ {String.Join(",",arrey)} ]");








