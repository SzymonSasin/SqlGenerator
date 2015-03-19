namespace SqlGenerator
{
    public sealed class Sql
    {
        public static ISelect Select<T>()
        {
            return Sql.Select<T>();
        }
    }
}