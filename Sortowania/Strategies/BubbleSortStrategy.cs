namespace Sortowania.Strategies
{
    public class BubbleSortStrategy<T> : InsertSortStrategy<T> where T : struct, IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            if(array.Length < 2)
            {
                // tablica za mała żeby był sens ją sortować
                return array;
            }

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // sprawdz czy array[j] > array[j+1]
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
