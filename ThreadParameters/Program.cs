using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Введите x = ");
            x = Int32.Parse(Console.ReadLine());

            MultTable mult = new MultTable(x);

            Thread myThread = new Thread(new ThreadStart(mult.Multiply));
            myThread.Start();

            Console.ReadLine();
        }
    }
    class MultTable
    {
        private int x;

        public MultTable(int _x)
        {
            this.x = _x;
        }
        public void Multiply()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i*x + "\t");
                Thread.Sleep(300);
            }
        }
    }
}
