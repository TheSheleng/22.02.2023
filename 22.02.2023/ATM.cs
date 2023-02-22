using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using Check;

namespace ATM
{
    internal class ATM
    {
        public float Cash { get; private set; } = 0;
        private ICheck Check { get; set; } = null;
        public void SetICheck(ICheck check) => Check = check;
        public void Put(Card card, int pin, float cash)
        {
            card.Put(pin, cash);
            Cash += cash;
            Check.Print(card, cash);
        }
        public void Get(Card card, int pin, float cash)
        {
            if (Cash < cash) throw new Exception("There are not enough funds in the ATM.");
            card.Get(pin, cash);
            Cash -= cash;
            Check.Print(card, cash);
        }
    }
}
