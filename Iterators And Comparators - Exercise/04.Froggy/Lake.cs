using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        public List<int> Elements { get; set; }
        public Lake(List<int> elements)
        {
            Elements = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Elements.Count; i += 2)
            {
                yield return Elements[i];
            }
            int startback = Elements.Count % 2 == 0 ? Elements.Count - 1 : Elements.Count - 2;
            for (int i = startback; i >= 0; i -= 2)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}