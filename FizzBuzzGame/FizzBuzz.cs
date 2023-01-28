using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
     class FizzBuzz
    {
        public string CheckNumber(int val)
        {
            if (val % 3 == 0 && val % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (val%3==0)
            {
                return "Fizz";
            }
            if (val % 5 == 0)
            {
                return "Buzz";
            }           
            return val.ToString();
        }
    }
}
