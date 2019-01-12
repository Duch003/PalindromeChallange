using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Type your text or number. All not letters or not digits are ignored:");
                Console.WriteLine(PalindromeDetector.IsPalindrome("\n" + Console.ReadLine() + "\n"));
                Console.WriteLine("Press ENTER to repeat...");
                Console.ReadLine();
            }
        }

        
    }

    
}
