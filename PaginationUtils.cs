using System.Linq;

namespace System.Collections.Generic
{
    public static class PaginationUtils
    {
        /// <summary>
        /// returns paginated items of an IEnumerable object
        /// </summary>
        /// <param name="page">
        ///     minimum value is 1
        /// </param>
        /// <param name="size">
        ///     if size is set to -1 or less then all items are returned
        /// </param>
        /// <returns>Paginated IEnumerable Items</returns>
        public static IEnumerable<T> Page<T>(this IEnumerable<T> @this, int page, int size)
        {
            if (@this == null) return null;
            if (size < -1) size = -1;
            if (size == -1) return @this;
            if (page <= 0) page = 1;
            return @this.Skip((page - 1) * size).Take(size);
        }

        /// <summary>
        /// returns paginated items of an IQueryable object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="page">
        ///     minimum value is 1
        /// </param>
        /// <param name="size">
        ///     if size is set to -1 or less then all items are returned
        /// </param>
        /// <returns></returns>
        public static IQueryable<T> Page<T>(this IQueryable<T> @this, int page, int size)
        {
            if (@this == null) return null;
            if (size < -1) size = -1;
            if (size == -1) return @this;
            if (page <= 0) page = 1;
            return @this.Skip((page - 1) * size).Take(size);
        }
    }
}
