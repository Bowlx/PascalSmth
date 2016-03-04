using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pascal
{
    class PascalTrash
    {
       public void Hello()
        {
            Console.WriteLine("Задача № 1. Вывести на экран сообщение «Hello World!»");
            Console.WriteLine("Hello World!");
        }
       public void Triple()
       
        {
            Console.WriteLine("Задача № 2. Вывести на экран три числа в порядке, обратном вводу");

            string[] str = Console.ReadLine().Split(' ');
            for(int i=2;i>=0;i--) Console.Write(str[i] + " ");

        }
       public void Srt()
        {
            Console.WriteLine("Задача № 3. Вывести на экран квадрат введенного числа");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(a*a);
        }
        public void Reverse()
        {
            Console.WriteLine("Задача № 4. Получить реверсную запись трехзначного числа");
            string str = Console.ReadLine();
                for (int i=2; i>=0; i--) Console.Write(str[i]);
        }

        public void Amountofone()
        {
            Console.WriteLine("Задача № 5. Посчитать количество единичных битов числа");
            int n = Convert.ToInt32(Console.ReadLine());
            byte count=0;
            while (n > 0)
            {
                if (n%2 == 1) count++;
                n /=2;
            }

            Console.WriteLine(count);
        }

        public void Max2()
        {
            Console.WriteLine("Задача № 6. Вывести на экран наибольшее из двух чисел");
            Console.WriteLine("Введите 2 числа");
            int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

            if (n[0] > n[1]) Console.WriteLine(n[0].ToString());
            else Console.WriteLine(n[1].ToString());
        }

        public void Max3()
        {
            Console.WriteLine("Задача № 7. Вывести на экран наибольшее из трех чисел");
            Console.WriteLine("Введите 3 числа");
            int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            if (n[0] > n[2] && n[0] > n[2]) Console.WriteLine(n[0].ToString());
            else
            {
                if (n[1] > n[2]) Console.WriteLine(n[1].ToString());
                else Console.WriteLine(n[2].ToString());
            }
        }
        public void Week()
        {
            Console.WriteLine("Задача № 8. Вывести название дня недели по его номеру");
            Console.WriteLine("Введите номер дня недели");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
            }

        }
        public void Palindrom()
        {
            Console.WriteLine("Задача № 9. Проверить, является ли четырехзначное число палиндромом");
            Console.WriteLine("Введите четырехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 10 == number / 1000)
            {
                number /= 10;
                number %= 100;
                if (number % 10 == number / 10)
                {
                    Console.WriteLine("Является");
                }
                else Console.WriteLine("Не является");
            }
            else Console.WriteLine("Не является");
        }
        public void Ticket()
        {
            Console.WriteLine("Задача №10. Проверить, является ли четырехзначное число счастливым билетом");
            Console.WriteLine("Введите номер билета");
            int number = Convert.ToInt32(Console.ReadLine());
            int left = 0, right = 0;
            right += number%10;
            number /= 10;
            right += number % 10;
            number /= 10;
            left += number % 10;
            number /= 10;
            left += number % 10;
            number /= 10;
            if (left == right) Console.WriteLine("Билет счастливый");
            else Console.WriteLine("Билет не счастливый");

        }
        public void BinarPolindrom()
        {
            Console.WriteLine("Задача № 11. Проверить, является ли двоичное представление числа палиндромом");
            Console.WriteLine("Введите число");
            List<int> code = new List<int>();
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                code.Add(num % 2);
                num = num / 2;
                i++;
            }
            
            bool result = true;
            for (int k = 0, j = code.Count - 1; k < j; k++, j--)
            {
                if (code[k] != code[j])
                {
                    Console.WriteLine("Не является"); result = false;
                    break;
                }
            }
            if (result) Console.WriteLine("Является");

        }

        public void uravnenie()
        {
            Console.WriteLine("Задача № 12. Решить квадратное уравнение");
            Console.WriteLine("Введите 3 коэффициента");
            int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            int D = n[1] * n[1] - 4 * n[0] * n[2];
            if (D >= 0)
            {
                if (D == 0)
                {
                    Console.WriteLine("x= " + (-n[1] / (2 * n[0])));
                }
                else
                {
                    Console.WriteLine("x1= " + (-n[1] + Math.Sqrt(D)) / (2 * n[0]));
                    Console.WriteLine("x2= " + (-n[1] - Math.Sqrt(D)) / (2 * n[0]));
                }
            }
            else Console.WriteLine("Решений нет");
        }
        public void NaturalNumbers()
        {
            Console.WriteLine("Задача № 13. Вывести на экран все натуральные числа до заданного");
            Console.WriteLine("Введите натуральное число");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.Write(i + " ");
            }
        }
        public void MaxDel()
        {
            Console.WriteLine("Задача № 14. Найти наибольший нетривиальный делитель натурального числа");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = number/2+1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("наибольший нетривиальный делитель: " + i);
                    flag = true;
                    break;
                }
            }
            
           if(flag==false) Console.WriteLine("Число простое");
        }
        public void MinDel()
        {
            Console.WriteLine("Задача № 15. Найти наименьший нетривиальный делитель натурального числа");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("наименьший нетривиальный делитель: " + i);
                    flag = true;
                    break;
                }
                
            }
            if (flag == false) Console.WriteLine("Число простое");
        }
        public void Dels()
        {
            Console.WriteLine("Задача № 16. Подсчитать общее число делителей натурального числа");
            Console.WriteLine("Введите число");
            int result = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    result += 1;
                }
            }
            Console.WriteLine(result);
        }
        public void SimpleNat()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = number / 2 + 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Число не является простым");
                    flag = true;
                    break;
                }
            }
            if (flag == false) Console.WriteLine("Число простое");

        }
        private static bool SimpleNat(int number)
        {
            
            bool flag = true;
            for (int i = number / 2 + 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    
                    flag = false;
                    break;

                }
            }
            return flag;

        }
        public void AllSimple()
        {
            Console.WriteLine("Задача № 18. Вывести на экран все простые числа до заданного");
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=n;i++) if(SimpleNat(i)) Console.Write(i + " ");
        }

        public void FirstSimples()
        {
            Console.WriteLine("Задача № 19. Вывести на экран первых n простых чисел");
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int k = 1;
            while (i <= n)
            {
                if (SimpleNat(k))
                {
                    Console.Write(k + " ");
                    i++;

                }
                k++;

            }

        }
        private static bool CheckNumber(int num)
        {
            int sum = 1;
            for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;
            return (sum == num);
        }
        public void PerfectNum()
        {
            Console.WriteLine("Задача № 20. Проверить, является ли заданное натуральное число совершенным");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (CheckNumber(number)) Console.WriteLine("Совершенное"); else Console.WriteLine("Не совершенное");
        }





        static void Main(string[] args)
          {
            
          }
    }
}
