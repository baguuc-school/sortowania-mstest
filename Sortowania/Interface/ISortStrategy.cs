namespace Sortowania.Interface
{
    public interface ISortStrategy<T> where T: struct, IComparable<T>
    {
        public T[] Sort(T[] array);
    }
}
