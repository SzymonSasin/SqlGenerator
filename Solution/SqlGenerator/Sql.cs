namespace SqlGenerator
{
    public sealed class Sql
    {
        public static ISelect Select<T>()
        {
            return SelectGenerator.CreateFrom<T>();
        }
    }
}