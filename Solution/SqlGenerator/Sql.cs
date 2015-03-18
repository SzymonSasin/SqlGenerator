namespace SqlGenerator
{
    public sealed class Sql
    {
        public static SelectGenerator Select<T>()
        {
            return SelectGenerator.CreateFrom<T>();
        }
    }
}