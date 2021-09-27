using System.Collections.Generic;

namespace ByteBank.SystemAgency.Extensions
{
    public static class ListExtension
    {
        public static void AddSeveral<T>(this List<T> list, params T[] items)
        {
            foreach (T item in items)
            {
                list.Add(item);
            }
        }
    }
}
