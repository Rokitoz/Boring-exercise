using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Душные_субботние_задания
{
    internal class Program
    {
        static void print(string message)
        { Console.WriteLine($"{message}"); }



        static void Main(string[] args)
        {
            /*
            //4.6. Известна масса каждого груза, загружаемого в автомобиль.
            //Выяснить, не превысила ли общая масса всех грузов грузоподъемность автомобиля. 
            float gruz1 = Convert.ToSingle(Console.ReadLine());
            float gruz2 = Convert.ToSingle(Console.ReadLine());
            float sumkagruzov = gruz1 + gruz2;
            float gruzopodemoest = 1000f;
            if (sumkagruzov >= gruzopodemoest)
            {
                Console.WriteLine("Поместиться");
            }
            else
            {
                Console.WriteLine("Не Поместиться");
            }
            */
            /*
            //4.7.Известны результаты(в баллах) двух спортсменов-десятиборцев в каждом из десяти видов спорта.
            //Определить, кто из них показал лучший результат. 
            int[] athlete1 = { 700, 850, 900, 780, 600, 720, 810, 880, 750, 670 };
            int[] athlete2 = { 680, 840, 890, 760, 610, 730, 800, 860, 740, 690 };
            int totala1 = 0;
            int totala2 = 0;
            for (int i = 0; i < athlete1.Length; i++)
            {
                totala1 += athlete1[i];
                totala2 += athlete2[i];

            }
            if (totala1 > totala2)
            {
                Console.WriteLine("1 круче");

            }
            else if (totala2 > totala1)
            {
                Console.WriteLine("2 круче");
            }
            else
            {
                Console.WriteLine("Равны");
            }
            */
            /*
            //4.8.Известны стоимости каждого из восьми предметов в двух наборах.
            //Какой из наборов предметов более дешевый?
            int[] nabor1 = { 700, 850, 900, 780, 600, 720, 810, 880,};
            int[] nabor2 = { 680, 840, 890, 760, 610, 730, 800, 860,};
            int totala1 = 0;
            int totala2 = 0;
            for (int i = 0; i < nabor1.Length; i++)
            {
                totala1 += nabor1[i];
                totala2 += nabor2[i];

            }
            if (totala1 > totala2)
            {
                Console.WriteLine("2 дешевле ");

            }
            else if (totala2 > totala1)
            {
                Console.WriteLine("1 дешевле");
            }
            else
            {
                Console.WriteLine("Равны");
            }
            */
            /*
            //4.9.Даны числа a1, a2, …, a8.
            //Верно ли, что их произведение меньше 10 000 ?
            float a1 = Convert.ToSingle(Console.ReadLine());
            float a2 = Convert.ToSingle(Console.ReadLine());
            float a3 = Convert.ToSingle(Console.ReadLine());
            float a4 = Convert.ToSingle(Console.ReadLine());
            float a5 = Convert.ToSingle(Console.ReadLine());
            float a6 = Convert.ToSingle(Console.ReadLine());
            float a7 = Convert.ToSingle(Console.ReadLine());
            float a8 = Convert.ToSingle(Console.ReadLine());
            float proisvedenie = a1 * a2 * a3 * a4 * a5 * a6 * a7 * a8;
            if (proisvedenie < 10000)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕ");
            }
            */
            /*
            //4.10 Даны натуральное число n и вещественные числа d1, d2, …, d8.
            //Верно ли, что произведение вещественных чисел больше s? 
            Console.Write("Введите числj s");
            double s = double.Parse(Console.ReadLine());
            double[] spisok = new double [8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите числа d{i+1}");
                spisok[i] = double.Parse(Console.ReadLine());
            }

            double proizvedenie = 1;
            for (int i = 0; i < 8; i++)
            {
                proizvedenie *= spisok[i];
            } 
                
            if (proizvedenie > s)
            {
                print("Да");
            }
            else
            {
                print("Нет");
            }
            */
            /*
            //4.11. Даны целые числа b1, b2, …, b10. Выяснить:
            //а) верно ли, что сумма тех из них, которые больше 20, превышает 100;
            //б) верно ли, что сумма тех из них, которые меньше 50, есть четное число.

            double[] spisok = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите числа d{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double summa20 = 0;
            double summa50 = 0;
            for (int i = 0; i < spisok.Lenght; i++)
            {
                if (spisok[i] > 20)
                {
                    summa20 += spisok[i];
                }
                if (spisok[i] < 50)
                {
                    summa50 += spisok[i];
                }

            }
            if (summa20 > 100)
            {
                print("Пункт а выполняется");
            }
            else
            {
                print("а не выполняется");
            }
            if (summa50 % 2 == 0)
            {
                print("Пункт б выполняется");
            }
            else
            {
                print("б не выполняется");
            }
            */
            /*
            //4.12.Даны натуральное число n и целые числа a1, a2, …, an.Выяснить:
            //а) верно ли, что сумма тех чисел ai, которые меньше 20,5, не превышает 50;
            //б) верно ли, что сумма тех чисел ai, которые не превышают 10, кратна трем. 
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите числа a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double summaa = 0;
            double summab = 0;
            for (int i = 0;i < spisok.Length;i++)
            {
                if (spisok[i] > 20.5f)
                {
                    summaa += spisok[i];
                }
                if (spisok[i] < 10f)
                {
                    summab += spisok[i];
                }
            }
            if (summaa < 50)
            {
                Console.WriteLine("A выполняется");
            }
            if (summab % 3 == 0)
            {
                Console.WriteLine("б выполняется");
            }    
            */
            /*
            //4.13.Даны натуральное число n и вещественные числа x1, x2, …, xn.
            //Выяснить, верно ли, что сумма тех вещественных чисел, которые больше 20,5, меньше p. 
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p: ");
            int p = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите числа x{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double summaa = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > 20.5f)
                {
                    summaa += spisok[i];
                }

            }
            if (summaa < p)
            {
                Console.WriteLine("Верное");
            }
            else
            {
                Console.WriteLine("NAH");
            }
            */
            /*
            // 4.14. Даны натуральное число n и целые числа a1, a2, …, an.
            // Выяснить, верно ли, что сумма тех чисел ai , которые не больше m, превышает q.
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите числа x{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double AII = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                    AII += spisok[i];
            }
            if (m < AII && AII < q)
            {
                Console.WriteLine("Верное");
            }
            else
            {
                Console.WriteLine("NAH");
            }
            */
            /*
            //4.15. Даны натуральное число n и целые числа d1, d2, … , dn.
            //Выяснить, верно ли, что сумма тех чисел di , которые не превышают m, кратна целому числу p.
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("P: ");
            int P = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите числа x{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double AII = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                AII += spisok[i];
            }
            if (AII > m)
            {
                if (AII % P == 0)
                {
                    Console.WriteLine("ДА");
                }
            }
            else
            {
                Console.WriteLine("NAH");
            }
            */
            /*
            //4.16. Известны данные о количестве осадков, выпавших за каждый день февраля.
            //Верно ли, что по четным числам выпало больше осадков, чем по нечетным? Использовать только один оператор цикла.
            int[] precipitation = { 1, 3, 2, 4, 1, 5, 3, 6, 2, 1, 4, 3, 5, 2, 6, 1, 4, 5, 3, 2, 1, 6, 3, 5, 4, 1, 2, 6 };
            int chetosadki = 0;
            int netosadki = 0;

            for (int i = 0; i < precipitation.Length; i++) 
            {
                if ((precipitation[i] + 1) % 2 == 0)
                {
                    chetosadki += precipitation[i];
                }
                else
                {
                    netosadki += precipitation[i];
                }
                    
            }
            if (chetosadki > netosadki)
            {
                Console.WriteLine("Да");
            }
            else if (chetosadki < netosadki)
            {
                Console.WriteLine("Нет");
            }
            else
            {
                Console.WriteLine("Равны");
            }
            */
            /*
            //4.17. Известно число жителей, проживающих в каждом доме улицы.
            //Нумерация домов проведена подряд. Дома с нечетными номерами расположены на одной стороне улицы, с четными — на другой.
            //На какой стороне улицы проживает больше жителей? Использовать только один оператор цикла.
            int[] precipitation = { 1, 3, 2, 4, 1, 5, 3, 6, 2, 1, 4, 3, 5, 2, 6, 1, 4, 5, 3, 2, 1, 6, 3, 5, 4, 1, 2, 6 };
            int chetosadki = 0;
            int netosadki = 0;

            for (int i = 0; i < precipitation.Length; i++)
            {
                if ((precipitation[i] + 1) % 2 == 0)
                {
                    chetosadki += precipitation[i];
                }
                else
                {
                    netosadki += precipitation[i];
                }

            }
            if (chetosadki > netosadki)
            {
                Console.WriteLine("На первой");
            }
            else if (chetosadki < netosadki)
            {
                Console.WriteLine("На второй");
            }
            else
            {
                Console.WriteLine("Равны");
            }
            */
            /*
            //4.18. Даны целые числа a1, a2, …, a10..
            //Выяснить, верно ли, что количество положительных чисел не превышает 5.
            double[] spisok = new double[10];
            int minussumma = 0;
            int plussumma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите числа d{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0;i < spisok.Length; i++)
            {
                if (spisok[i] >= 0)
                {
                    plussumma += 1;
                }
                else
                {
                    minussumma += 1;
                }
            }
            if (plussumma > 5)
            {
                print("Да");
            }
            else
            {
                print("Нет");
            } 
            */
            /*
            //4.19. Даны вещественные числа a1, a2, …, a10.
            //Выяснить, верно ли, что количество тех из них, которые не больше 50,55, кратно четырем.
            double[] spisok = new double[10];
            for (int i = 0; i < 10 ; i++)
            {
                Console.Write($"Введите a{i+1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0;i < spisok.Length ; i++)
            {
                if (spisok[i] < 50.55f)
                {
                    ++count;
                }
            }
            if (count % 4  == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            */
            /*
            //4.20.Даны натуральное число n и целые числа a1, a2, …, an.
            //Выяснить, верно ли, что количество тех чисел ai, которые меньше 20, равно пяти. 
            int n = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0;i < spisok.Length; i++)
            {
                if (spisok[i] < 20)
                {
                    ++count;
                }
            }
            if (count == 5)
            {
                print("YES");
            }
            else
            {
                print("NAH");
            }
            */
            /*
            //4.21.Даны натуральное число m и целые числа d1, d2, …, dm.
            //Выяснить, верно ли, что количество положительных чисел di кратно трем.
            int n = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] >= 0)
                {
                    ++count;
                }
            }
            if (count % 3 == 0)
            {
                print("YES");
            }
            else
            {
                print("NAH");
            }
            */
            /*
            //4.22.Даны натуральное число n и целые числа a1, a2, …, an.
            //Выяснить, верно ли, что количество отрицательных чисел ai превышает x.
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] < 0)
                {
                    ++count;
                }
            }
            if (count > x)
            {
                print("YES");
            }
            else
            {
                print("NAH");
            }
            */
            /*
            //4.23. Даны натуральное число m и целые числа a1, a2, …, am.
            //Выяснить, верно ли, что количество тех чисел ai , которые больше m, кратно целому числу p. 
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("p: ");
            int p = int.Parse(Console.ReadLine());
            double[] spisok = new double[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > m)
                {
                    ++count;
                }
            }
            if (count % p == 0)
            {
                print("YES");
            }
            else
            {
                print("NAH");
            }
            */
            /*
            //4.24.Известны оценки ученика по 12 - ти предметам.
            //Верно ли, что среди них нет троек? Можно ли в программе использовать оператор цикла с условием ?
            int[] spisok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            bool flag = false;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] == 3)
                {
                    flag = true;
                }   
            }
            if (flag)
            {
                Console.WriteLine("Нет");
            }
            else 
            {
                Console.WriteLine("Верное");
            } 
            */
            /*
            //4.25.Известны данные о количестве осадков, выпавших за каждый день марта.
            //Верно ли, что осадков не было 10 дней в месяц? Можно ли в программе использовать оператор цикла с условием?
            Random random = new Random();
            int[] precipitation = new int[31];
            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = random.Next(0, 12); 
            }
            int count = 0;
            for (int i = 0; i < precipitation.Length; i++)
            {
                if (precipitation[i] == 0)
                {
                     ++count;
                }
            }
            if (count >= 10)
            {
                print("Да");
            }
            else
            {
                print("Nahg");
            }
            */
            /*
            //4.26. Известны стоимости (в долларах) нескольких марок легковых автомобилей и мотоциклов.
            //Верно ли, что средняя стоимость автомобилей превышает среднюю стоимость мотоциклов более чем в 3 раза?
            //Стоимость одного автомобиля превышает $5000, что больше стоимости любой марки мотоцикла. 
            int[] carPrices = { 20000, 15000, 22000, 18000, 25000, 30000 };
            int[] motorcyclePrices = { 5000, 4500, 4000, 3500, 3000, 2500 };
            double sumcars = 0;
            double summotor = 0;

            for (int i = 0; i < carPrices.Length; i++)
            {
                sumcars += carPrices[i];
            }
            for (int i = 0; i < carPrices.Length; i++)
            {
                summotor += motorcyclePrices[i];
            }
            double averagecarpice = sumcars / carPrices.Length;
            double averagemotorcyclepice = summotor / motorcyclePrices.Length;
            if (averagecarpice > averagemotorcyclepice)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            */
            /*
            //4.27. Известен рост каждого ученика класса.
            //Рост мальчиков условно задан отрицательными числами.
            //Верно ли, что средний рост мальчиков превышает средний рост девочек более чем на 10 см?
            int[] studentHeights = { -150, -155, -160, -145, 160, 165, 150, 155 };
            double sum1 = 0;
            int count1 = 0;
            int count2 = 0;
            double sum2 = 0;
            for (int i = 0; i < studentHeights.Length; i++)
            {
                if (studentHeights[i] > 0)
                {
                    sum1 += studentHeights[i];
                    count1++;
                }
                else
                {
                    sum2 += studentHeights[i];
                    count2++;
                }
            }
            sum1 *= -1;
            double avg1 = sum1 / count1;
            double avg2 = sum2 / count2;
            if ((avg1 - avg2) > 10)
            {
                print("Верно");
            }
            else
            {
                print("Не верно");
            }
            */
            /*
            //4.28. Даны вещественные числа b1, b2, …, b9.
            //Определить среднее арифметическое тех из них, которые больше 10.
            //Допустить, что чисел, больших 10, среди заданных может не быть. 
            double[] spisok = new double[9];
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            double summa = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] >= 10)
                {
                    summa += spisok[i];
                    ++count;
                }    
            }
            if (count > 0) 
            {
                double avg = summa / count;
                print($"Среднее арифметическое значение чисел больших 10: {avg}");
            }
            else
            {
                print("Чисел больше 10 нету");
            }    
            */
            /*
            //4.29. Даны натуральное число х и целые числа a1, a2, …, ax.
            //Определить среднее арифметическое тех чисел ai , которые больше некоторого числа n.
            //Допустить, что чисел, больших n, среди заданных может не быть. 
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            double[] spisok = new double[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }

            int count = 0;
            double summa = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] >= n)
                {
                    summa += spisok[i];
                    ++count;
                }
            }

            if (count > 0)
            {
                double avg = summa / count;
                print($"Среднее арифметическое значение чисел больших n: {avg}");
            }
            else
            {
                print("Чисел больше n нету");
            }
            */
            /*
            //4.30.Даны целые числа a1, a2, …, a12.
            //Определить среднее арифметическое четных из них.
            //Допустить, что четных чисел среди заданных может не быть. 
            double[] spisok = new double[12];
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            double summa = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] % 2 == 0)
                {
                    summa += spisok[i];
                    ++count;
                }
            }

            if (count > 0)
            {
                double avg = summa / count;
                print($"Среднее арифметическое чётных: {avg}");
            }
            else
            {
                print("Чётных  нету");
            }
            */
            /*
            //4.31. Даны натуральное число m и целые числа a1, a2, …, am.
            //Определить среднее арифметическое тех чисел ai , которые кратны числу n.
            //Допустить, что чисел, кратных n, среди заданных может не быть.
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            double[] spisok = new double[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            double summa = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] % n == 0)
                {
                    summa += spisok[i];
                    ++count;
                }
            }

            if (count > 0)
            {
                double avg = summa / count;
                print($"Среднее арифметическое кратных: {avg}");
            }
            else
            {
                print("кратных  нету");
            }
            */
            /*
            //4.32.Даны натуральное число n и целые числа a1, a2, …, an.
            //Найти номер последнего числа, равного 100.
            //Допустить, что чисел, равных 100, среди заданных может не быть.
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            double[] spisok = new double[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int lastsotka = -1;
            for (int i = a - 1; i >= 0; i--)
            {
                if (spisok[i] == 100)
                {
                    lastsotka = i;
                }
            }
            if (lastsotka == -1)
            {
                print($"НЕТУ");
            }
            else
            {
                print($"last sotka : {lastsotka}");
            }
            */
            //4.33.Даны натуральное число k и целые числа a1, a2, …, ak.
            //Найти номер последнего отрицательного числа.Допустить, что отрицательных чисел среди заданных может не быть. 
            /*
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            double[] spisok = new double[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите число a{i + 1}: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            int lastsotka = -1;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] < 0)
                {
                    lastsotka = i + 1;
                }
            }
            if (lastsotka == -1)
            {
                print($"кратных  нету");
            }
            else
            {
                print($"last sotka : {lastsotka}");
            }
            */
            /*
            //4.34 Даны натуральное число n и целые числа a1, a2, …, an.
            //Верно ли, что максимальное из чисел ai превышает минимальное не более чем на 25.
            Console.Write("Введите n");
            int n = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите a{i + 1}");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double max = -9999999999999;
            double min = 9999999999999999;

            for (int i = 0; i < spisok.Length; i++)
            {
                if ( spisok[i] > max )
                {
                    max = spisok[i];
                }
                if (spisok[i] < min)
                {
                    min = spisok[i];
                }
            }
            double razniza = max - min;
            if (razniza <= 25)
            {
                print("Верно");
            }
            else
            {
                print("NAH");
            }
            */
            /*
            //4.35.Известна масса каждого человека из группы.
            //Верно ли, что масса самого тяжелого из них превышает массу самого легкого более чем в 2 раза.
            int[] spisok = { 50, 70, 85, 40, 120, 60, 90 };
            double max = -999999999999;
            double min = 9999999999999999;

            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > max)
                {
                    max = spisok[i];
                }
                if (spisok[i] < min)
                {
                    min = spisok[i];
                }
            }
            double razniza = max / min;
            if (razniza >= 2)
            {
                print("Верно");
            }
            else
            {
                print("NAH");
            */
            /*
            //4.36.Даны натуральное число n и целые числа x1, x2, …, xn.
            //Какое число в последовательности чисел xi встретится раньше: максимальное или минимальное.
            //Если максимальных или минимальных чисел несколько, то должны быть учтены самые первые из них.
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] spisok = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите a{i +1 }: ");
                spisok[i] = double.Parse(Console.ReadLine());
            }
            double max = -999999999999;
            double min = 9999999999999999;

            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > max)
                {
                    max = spisok[i];
                }
                if (spisok[i] < min)
                {
                    min = spisok[i];
                }
            }
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] == min)
                {
                    print($"Минимальное первое");
                    break;
                }
                if (spisok[i] == max)
                {
                    print($"Максимальное первое");
                    break;
                }
            }
            */
            /*
            //4.37. Известен возраст группы людей в списке.
            //Какой человек указан в списке раньше: самый старший или самый молодой?
            //(Должны учитываться первые из людей одинакового возраста). 
            int[] spisok = { 50, 70, 85, 40, 120, 60, 90 };
            double max = -999999999999;
            double min = 9999999999999999;

            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > max)
                {
                    max = spisok[i];
                }
                if (spisok[i] < min)
                {
                    min = spisok[i];
                }
            }
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] == min)
                {
                    print($"Младший первее");
                    break;
                }
                if (spisok[i] == max)
                {
                    print($"Старший первее");
                    break;
                }
            }
            */
            //4.38.Известны результаты(время в минутах), показанные автогонщиком — участником соревнований «Формула - 1» — на каждом этапе.
            //Известно также, что на одном этапе он занял первое место и на одном — последнее.
            //Верно ли, что этап, который он выиграл, был раньше этапа, на котором он занял последнее место? 
            /*
            int[] spisok = { 120, 110, 125, 105, 135, 115, 140, 130 };

            double max = -999999999999;
            double min = 9999999999999999;

            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] > max)
                {
                    max = spisok[i];
                }
                if (spisok[i] < min)
                {
                    min = spisok[i];
                }
            }
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] == min)
                {
                    print($"1 первее");
                    break;
                }
                if (spisok[i] == max)
                {
                    print($"Последнее первее");
                    break;
                }
            }
            */
            /*
            //4.39.Даны 20 чисел, образующие неубывающую последовательность.
            //Несколько чисел, идущие подряд, равны между собой.
            //Найти количество таких чисел. Сколько различных чисел имеется в последовательности? 
            int[] spisok = { 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9, 10, 10 };
            int kolichestvopovtorya = 0;
            int unique = 1;
            for (int i = 1; i < spisok.Length; i++)
            {
                if (spisok[i] == spisok[i - 1])
                {
                    ++kolichestvopovtorya;
                }
                else
                {
                    ++unique;
                }   
                    
            }
            print($"количество потворяющихся: {kolichestvopovtorya}");
            print($"Уникальных: {unique}");
            */
            //4.40. Даны 30 чисел, образующих неубывающую последовательность.
            //Найти количество различных чисел в последовательности. 
            /*
            int[] spisok = { 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15 };
            int kolichestvopovtorya = 0;
            int unique = 1;
            for (int i = 1; i < spisok.Length; i++)
            {
                if (spisok[i] == spisok[i - 1])
                {
                    ++kolichestvopovtorya;
                }
                else
                {
                    ++unique;
                }

            }

            print($"Уникальных: {unique}");
            */
            /*
            //4.42. Дано натуральное число.
            //Выяснить, является ли оно простым (простым называется натуральное число, большее 1, не имеющее других делителей, кроме единицы и самого себя).
            //Оператор цикла с условием не использовать. 
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("Число должно быть больше 1.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} является простым числом.");
            }
            else
            {
                Console.WriteLine($"{number} не является простым числом.");
            }
            */
            /*
            //4.43.Натуральное число называется совершенным,
            //если оно равно сумме своих делителей, включая 1 и, естественно, исключая это самое число.
            //Например, число 6 — совершенное(6 1 2 3).Дано натуральное число. Выяснить, является ли оно совершенным. 
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());
            double sumkadelete = 0;



            
           for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumkadelete += i;
                }
            }    


            if (number == sumkadelete)
            {
                Console.WriteLine($"{number} является совершеным числом.");
            }
            else
            {
                Console.WriteLine($"{number} не является совершеным числом.");
            }
            */

        }
    }
}
