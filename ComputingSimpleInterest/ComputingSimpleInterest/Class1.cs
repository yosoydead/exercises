using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputToBeNumbersVerify
{
    public interface IVerify
    {
        bool verify(string x);
    }

    class Verify : IVerify
    {
        public bool verify(string x)
        {
            if (string.IsNullOrEmpty(x) ||
                string.IsNullOrWhiteSpace(x) ||
                x.Any(char.IsLetter) ||
                x.Any(char.IsPunctuation) ||
                x.Any(char.IsSeparator) ||
                Int32.Parse(x) < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input.");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
