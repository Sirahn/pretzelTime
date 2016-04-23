using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pretzelTime
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double pretzelPrice = 20.99;

            

            Console.WriteLine("Ooooooo...Welcome to the Magic Pretzel shop.");
            Console.WriteLine("\n*******************************************");
            Console.WriteLine("\nI will be honest, the pretzel is a bit on the expensive side...");
            Console.WriteLine("\nGreat news though, there is a 10% discount for buying 7 or more pretzels, Just saying");
            Console.Write("\nHow many Pretzels would you like my dear?: ");
            int pretzelAmount = int.Parse(Console.ReadLine());
            Console.Clear();
            double total = pretzelPrice * pretzelAmount;
            double tax = .08 * total;
           
            double discount = total*.10;

            if (pretzelAmount<7)
            {
                Console.WriteLine("\nThanks for your business!");
                Console.WriteLine("\nYour total with the tax included is:  $"+ Math.Round(total+tax,2));//Math.Round rounds the price
                Console.WriteLine("\nNext time purchase more pretzels for a discount!");
            }
              
            else if(pretzelAmount>20)
            {
                Console.WriteLine("\nBig party coming up?  A high roller like yourself definately gets a discount!");
                Console.WriteLine("\nYour discount is: $" + Math.Round(discount));
                Console.WriteLine("\nYour total plus the 8% sales tax is:  $" + Math.Round(total - discount + tax, 2));
                Console.WriteLine("\nThanks for your your business friend");


            }
            else if(pretzelAmount>7 || pretzelAmount<19)
            {
                Console.WriteLine("\nOk, looks like you get a discount! Your discount is: $"+ Math.Round(discount));    //Math.Round rounds down the price.
                Console.WriteLine("\nYour total plus the 8% sales tax is:  $" + Math.Round(total-discount+tax,2));
                Console.WriteLine("\nThanks for your your business friend!");
            }
            
            
        }
    }
}
