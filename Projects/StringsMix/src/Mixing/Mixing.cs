using System;
using System.Linq;

namespace Mixing
{
    public class Mixer
    {
        public string Mix(string s1, string s2)
        {

            return "asd";
        }

        public int CharCounter(string input, char character)
        {
            var result = input.Where(c => c == character);

            return result.Count();
        }

        public string FormatInput(string input)
        {
            return new string(input.OrderBy(c => c).ToArray());
        }

        public string FormatCombine(string s1, string s2)
        {
            var x = (s1 + s2).Distinct();

            var result = "";

            foreach (var character in x)
            {
                if (char.IsLetter(character))
                {

                    var results1 = CharCounter(s1, character);
                    var resultts2 = CharCounter(s2, character);

                    var total = results1 > resultts2 ? results1 : resultts2;

                    if (total >= 2)
                    {
                        if (results1 > resultts2)
                        {
                            result += "1:";

                        }
                        else if (results1 < resultts2)
                        {
                            result += "2:";
                        }
                        else
                        {
                            result += "=:";
                        }

                        for (int i = 0; i < total; i++)
                        {
                            result += character;
                        }
                        result += "/";
                    }
                }
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}