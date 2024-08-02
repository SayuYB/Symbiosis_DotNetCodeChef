using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class WildCard
    {
        public static void CheckWildCard()
        {
            string alpha;
            bool check=true;
            Console.WriteLine("Enter the String - ");
            alpha = Console.ReadLine();

            //Check for wild cards
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha.Contains('*') || alpha.Contains('?') || alpha.Contains('%'))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if(check==true)
            {
                Console.WriteLine($"The String {alpha} contains Wild Card.");

            }
            else
            {
                Console.WriteLine($"The String {alpha} does not contain any Wild Card");
            }

        }
        static void Main(string[] args)
        {
            WildCard.CheckWildCard();
        }
    }
}
