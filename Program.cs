using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ellin
{
    internal class Program
    {
        #region Task-1 Bolunme
        //static void Main(string[] args)
        //{
        //start:
        //    Console.WriteLine("Reqem yazin");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("---------------------");
        //    if (num % 4 == 0 && num % 5 == 0)
        //    {
        //        Console.WriteLine("Reqem 5 ve 4-de bölünür");
        //    }
        //    else if (num % 4 != 0 && num % 5 == 0)
        //    {
        //        Console.WriteLine("Reqem 5-e bölünür");
        //    }
        //    else if (num % 4 == 0 && num % 5 != 0)
        //    {
        //        Console.WriteLine("Reqem 4-e bölünür");
        //    }
        //    else { Console.WriteLine("Reqem 5 ve 4-e bölünmür"); }
        //    Console.WriteLine("---------------------");

        //    goto start;
        //}
        #endregion

        #region Task-2 grade swich
        //public static void grade()
        //{
        //start:
        //    Console.WriteLine("Neticenizi qeyd edin");
        //    int grade = Convert.ToInt32(Console.ReadLine()) / 10;
        //    string welcome = "Sizin imtahan neticeniz :";
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("----------------------------------");
        //    switch (grade)
        //    {
        //        case 5:
        //            Console.WriteLine(welcome + "E"); break;
        //        case 6:
        //            Console.WriteLine(welcome + "D"); break;
        //        case 7:
        //            Console.WriteLine(welcome + "C"); break;
        //        case 8:
        //            Console.WriteLine(welcome + "B"); break;
        //        case 9:
        //            Console.WriteLine(welcome + "A"); break;
        //        default:
        //            Console.WriteLine("Imtahandan kesildiniz"); break;
        //    }
        //    Console.WriteLine("----------------------------------");
        //    Console.ForegroundColor = ConsoleColor.White;

        //    goto start;
        //}
        #endregion

        #region Task-3 grade if
        //public static void grade()
        //{
        //start:
        //    Console.WriteLine("Neticenizi qeyd edin");
        //    int grade = Convert.ToInt32(Console.ReadLine());
        //    string welcome = "Sizin imtahan neticeniz :";
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("----------------------------------");
        //    if (grade >= 101)
        //    {
        //        Console.WriteLine("Duzgun daxil edin");
        //    }
        //    else if (grade >= 91)
        //    {
        //        Console.WriteLine(welcome + "A");
        //    }
        //    else if (grade >= 81)
        //    {
        //        Console.WriteLine(welcome + "B");
        //    }
        //    else if (grade >= 71)
        //    {
        //        Console.WriteLine(welcome + "C");
        //    }
        //    else if (grade >= 61)
        //    {
        //        Console.WriteLine(welcome + "D");
        //    }
        //    else if (grade >= 51)
        //    {
        //        Console.WriteLine(welcome + "E");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Imtahandan kesildiniz");
        //    }

        //    Console.WriteLine("----------------------------------");
        //    Console.ForegroundColor = ConsoleColor.White;

        //    goto start;
        //}
        #endregion

        #region Task 4-7 Onluq teklikler ve yerdeyisme

        //static string write_count(int reqem, int tip)
        //{
        //    if (tip == 0)
        //    {
        //        switch (reqem)
        //        {
        //            case 1: return "bir";
        //            case 2: return "iki";
        //            case 3: return "üç";
        //            case 4: return "dörd";
        //            case 5: return "beş";
        //            case 6: return "alti";
        //            case 7: return "yeddi";
        //            case 8: return "sekkiz";
        //            case 9: return "doqquz";
        //            default: return "Proqram 1-9999 aralığınadek işleyir";
        //        }
        //    }
        //    else
        //    {
        //        switch (reqem)
        //        {
        //            case 1: return "on";
        //            case 2: return "iyirmi";
        //            case 3: return "otuz";
        //            case 4: return "qirx";
        //            case 5: return "elli";
        //            case 6: return "altmis";
        //            case 7: return "yetmis";
        //            case 8: return "seksen";
        //            case 9: return "doxsan";
        //            default: return "";
        //        }
        //    }
        //}
        //public static void main()
        //{
        //start:
        //    try
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Reqem yazin");
        //        int minlik = 0, yuzluq = 0, onluq = 0, teklik = 0;
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        teklik = Convert.ToInt32(number) % 10;
        //        onluq = ((Convert.ToInt32(number) % 100) - teklik) / 10;
        //        yuzluq = (Convert.ToInt32(number) / 100) % 10;
        //        minlik = Convert.ToInt32(number) / 1000;
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("----------------------------------------------");
        //        string write = "";
        //        if (!(minlik == 0))
        //        {
        //            Console.WriteLine("Minlik : " + minlik);
        //            if (minlik == 1)
        //            {
        //                write += "min ";
        //            }
        //            else
        //            {
        //                write += write_count(minlik, 0) + " min ";
        //            }
        //        }
        //        if (!(yuzluq == 0))
        //        {
        //            Console.WriteLine("Yuzluk : " + yuzluq);
        //            if (yuzluq == 1)
        //            {
        //                write += "yüz ";
        //            }
        //            else
        //            {
        //                write += write_count(yuzluq, 0) + " yüz ";
        //            }
        //        }
        //        if (!(onluq == 0))
        //        {
        //            Console.WriteLine("Onluq  : " + onluq);
        //            write += write_count(onluq, 1) + " ";
        //        }
        //        if (!(teklik == 0))
        //        {
        //            Console.WriteLine("Teklik : " + teklik);
        //            write += write_count(teklik, 0);
        //        }
        //        Console.WriteLine(write.ToUpper());
        //        Console.WriteLine(Convert.ToString(number).Reverse().ToArray());
        //        Console.WriteLine("----------------------------------------------");
        //        goto start;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        goto start;
        //    }
        //}



        #endregion

        #region Task 8-9 Ededi orta ve bolunme
        //public static void main()
        //{
        //    int[] reqemler = new int[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("#" + (i + 1) + " ededi qeyd edin");
        //        reqemler[i] = Convert.ToInt32(Console.ReadLine());
        //        Console.Clear();
        //    }
        //    Console.WriteLine("Qeyd etdiyiniz ededler");
        //    Console.WriteLine(reqemler[0] + " - " + reqemler[1] + " - " + reqemler[2] + " - " + reqemler[3] + " - " + reqemler[4]);

        //    int sum = 0;
        //    for (int i = 0; i < reqemler.Length; i++)
        //    {
        //        sum += reqemler[i];
        //    }
        //    double orta = sum / reqemler.Length;
        //    Console.WriteLine("-- Ededi orta " + orta + " --");
        //    if (orta % 3 == 0)
        //    {
        //        Console.WriteLine("3-e bolunur");
        //    }
        //    else
        //    {
        //        Console.WriteLine("3-e bolunmur");
        //    }
        //    Console.WriteLine("----------------------");
        //}
        #endregion
                    
    }
}


