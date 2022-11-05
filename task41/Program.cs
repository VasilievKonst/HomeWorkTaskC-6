int[] ConvAR(string x)
{
    Console.WriteLine(x+":");
    int[] arra = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arra;
}
int[] array = ConvAR("Введите числа через пробел");

int len = array.Length;
int count = 0;
int index = 0;

while(index < len)
{
    if(array[index]>0)
    {
        count++;
    }
    index++;
}

Console.WriteLine($"Колличество введеных чисел больше нуля равно: {count}");



