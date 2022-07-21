/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int SumCifr (int n)
{ int s=0;
 while(n>0)
 {
    n=n/10;
    s=s+1;
 }
return s;
}
int SumCif (int kolich, int n)
{ int sum = 0; int ost = n; 
    for (int i = kolich; i >= 1; i--)
    {
        int b = i-1, a = 10, p=1, j=1;
         while(j<=b)
         {
        p=p*a; j++;
         }
       sum = sum + (ost / p);
       ost = ost % p;
    }
    return sum;
}
Console.WriteLine("Input positiv integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int kol=KolCifr(num);
Console.WriteLine("Количество цифр в числе =  " + kol );
Console.WriteLine("Сумма цифр в числе =  " + SumCif(kol, num) );



/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

int[] RandomMassiv(int[] collect)
{
int length = collect.Length;
int i = 0;
while (i < length)
 {  
     collect[i] = new Random().Next(1, 100);
     i++;
 }
return collect;
}
void PrintArray(int[] col)

{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
    Console.Write(col[position] + "  ");
    position++;
   }
}
Console.WriteLine("Задайте длину массива!" );
int dlin = Convert.ToInt32(Console.ReadLine());
int [] array = new int[dlin];
int[]mas=RandomMassiv (array);
PrintArray(mas);
/*