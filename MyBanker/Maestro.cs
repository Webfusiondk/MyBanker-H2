using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Maestro : CreditCard, IExpireDate
    {
        public string CardExpire()
        {
            DateTime today = DateTime.Today;

            today = today.AddMonths(8);
            today = today.AddYears(5);

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
            int cardNumberRandom4 = rnd.Next(100, 999);

            string kontonummer = string.Format("{0} {1} {2} {3} {4}", Prefix(), cardNumberRandom, cardNumberRandom2, cardNumberRandom3, cardNumberRandom4);
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
            int[] prefixArray = new int[9] { 5018, 5020, 5893, 5038, 6304, 6759, 6761, 6762, 6763 };
            int randomIndex = rnd.Next(0, prefixArray.Length);
            return prefixArray[randomIndex];
        }

    }
}
