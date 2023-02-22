using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Card
    {
        public float Cash { get; private set; } = 0;
        public int Number { get; }
        private int pin;
        public Card(int number, int pin) 
        {
            Number = number;
            this.pin = pin;
        }
        public void Put(int pin, float cash)
        {
            if (this.pin == pin) Cash += cash;
            else throw new Exception("Incorrect pin");
        }
        public void Get(int pin, float cash)
        {
            if (this.pin == pin)
            {
                if (Cash >= cash) Cash += cash;
                else throw new Exception("Not enough funds");
            }
            else throw new Exception("Incorrect pin");
        }
    }
}
