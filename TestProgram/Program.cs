using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
//            TxtTest txtTest = new TxtTest("D:\\Ivan\\Учеба\\Кононов лабы\\ПРОЕКТЫ\\TestProgram\\TestProgram\\TextFile.txt");

            TxtTest txtTest = new TxtTest("TextFile.txt");
            txtTest.Show();
            Console.ReadLine();
        }


    }
}
