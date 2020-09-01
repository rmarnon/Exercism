using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (T item in collection)
        {
          yield return func(item);
        }
    }

    public static IEnumerable<U> AccumulateNoLazy<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> result = new List<U>();

        foreach (T item in collection)
        {
            U calculo = func(item);

            result.Add(calculo);
        }

        return result;
    }
}