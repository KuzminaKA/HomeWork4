//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array=new int[8];
System.Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
   array [i] = new Random().Next(0,100);
   System.Console.Write(" ");
    System.Console.Write(array[i]);
}
System.Console.Write(" ]");