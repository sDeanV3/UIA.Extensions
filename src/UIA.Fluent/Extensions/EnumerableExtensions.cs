﻿using System.Collections.Generic;
using System.Linq;

namespace UIA.Fluent.Extensions
{
    public static class EnumerableExtensions
    {
        public static T Before<T>(this IList<T> items, T what)
        {
            var indexOfWhat = items.IndexOf(what);
            return items.ElementAtOrDefault(indexOfWhat - 1);
        }

        public static T After<T>(this IList<T> items, T what)
        {
            var indexOfWhat = items.IndexOf(what);
            return indexOfWhat == -1 ? default(T) : items.ElementAtOrDefault(indexOfWhat + 1);
        }
    }
}