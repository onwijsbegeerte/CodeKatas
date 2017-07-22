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

  }
}