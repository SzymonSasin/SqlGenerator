using System.Linq;

namespace SqlGenerator
{
    public sealed class Sql
    {
        public static IFrom Select()
        {
            return new Select().AllColumns();
        }

        public static IFrom Select<T>()
        {
            var columns = typeof(T)
                .GetProperties()
                .Select(x => x.Name);

            return new Select().Columns(columns.ToArray());
        }
    }
}