using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            //p12();
            //p13();
            //p14();
            //p15(); de facut(n am reusit)
            p16();
            //p17();
        }

        private static void p1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                vec[i] = int.Parse(Console.ReadLine());
                sum += vec[i];
            }
            Console.WriteLine(sum);
        }

        private static void p2()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int poz = -1;
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
            {
                vec[i] = int.Parse(Console.ReadLine());
                if (vec[i] == k)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine(poz);
        }

        private static void p3()
        {
            int[] vec = { 100, -1, 5, 83, 36, 1, 2, 10, 7, 209, 975, 5, 15, -322, 29, 0, 99 };
            int min = vec[0];
            int max = vec[0];
            int pozMin = 0;
            int pozMax = 0;
            for (int i = 1; i < vec.Length; i++)
            {
                if (vec[i] < min)
                {
                    min = vec[i];
                    pozMin = i + 1;
                }
                else
                if (vec[i] > max)
                {
                    max = vec[i];
                    pozMax = i + 1;
                }
            }
            Console.WriteLine($"maxim:{pozMax}\nminim:{pozMin}");
        }

        private static void p4()
        {
            int[] vec = { 1, 7, 15, -5, 10, -5, 15, 15, 0, 2 };
            int mic = vec[0];
            int mare = vec[0];
            int nrMic = 1;
            int nrMare = 1;
            for (int i = 1; i < vec.Length; i++)
            {
                if (vec[i] < mic)
                {
                    nrMic = 1;
                    mic = vec[i];
                }
                else
                    if (vec[i] > mare)
                {
                    nrMare = 1;
                    mare = vec[i];
                }
                else
                    if (mic == vec[i])
                    nrMic++;
                else
                    if (mare == vec[i])
                    nrMare++;
            }
            Console.WriteLine($"mare:{mare} && aparitieMare: {nrMare}\nmic:{mic} && aparitieMic: {nrMic}");
        }

        private static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                vec[i] = rnd.Next(100);
            vec[k] = e;
        }

        private static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] vec = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                vec[i] = rnd.Next(100);

            for (int j = k; j < n - 1; j++)
                vec[j] = vec[j + 1];

            if (k < n)
                vec = vec.Take(n - 1).ToArray();
        }

        private static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int coada = n - 1;
            int[] vec = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                vec[i] = rnd.Next(100);

            for (int j = 0; j < n / 2; j++)
            {
                int aux = vec[j];
                vec[j] = vec[coada];
                vec[coada] = aux;
                coada--;
            }
        }

        private static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            Random rnd = new Random();
            for (int j = 0; j < n; j++)
                vec[j] = rnd.Next(100);

            int p = vec[0];
            for (int i = 0; i < n - 1; i++)
            {
                vec[i] = vec[i + 1];
            }
            vec[n - 1] = p;
        }

        private static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            Random rnd = new Random();
            for (int j = 0; j < n; j++)
                vec[j] = rnd.Next(100);

            for (int t = 0; t < k; t++)
            {
                int p = vec[0];
                for (int i = 0; i < n - 1; i++)
                {
                    vec[i] = vec[i + 1];
                }
                vec[n - 1] = p;
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
                Console.Write($"{vec[j]} ");
        }

        private static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            int poz = -1;
            Random rnd = new Random();
            for (int j = 0; j < n; j++)
                vec[j] = rnd.Next(100);
            Array.Sort(vec);

            for (int i = 0; i < n; i++)
            {
                if (vec[i] == k)
                {
                    poz = i;
                    break;
                }
            }
            for (int j = 0; j < n; j++)
                Console.Write($"{vec[j]} ");
            Console.WriteLine(poz);
        }

        private static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];

            for (int i = 2; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void p12()
        {
            int[] vec = { 5, 7, 32, 10, 71, -3, -28, 312, 100, 0 };
            int n = vec.Length;
            for (int i = 0; i < n; i++)
            {
                int k = i;

                for (int j = i; j < n; j++)
                {
                    if (vec[j] < vec[k])
                        k = j;
                }
                int aux = vec[k];
                vec[k] = vec[i];
                vec[i] = aux;
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{vec[i]} ");
            Console.WriteLine();
        }

        private static void p13()
        {
            int[] vec = { 5, 7, 32, 10, 71, -3, -28, 312, 100, 0 };
            int n = vec.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i;
                while (j > 0 && vec[j - 1] > vec[j])
                {
                    int aux = vec[j];
                    vec[j] = vec[j - 1];
                    vec[j - 1] = aux;
                    j--;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(vec[i] + " ");
            Console.WriteLine();
        }

        private static void p14()
        {
            int[] vec = { 0, 1, 2, 3, 0, 0, 4, 5, 6, 0 };
            int n = vec.Length;
            int c = n;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (vec[i] == 0)
                    {
                        int aux = vec[i];
                        vec[i] = vec[j];
                        vec[j] = aux;
                    }
                }
            for (int i = 0; i < n; i++)
                Console.Write($"{vec[i]} ");
        }

        private static void p16()
        {
            int[] vec = { 10, 2, 28, 36, 12, 16, 100, 20, 8 };
            int cmmdc = vec[0];

            for (int i = 1; i < vec.Length; i++)
                cmmdc = Calcul(cmmdc, vec[i]);

            Console.WriteLine($"cmmdc: {cmmdc}");

            int Calcul(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
        }
    }
}
