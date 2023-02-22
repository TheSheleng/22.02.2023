using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal interface ICheck
    {
        void Print(Card card, float cash);
    }
    class ConsoleChesk : ICheck
    { 
        public void Print(Card card, float cash)
        {
            Console.WriteLine($"There was a transaction in the amount of ${cash}, now there are ${card.Cash} on your card");
        }
    }
}
