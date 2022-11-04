// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using System;

namespace dz12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while(true){
                Console.Write("Задача 1.\n Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь\n");
                Console.WriteLine("Задача 2. \nНапишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.\n");
                Console.WriteLine("Введите номер задачи, которую необходимо решить. Если хотите выйти из программы, напишите 0.");
                int num=Convert.ToInt32(Console.ReadLine());
                switch (num){
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        return;
                        break;
                }
            }
        }

        static void Task1(){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите числа через пробел");

            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int[] array=new int[str_arr.Length];
            for (int i = 0; i < str_arr.Length; i++)
            {
                array[i]=Convert.ToInt32(str_arr[i]);
            }
            int kolvo=0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]>0){
                    kolvo++;
                }
            }
            Console.WriteLine($"Количество положительных чисел равно {kolvo}");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task2(){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите через пробел k1,b1,k2,b2");

            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=4){
                return;
            }
            int[] array=new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i]=Convert.ToInt32(str_arr[i]);
            }
            int x=(array[3]-array[1])/(array[0]-array[2]);
            int y=array[0]*x+array[1];
            Console.WriteLine($"Точка пересечения имеет координаты ({x},{y})");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
