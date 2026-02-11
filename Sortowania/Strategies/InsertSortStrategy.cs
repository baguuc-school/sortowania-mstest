using Sortowania.Interface;

namespace Sortowania.Strategies
{
    public class InsertSortStrategy<T> : ISortStrategy<T> where T : struct, IComparable<T>
    {
        public T[] Sort(T[] arr)
        {
            for (int i = 1; i < arr.Count(); i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
