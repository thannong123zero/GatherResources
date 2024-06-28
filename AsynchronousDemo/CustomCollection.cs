using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousDemo
{
    public class CustomCollection : IEnumerable
    {
        private int[] items = new int[5] { 1, 2, 3, 4, 5 };

        // Implementation of IEnumerable.GetEnumerator
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                // Yield return pauses here, returning the current item,
                // and resumes here in the next iteration.
                yield return items[i];
            }
        }
    }
}
