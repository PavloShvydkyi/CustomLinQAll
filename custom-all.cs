using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinQAll
{
    static class CustomAll
    {
        public static bool CastomAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            
            foreach (var item in source)
            {
                if (!predicate(item))
                    return false;
            }

            return true;
        }
    }
}
