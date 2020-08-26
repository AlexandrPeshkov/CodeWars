using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kata.Juniour
{
    public static class UniqueInOrderSolution
    {
        /// <summary>
        /// Implement the function unique_in_order which takes
        /// as argument a sequence and returns a list of items without any elements
        /// with the same value next to each other and preserving the original order of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iterable"></param>
        /// <returns></returns>
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null)
            {
                yield return default;
            }

            IEnumerator<T> enumerator = iterable.GetEnumerator();
            T curent = default;

            bool isMoved;
            do
            {
                isMoved = enumerator.MoveNext();
                if (isMoved)
                {
                    T prev = curent;
                    curent = enumerator.Current;
                    if (System.Object.Equals(prev, curent) == false)
                    {
                        yield return curent;
                    }
                }
            } while (isMoved == true);
        }
    }
}