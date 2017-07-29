using System;
using System.Collections.Generic;
using System.Linq;

namespace DoubleCola
{
    public class Line
    {
        public string WhoIsNext(string[] names, long n)
        {
            var list = new List<int[]>();
            long index = 1;

            for (int i = 0; i < names.Length; i++)
            {
                var chunk = new int[2] { i, 1 };
                list.Add(chunk);
            }

            while(index < n)
            {
                var firstChunk = list.FirstOrDefault();
                var currentChunkSize = firstChunk[1];
                var rotationLeft = n - index;

                if (currentChunkSize < rotationLeft)
                {
                    index += firstChunk[1];
                    firstChunk[1] *= 2;
                    list.Add(firstChunk);
                    list.RemoveAt(0);
                }
                if (currentChunkSize == rotationLeft)
                {
                    list.RemoveAt(0);
                    break;
                }
                if (currentChunkSize > rotationLeft)
                {
                    break;
                }
            }

            return names[list.FirstOrDefault()[0]];
        }
    }
}
