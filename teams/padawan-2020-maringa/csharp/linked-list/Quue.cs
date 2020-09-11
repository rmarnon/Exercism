using LinkedList;

public class QueueDeque<T>
{
    private TNodo<T> First;
    private TNodo<T> Last;

    public void Enqueue(T value)
    {
        if (Last is null)
        {
            Last = new TNodo<T> { Value = value };
            return;
        }

        if (First is null || First.Equals(Last))
        {
            First = new TNodo<T> { Value = value, Next = Last };
            Last.Previous = new TNodo<T> { Value = First.Value };
        }
        else
            First = new TNodo<T> { Value = value, Next = First };
    }


    public T Dequeue()
    {
        T value = Last.Value;

        if (Last.Previous is not null)
            Last = Last.Previous;

        return value;
    }
}