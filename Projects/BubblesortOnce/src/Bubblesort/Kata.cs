using System;

namespace Bubblesort
{
    public class Kata
    {
        public int[] BubbleSortOnce(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                var left = input[i];

                if (input[i] > input[i + 1])
                {
                    input[i] = input[i + 1];
                    input[i+1] = left;
                }
            }

            return input;
        }
    }
}
