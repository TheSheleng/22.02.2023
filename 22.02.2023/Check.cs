using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Transaction
    { 
        public Transaction(Card card, float cash) { this.card = card; this.cash = cash; }
        public Card card { get; set; }
        public float cash { get; set; }
    }
    class ConsoleChesk
    { 
        public static void Print(Transaction transaction)
        {
            Console.WriteLine($"There was a transaction in the amount of ${transaction.cash}, now there are ${transaction.card.Cash} on your card");
        }
    }
}
