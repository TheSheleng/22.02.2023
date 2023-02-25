using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(2134325124, 1234);
            var atm = new ATM.ATM(500);

            Check.ConsoleChesk.Print(atm.Put(card, 1234, 100));
            Console.ReadKey();
        }
    }
}
