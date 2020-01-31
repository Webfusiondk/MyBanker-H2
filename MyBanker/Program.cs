using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        public static string tempString = "";
        public static int tempInt = 0;
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            while (true)
            {
                string temp = "";
                Console.WriteLine("Hvad er dit navn");
                tempString = Console.ReadLine();
                Console.WriteLine("Hvad er din alder");
                tempInt = Convert.ToInt32(Console.ReadLine());
                User user = new User(tempString, tempInt);
                if (user.Age < 15)
                {
                    Console.WriteLine("Du kan få DebitCard eller MasterCard");
                    Console.WriteLine("Skriv D for Debit M for master");
                    temp = Console.ReadLine().ToLower();
                    switch (temp)
                    {
                        case "m":
                            CreditCard M = new MasterCard();
                            M.CreateCard(user.Name);
                            Console.WriteLine(M.ToString());
                            break;
                        case "d":
                            CreditCard DC = new DebitCard();
                            DC.CreateCard(user.Name);
                            Console.WriteLine(DC.ToString());
                            break;
                    }
                }
                if (user.Age > 18 || user.Age == 18)
                {
                    Console.WriteLine("Du kan få Maestro, DebitCard, Mastercard eller Visa/Dankort");
                    Console.WriteLine("Skriv D for Debit MC for master VD for Visa M for Maestro");
                    temp = Console.ReadLine().ToLower();
                    switch (temp)
                    {
                        case "d":
                            CreditCard DC = new DebitCard();
                            DC.CreateCard(user.Name);
                            Console.WriteLine(DC.ToString());
                            break;
                        case "mc":
                            CreditCard MC = new MasterCard();
                            MC.CreateCard(user.Name);
                            Console.WriteLine(MC.ToString());
                            break;
                        case "vd":
                            CreditCard VD = new VisaDankort();
                            VD.CreateCard(user.Name);
                            Console.WriteLine(VD.ToString());
                            break;
                        case "m":
                            CreditCard M = new Maestro();
                            M.CreateCard(user.Name);
                            Console.WriteLine(M.ToString());
                            break;
                        default:
                            break;
                    }
                }
                if (user.Age == 15 || user.Age > 15)
                {
                    Console.WriteLine("Du kan få Maestro, DebitCard, Mastercard, Visa Electron eller Visa/Dankort");
                    Console.WriteLine("Skriv D for Debit MC for master VD for VisaDankort VE for VisaElectron M for Maestro");
                    temp = Console.ReadLine().ToLower();
                    switch (temp)
                    {
                        case "d":
                            CreditCard DC = new DebitCard();
                            DC.CreateCard(user.Name);
                            Console.WriteLine(DC.ToString());
                            break;
                        case "mc":
                            CreditCard MC = new MasterCard();
                            MC.CreateCard(user.Name);
                            Console.WriteLine(MC.ToString());
                            break;
                        case "vd":
                            CreditCard VD = new VisaDankort();
                            VD.CreateCard(user.Name);
                            Console.WriteLine(VD.ToString());
                            break;
                        case "m":
                            CreditCard M = new Maestro();
                            M.CreateCard(user.Name);
                            Console.WriteLine(M.ToString());
                            break;
                        case "ve":
                            CreditCard VE = new VisaElectron();
                            VE.CreateCard(user.Name);
                            Console.WriteLine(VE.ToString());
                            break;
                        default:
                            break;
                    }
                }
            }
            
        }
    }
}
