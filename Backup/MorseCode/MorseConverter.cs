using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCode
{
    public class MorseConverter
    {
        Dictionary<char, string> _codes;



        public MorseConverter()
        {
            _codes = new Dictionary<char, string>();
            _codes.Add('A', ".-");
            _codes.Add('B', "-...");
            _codes.Add('C', "-.-.");
            _codes.Add('D', "-..");
            _codes.Add('E', ".");
            _codes.Add('F', "..-.");
            _codes.Add('G', "--.");
            _codes.Add('H', "....");
            _codes.Add('I', "..");
            _codes.Add('J', ".---");
            _codes.Add('K', "-.-");
            _codes.Add('L', ".-..");
            _codes.Add('M', "--");
            _codes.Add('N', "-.");
            _codes.Add('O', "---");
            _codes.Add('P', ".--.");
            _codes.Add('Q', "--.-");
            _codes.Add('R', ".-.");
            _codes.Add('S', "...");
            _codes.Add('T', "-");
            _codes.Add('U', "..-");
            _codes.Add('V', "...-");
            _codes.Add('W', ".--");
            _codes.Add('X', "-..-");
            _codes.Add('Y', "-.--");
            _codes.Add('Z', "--..");
            _codes.Add('1', ".----");
            _codes.Add('2', "..---");
            _codes.Add('3', "...--");
            _codes.Add('4', "....-");
            _codes.Add('5', ".....");
            _codes.Add('6', "-....");
            _codes.Add('7', "--...");
            _codes.Add('8', "---..");
            _codes.Add('9', "----.");
            _codes.Add('0', "-----");
        }


        private string ConvertCharacter(char ch)
        {
            if (_codes.Keys.Contains(ch))
                return _codes[ch];
            else
                return string.Empty;
        }



        private string ConvertWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in word)
            {
                if (sb.Length != 0 && sb[sb.Length - 1] != ' ')
                    sb.Append(" ");
                sb.Append(ConvertCharacter(ch));
            }
            return sb.ToString();
        }



        public string ConvertText(string sentence)
        {
            string[] words = sentence.ToUpper().Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                if (sb.Length != 0)
                    sb.Append("/");
                sb.Append(ConvertWord(word));
            }
            return sb.ToString();
        }
    }
}
