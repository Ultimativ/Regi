using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input;
            while (true)         
            {
            Console.WriteLine("Guten Tag lieber User");

            input = Console.ReadLine();

                switch (input)
                
                {
                
                    case "/regi":
                        Console.WriteLine("/Name , /bday , /e-mail,");
                        break;

                    case "/Name":
                        Console.WriteLine("Bitte geben sie ihren Namen an");
                        break;

                    case "/bday":
                        Console.WriteLine("Bitte geben sie ihr Geburtsdatum an");
                        break;

                    case "/e-mail":
                        Console.WriteLine("Bitte geben sie ihre E-mail adresse ein");
                        break;

                    

                    default:
                        {
                            Console.WriteLine("Unknown, type /regi");
                            break;
                      
                        }

                }

           

            }
           

        }
    }
}
