using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Extensions
{
    public static class LinqExtensions
    {
        //public static IEnumerable<TResult> Select<T, TResult>(this IEnumerable<T> source, Func<T, TResult> func)
        //{
        //    foreach (var item in source)
        //    {
        //        yield return func(item);
        //    }

        //}

        public static IEnumerable<T> Select<T>(this System.Collections.IEnumerable source, Func<object, T> func)
        {
            foreach (var item in source)
            {
                yield return func(item);
            }

        }
    }
}
