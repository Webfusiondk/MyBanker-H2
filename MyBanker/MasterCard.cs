using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MasterCard : CreditCard, IExpireDate
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
            int cardNumberRandom = rnd.Next(1000, 9999);
            int cardNumberRandom2 = rnd.Next(1000, 9999);
            int cardNumberRandom3 = rnd.Next(1000, 9999);
            string kontonummer = string.Format("{0} {1} {2} {3}", Prefix(), cardNumberRandom, cardNumberRandom, cardNumberRandom3);
            return kontonummer;
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
            int[] prefixArray = new int[5] { 51, 52, 53, 54, 55 };
            int randomIndex = rnd.Next(0, prefixArray.Length);
            return prefixArray[randomIndex];
        }
    }
}
