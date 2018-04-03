using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLayer.Helpers
{
    public static class Converters
    {
        public static string ConvertIdToString<TKey>(TKey id)
            where TKey : IEquatable<TKey>
        {
            if (id.Equals(default(TKey)))
            {
                return null;
            }
            return id.ToString();
        }

        public static TKey ConvertIdFromString<TKey>(string id)
            where TKey : IEquatable<TKey>
        {
            if (id == null)
            {
                return default(TKey);
            }
            return (TKey)TypeDescriptor.GetConverter(typeof(TKey)).ConvertFromInvariantString(id);
        }
    }
}
