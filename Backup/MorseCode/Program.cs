using System;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MorseConverter converter = new MorseConverter();

            string toConvert;
            do
            {
                Console.WriteLine("Enter string to convert:");
                toConvert = Console.ReadLine();
                string morse = converter.ConvertText(toConvert);
                Console.WriteLine(morse);
            }
            while (toConvert.Length != 0);
        }
    }
}
