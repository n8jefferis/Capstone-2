using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Validate
    {
        public static void ValidateOptions(string answer)
        {
            try
            {

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter a number between 1 and 5");
            }
        }
    }
}
