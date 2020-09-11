using System;

namespace Lab_OOP_1
{
    class Program
    {
        //Функция, проверяющая ввод на число
        static float GetNumber(string input)
        {
            float num;
            if (float.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели текстовое сообщение.");
                Environment.Exit(0);
            }
            return 0;
        }
        //Функция, проверяющая равенство чисел типа float
        static float CheckInequality(float mainNum, float checkNum)
        {
            if (mainNum == checkNum)
            {
                Console.WriteLine("Ошибка. Вы ввели одинаковое число.");
                Environment.Exit(0);
            }
            else 
            {
                return checkNum;
            }
            return 0;
        }
        //Функция, вовзращающая значение точки лежащей в диапазоне, либо выдающей ошибку
        static float ReturnMiddleDot(float dot1, float dot2, float middleDot)
        {
            bool firstDotIsMax = false;
            if (dot1 > dot2)
            {
                firstDotIsMax = true;
            }
            switch (firstDotIsMax)
            {
                case true:
                    if (IsMiddleDot(dot2, dot1, middleDot))
                    {
                        return middleDot;
                    }
                    break;
                case false:
                    if (IsMiddleDot(dot1, dot2, middleDot))
                    {
                        return middleDot;
                    }
                    break;
            }
            Console.WriteLine("Ошибка. Введённое число С не лежит в указанном диапазоне.");
            Environment.Exit(0);
            return 0;
        }
        //Функция проверяющая принадлежность точки указанному диапазону
        static bool IsMiddleDot(float minDot, float maxDot, float middleDot)
        {
            if (middleDot > minDot && maxDot > middleDot)
            {
                return true;
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            float A = GetNumber(Console.ReadLine());
            Console.Write("Введите число B, отличное от А: ");
            float B = CheckInequality(A, GetNumber(Console.ReadLine()));
            Console.Write("Введите число C, лежащее в диапазоне между A и B: ");
            float C = ReturnMiddleDot(A, B, GetNumber(Console.ReadLine()));
            float AC = Math.Abs(C - A);
            float BC = Math.Abs(B - C);
            Console.WriteLine("Произведение длин отрезков АС и ВС составляет: {0:0.000}", AC*BC);
        }
    }
}
