using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixing
{
    public class Mixer
    {
        public int CharCounter(string input, char character)
        {
            var result = input.Where(c => c == character);

            return result.Count();
        }

        public List<string> FormatResult(List<string> input)
        {
            var result = input.OrderByDescending(r => r.Length).ThenBy(r => r[0] == '=').ThenBy(r => r).ToList();

            return result;
        }

        public string Mix(string s1, string s2)
        {
            var UniqueCharacters = (s1 + s2).Distinct();

            var combinedResult = new List<string>();

            foreach (var character in UniqueCharacters)
            {
                if (char.IsLetter(character) && character == char.ToLower(character) )
                {
                    var chunk = string.Empty;

                    var results1 = CharCounter(s1, character);
                    var resultts2 = CharCounter(s2, character);

                    var total = results1 > resultts2 ? results1 : resultts2;

                    if (total >= 2)
                    {
                        if (results1 > resultts2)
                        {
                            chunk += "1:";

                        }
                        else if (results1 < resultts2)
                        {
                            chunk += "2:";
                        }
                        else
                        {
                            chunk += "=:";
                        }

                        for (int i = 0; i < total; i++)
                        {
                            chunk += character;
                        }

                        chunk += "/";

                        combinedResult.Add(chunk);

                    }
                }
            }

            combinedResult = FormatResult(combinedResult);
            var result = "";

            foreach (var chunk in combinedResult)
            {
                result += chunk;
            }

            if (result.Length >= 1)
            {
                return result.Substring(0, result.Length - 1);
            }
            else
            {
                return "";
            }
        }
    }
}