using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectron : CreditCard, IExpireDate
    {
        public string CardExpire()
        {
            DateTime today = DateTime.Today;

            today = today.AddMonths(11);
            today = today.AddYears(4);

            if (today.Month >= 10)
                return today.Month + "/" + today.Year;
            else
                return "0" + today.Month + "/" + today.Year;
        }

        public override string CardNumberGenerator()
        {
            string prefix = Prefix().ToString();
            int cardNumberRandom;
            int cardNumberRandom2;
            int cardNumberRandom3;
            string kontonummer;
            if (prefix.Length > 4)
            {
                cardNumberRandom = rnd.Next(10, 99);
                cardNumberRandom2 = rnd.Next(1000, 9999);
                cardNumberRandom3 = rnd.Next(1000, 9999);


                kontonummer = string.Format("{0}{1} {2} {3}", prefix.Insert(4, " "), cardNumberRandom, cardNumberRandom2, cardNumberRandom3);
                return kontonummer;
            }
            else
            {
                cardNumberRandom = rnd.Next(1000, 9999);
                cardNumberRandom2 = rnd.Next(1000, 9999);
                cardNumberRandom3 = rnd.Next(1000, 9999);

                kontonummer = string.Format("{0} {1} {2} {3}", prefix, cardNumberRandom, cardNumberRandom2, cardNumberRandom3);
                return kontonummer;
            }
        }

        public override void CreateCard(string name)
        {
            ExpireDate = CardExpire();
            KontiNumber = KontonNummer();
            CardNumber = CardNumberGenerator();
            CardHolderName = name;
        }

        public override int Prefix()
        {
            int[] prefixArray = new int[6] { 4026, 417500, 4508, 4844, 4913, 4917 };
            int randomIndex = rnd.Next(0, prefixArray.Length);
            return prefixArray[randomIndex];
        }
    }
}
