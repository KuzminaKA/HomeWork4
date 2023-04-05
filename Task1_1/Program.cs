//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Read(string number) 

{     
    System.Console.WriteLine($"Введите число {number}:");
    int x = int.Parse(Console.ReadLine());     
    return x; 
}  

int A=Read("A");
int B=Read("B");

int Degree1(int A, int B)
{
    int x=A;
    for (int i = 2; i <= B; i++)
    {
        x=x*A;
    }
       return x; 
    }
    System.Console.WriteLine($"A в степени B= {Degree1(A,B)}");