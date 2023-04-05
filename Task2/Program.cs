//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Read()
{
    System.Console.WriteLine("введите число: ");
    int number=int.Parse(Console.ReadLine());
    return number;
}
int A=Read();
int x=A%10;
int Sum = x;
while(A!=0)
{
    
    Sum=Sum+x;
    A=A/10;
   
}
System.Console.WriteLine(Sum);