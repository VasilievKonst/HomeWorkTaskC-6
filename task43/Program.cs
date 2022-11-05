Console.WriteLine("Прямые заданы уравнениями: y=k1*x+b1 и y=k2*x+b2");

double FullNumb(string x)
{
    Console.Write(x+":");
    double numb = Convert.ToDouble(Console.ReadLine());
    return numb;
}

Console.WriteLine("Введите значение переменных");

double b1 = FullNumb("b1");
double b2 = FullNumb("b2");
double k1 = FullNumb("k1");
double k2 = FullNumb("k2");

double x = (b2 - b1)/(k1 - k2);
double y = (k1 * x + b1);

void PrintResault()
{
    Console.WriteLine("Точка с координатами ("+x+";"+y+") является пересечением двух прямых");
}

PrintResault();

