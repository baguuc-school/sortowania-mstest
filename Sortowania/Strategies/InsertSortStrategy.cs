using Sortowania.Interface;

namespace Sortowania.Strategies
{
    public class InsertSortStrategy<T> : ISortStrategy<T> where T : struct, IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            if (array.Length < 2)
            {
                // tablica za mała żeby był sens ją sortować
                return array;
            }

            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            return array;
        }
    }
}
