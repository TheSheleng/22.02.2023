using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using Check;

namespace ATM
{
    internal class ATM
    {
        public ATM(float cash) { Cash = cash; }
        public float Cash { get; private set; } = 0;
        public Transaction Put(Card card, int pin, float cash)
        {
            card.Put(pin, cash);
            Cash += cash;
            return new Transaction(card, cash);
        }
        public Transaction Get(Card card, int pin, float cash)
        {
            if (Cash < cash) throw new Exception("There are not enough funds in the ATM.");
            card.Get(pin, cash);
            Cash -= cash;
            return new Transaction(card, cash);
        }
    }
}
