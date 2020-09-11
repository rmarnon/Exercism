using LinkedList;
using System;

public class QueueDeque<T>
{
    private TNodo<T> First;
    private TNodo<T> Last;

    public void Enqueue(T value)
    {
        if (Last is null)
        {
            Last = new TNodo<T> { Value = value };
            First = Last;
            return;
        }

        if (First.Equals(Last))
        {
            Last = new TNodo<T> { Value = value, Next = null, Previous = First };
            First.Next = Last;
            First.Previous = null;
        }
        else
        {
            var _new = new TNodo<T> { Value = value, Next = null, Previous = Last };
            Last.Next = _new;
            Last = _new;
        }
    }


    public T Dequeue()
    {
        if (First is null)
            throw new ArgumentException("Fila vazia1");       

        T value = First.Value;

        if (First.Equals(Last))
        {
            First = null;
            Last = null;
        }
        else
        {
            First.Next.Previous = null;
            First = First.Next;            
        }
        return value;
    }
}