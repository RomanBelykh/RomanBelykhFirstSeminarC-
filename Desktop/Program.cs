//Задача 2
int a,b;

Console.WriteLine("Введите два числа");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число " + a + " больше, чем число " + b);
}
else
{
    Console.WriteLine("Число " + b  +" больше, чем число " + a);
}


//Задача 4
int a, b, c;

Console.WriteLine("Введите три числа");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b && a>c)
{
    Console.WriteLine("Число " + a + " больше, чем число " + b + " и больше чем число " + c);
}

if (b > a && b>c)
{
    Console.WriteLine("Число " + b + " больше, чем число " + c + " и больше чем число" + a);
}

if (c > b && c>a)
{
    Console.WriteLine("Число " + c + " больше, чем число " + b+ " и больше чем " + a);
}


// Задача 6
int a;

Console.Write("Input number: ");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
Console.WriteLine("число четное, делится без остатка");
}

else
{
Console.WriteLine("число нечетное, не делится без остатка"); 
}


//Задача 8
 int N;
int current = 1;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

while (current <= N)
{
    if (current % 2 ==0)
    {
        Console.Write(current + " ");
        current +=2;
    }
    else
    {
        current++;
    }
}    
