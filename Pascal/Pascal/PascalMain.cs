using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal
{
    class PascalMain
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice < 21 && choice > 0)
            {
                Console.WriteLine("1.Вывести на экран сообщение «Hello World!»");
                Console.WriteLine("2.Вывести на экран три числа в порядке, обратном вводу");
                Console.WriteLine("3.Вывести на экран квадрат введенного числа");
                Console.WriteLine("4.Получить реверсную запись трехзначного числа");
                Console.WriteLine("5.Посчитать количество единичных битов числа");
                Console.WriteLine("6.Вывести на экран наибольшее из двух чисел");
                Console.WriteLine("7.Вывести на экран наибольшее из трех чисел");
                Console.WriteLine("8.Вывести название дня недели по его номеру");
                Console.WriteLine("9.Проверить, является ли четырехзначное число палиндромом");
                Console.WriteLine("10.Проверить, является ли четырехзначное число счастливым билетом");
                Console.WriteLine("11.Проверить, является ли двоичное представление числа палиндромом");
                Console.WriteLine("12.Решить квадратное уравнение");
                Console.WriteLine("13.Вывести на экран все натуральные числа до заданного");
                Console.WriteLine("14.Найти наибольший нетривиальный делитель натурального числа");
                Console.WriteLine("15.Найти наименьший нетривиальный делитель натурального числа");
                Console.WriteLine("16.Подсчитать общее число делителей натурального числа");
                Console.WriteLine("17.Проверить, является ли заданное натуральное число простым");
                Console.WriteLine("18.Вывести на экран все простые числа до заданного");
                Console.WriteLine("19.Вывести на экран первых n простых чисел");
                Console.WriteLine("20.Проверить, является ли заданное натуральное число совершенным");
                choice = Convert.ToInt32(Console.ReadLine());
                PascalTrash Smth = new PascalTrash();
                switch (choice)
                {
                    case 1: Smth.Hello(); Console.ReadKey(); Console.Clear(); break;
                    case 2: Smth.Triple(); Console.ReadKey(); Console.Clear(); break;
                    case 3: Smth.Srt(); Console.ReadKey(); Console.Clear(); break;
                    case 4: Smth.Reverse(); Console.ReadKey(); Console.Clear(); break;
                    case 5: Smth.Amountofone(); Console.ReadKey(); Console.Clear(); break;
                    case 6: Smth.Max2(); Console.ReadKey(); Console.Clear(); break;
                    case 7: Smth.Max3(); Console.ReadKey(); Console.Clear(); break;
                    case 8: Smth.Week(); Console.ReadKey(); Console.Clear(); break;
                    case 9: Smth.Palindrom(); Console.ReadKey(); Console.Clear(); break;
                    case 10: Smth.Ticket(); Console.ReadKey(); Console.Clear(); break;
                    case 11: Smth.BinarPolindrom(); Console.ReadKey(); Console.Clear(); break;
                    case 12: Smth.uravnenie(); Console.ReadKey(); Console.Clear(); break;
                    case 13: Smth.NaturalNumbers(); Console.ReadKey(); Console.Clear(); break;
                    case 14: Smth.MaxDel(); Console.ReadKey(); Console.Clear(); break;
                    case 15: Smth.MinDel(); Console.ReadKey(); Console.Clear(); break;
                    case 16: Smth.Dels(); Console.ReadKey(); Console.Clear(); break;
                    case 17: Smth.SimpleNat(); Console.ReadKey(); Console.Clear(); break;
                    case 18: Smth.AllSimple(); Console.ReadKey(); Console.Clear(); break;
                    case 19: Smth.FirstSimples(); Console.ReadKey(); Console.Clear(); break;
                    case 20: Smth.PerfectNum(); Console.ReadKey(); Console.Clear(); break;
                    
                }

            }
        }
    }
}
