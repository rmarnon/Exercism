using LinkedList;

public class Deque<T>
{
    private TNodo<T> First;
    private TNodo<T> Last;

    public void Push(T value)
    {
        if (First is null)
        {
            First = new TNodo<T> { Value = value };
            return;
        }

        if (Last is null || First.Equals(Last))
        {
            Last = new TNodo<T> { Value = value, Previous = First };
            First.Next = new TNodo<T> { Value = Last.Value };
        }
        else
            Last = new TNodo<T> { Value = value, Previous = Last };
    }

    public T Pop()
    {
        T value = Last.Value;

        if (Last.Previous is not null)   
            Last = Last.Previous;

        return value;
    }

    public void Unshift(T value)
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

    public T Shift()
    {
        T value = First.Value;

        if (First.Next is not null)
            First = First.Next;

        return value;
    }
}