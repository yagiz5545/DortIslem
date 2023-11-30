using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz");
            double s1 = Convert .ToDouble(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            double s2 = Convert .ToDouble(Console.ReadLine());
            DortIslem dortIslem = new DortIslem();
            Console.WriteLine("iki sayının toplamı = " + dortIslem.Topla(s1,s2));
            Console.WriteLine("iki sayının cıkarımı = " + dortIslem.Cıkarma(s1, s2));
            Console.WriteLine("iki sayının carpımı = " + dortIslem.Carp(s1, s2));
            Console.WriteLine("iki sayının bolumu = " + dortIslem.Bolme(s1, s2));
        }


    }

    public class DortIslem
    {
        int s1 = 40;
        int s2 = 3;
        public double Topla(double s1, double s2)
        {
            return (s1 + s2);
        }
        public double Carp(double s1, double s2)
        {
            return (s1 * s2);
        }
        public double Cıkarma(double s1, double s2)
        {
            return (s1 - s2);
        }
        public double Bolme(double s1, double s2)
        {
            return (s1 / s2);
        }

    }



    }
