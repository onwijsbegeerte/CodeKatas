using System;
using System.Collections.Generic;

namespace DoubleCola
{
    public class Line
    {
        public string WhoIsNext(string[] names, long n)
        {
            Queue<string> queue = new Queue<string>(names);

            for (int i = 0; i < n; i++)
            {
                var first = queue.Dequeue();
                queue.Enqueue(first);
                queue.Enqueue(first);
            }

            return queue.Dequeue();
        }
    }
}
