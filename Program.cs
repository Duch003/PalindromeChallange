﻿using System;
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
            var result = PalindromeDetector.IsPalindrome((double)123.21);
        }

        
    }

    
}
