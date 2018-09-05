using Sjerrul.CharacterForge.Utilities.Assertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.CharacterForge.Utilities.Extensions
{
    public static class ListExtensions
    {
        public static IList<T> Concat<T>(this IList<T> list, T item)
        {
            Guard.Against.ArgumentNull(item, nameof(item));

            return list.Concat(Yield(item)).ToList();
        }

        private static IEnumerable<T> Yield<T>(T item)
        {
            yield return item;
        }
    }
}
