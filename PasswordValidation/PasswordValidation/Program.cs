using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("bogdan");
            list.Add("123");
            list.Add("yosoydead1");
            list.Add("bla");
            Console.WriteLine("Password? ");

            //variable to store the input
            string pw = "";

            //event checker: which key is pressed
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                //if you don't press backspace to delete
                if (info.Key != ConsoleKey.Backspace)
                {
                    //write # for each key stroke
                    Console.Write("#");
                    //add that key to the password var
                    pw += info.KeyChar;
                }
                //if you try to delete using backspace
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(pw))
                    {   
                        //delete the last character by creating a new pw var from the first char up to the last one,
                        //not included
                        pw = pw.Substring(0, pw.Length -1);
                        //function to get the cursor position in the terminal
                        int pos = Console.CursorLeft;

                        //update the last character of the string by replacing # with an empty space
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos-1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            if (!list.Contains(pw))
            {
                Console.WriteLine("i dont know you");
            }
        }
    }
}
