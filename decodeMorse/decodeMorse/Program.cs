using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decodeMorse
{
    class Program
    {
        static Dictionary<string, char> dict = new Dictionary<string, char>()
        {
            { ".-", 'A'},
            { "-...", 'B'},
            { "-.-.", 'C'},
            { "-..", 'D'},
            { ".", 'E'},
            { "..-.", 'F'},
            {"--.", 'G' },
            { "....", 'H'},
            {"..", 'I' },
            {".---", 'J' },
            {"-.-", 'K' },
            {".-..", 'L' },
            {"--", 'M' },
            {"-.", 'N' },
            {"---", 'O' },
            {".--.", 'P' },
            {"--.-", 'Q' },
            {".-.", 'R' },
            {"...", 'S' },
            {"-", 'T' },
            {"..-", 'U' },
            {"...-", 'V' },
            {".--", 'W' },
            {"-..-", 'X' },
            {"-.--", 'Y' },
            {"--..", 'Z' },
            {".----", '1' },
            { "..---", '2'},
            { "...--", '3'},
            {"....-", '4' },
            {".....", '5' },
            {"-....", '6' },
            {"--...", '7' },
            {"---..", '8' },
            {"----.", '9' },
            {"-----", '0' },
            { ".-.-.-", '.'},
            {"--..--", ',' },
            { "..--..", '?' },
            { ".----.", '\''},
            { "---...", ':'},
            {"-.-.-", ';' },
            { "-.-.--", '!'}
        };

        static string Decode(string morseCode)
        {
            string result = "";
            morseCode = morseCode.TrimStart().TrimEnd();
            var a = morseCode.Split();
            bool space = false;
            
            foreach(var item in a){
            if(dict.ContainsKey(item)){
                result += dict[item];
                space= false;
            }else if(item == "" && space == false){
                space = true;
                result += " ";
            }else if(item == "...---..."){result += "SOS";}
            }
            
            return result;
        }
        static void Main(string[] args)
        {
            string s = "...---...  .... . -.--   .--- ..- -.. .   .--- ..- -.. .   ----- ----. .....   .----";
            Console.WriteLine(Decode(s));
        }
    }
}
