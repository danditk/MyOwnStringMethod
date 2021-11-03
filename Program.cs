using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //string z = "";
            //object x = 1;
            //object y = "Tekstowo";
            string userText = TextGenerator("Jestem %0, mam %5 lata i lubię %1, a moja %2, była %3 w %4", "Wiesiek", "placki", "mama", "wczorak", "klinice dermatologicznej.", 32 );
            Console.WriteLine(userText);

            Console.ReadKey();
        }

        public static string TextGenerator(string text, params object[] keyWords)
        {
            for (int i = 0; i < keyWords.Length; i++)
            {
                text = text.Replace("%" + i, keyWords[i].ToString());
            }

            return text;
        }
    }
}
