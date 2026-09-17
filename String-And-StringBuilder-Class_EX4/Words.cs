using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_And_StringBuilder_Class_EX4
{
    public class Words
    {
        private string word;

        public Words(string _word)
        {
            word = _word;
        }

        public void SetWord(string _word)
        {
            word = _word;
        }

        public int Count()
        {
            return word.Length;
        }

        public int Count(char character)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                    count++;
            }

            return count;
        }

        public string Replace(char charToReplace, char newChar)
        {
            string newString = "";
            int firstIndex = word.IndexOf(charToReplace);
            int lastIndex = word.LastIndexOf(charToReplace);

            for (int i = 0; i < word.Length; i++)
            {
                if (i == firstIndex || i == lastIndex)
                    newString += newChar;
                else
                    newString += word[i];
                
            }

            return newString;
        }

        public void ThisIs()
        {
            string str = "This is a good ";
            StringBuilder sb = new StringBuilder(str);
            sb.Append("start.");
            sb.Replace("start.", "end.");
            sb.Insert(sb.ToString().IndexOf("a"), "not ");

            Console.WriteLine(sb.ToString(sb.ToString().IndexOf("not"), 3));
            sb.Remove(sb.ToString().IndexOf("not"), 4);
            sb.Replace('a', 'A');
            Console.WriteLine(sb.ToString(9, 1));
            Console.WriteLine(sb.ToString());

        }

        public bool IsAnagram(string wd)
        {
            if (wd.Length != word.Length)
                return false;

            StringBuilder sb = new StringBuilder(wd);

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                int index = sb.ToString().IndexOf(word[i]);

                if (index == -1)
                    return false;

                sb.Remove(index, 1);
            }

            return sb.Length == 0;
        }

        public bool IsAnagramIgnoreCase(string wd)
        {
            if (wd.Length != word.Length)
                return false;

            StringBuilder sb = new StringBuilder(wd);

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                int index = sb.ToString().ToLower().IndexOf(word[i].ToString().ToLower());

                if (index == -1)
                    return false;

                sb.Remove(index, 1);
            }

            return sb.Length == 0;
        }

        public bool IsAnagramIgnoreCaseNSpace(string wd)
        {
            StringBuilder sb = new StringBuilder(wd);

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                if (!char.IsLetterOrDigit(sb[i])) 
                { 
                    sb.Remove(i, 1); 
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetterOrDigit(word[i]))
                    continue;

                int index = sb.ToString().ToLower().IndexOf(word[i].ToString().ToLower());

                if (index == -1)
                    return false;

                sb.Remove(index, 1);
            }

            return sb.Length == 0;
        }

        public override string ToString()
        {
            return word;
        }
    }
}
