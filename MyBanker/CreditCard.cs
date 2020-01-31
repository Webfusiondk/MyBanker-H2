using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class CreditCard
    {
        public Random rnd = new Random();
        string cardHolderName, expireDate, cardNumber;
        int kontiNumber;


        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public int KontiNumber { get => kontiNumber; set => kontiNumber = value; }
        public string CardHolderName { get => cardHolderName; set => cardHolderName = value; }
        public string ExpireDate { get => expireDate; set => expireDate = value; }

        public abstract int Prefix();
        public abstract string CardNumberGenerator();
        public abstract void CreateCard(string name);
        public virtual int KontonNummer()
        {
            int kontoNummer = rnd.Next(1000, 9999);
            return kontoNummer;
        }

        public override string ToString()
        {
            return "Kontinummer: " + kontiNumber + "\n" + "Cardnumber: " + cardNumber + "\n" + "Navn: " + cardHolderName + "\n" + "Expire Date: " + expireDate;
        }
    }
}
