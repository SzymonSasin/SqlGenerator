namespace SqlGenerator
{
    public interface ISelect : IQuery
    {
        IFrom AllColumns();

        IFrom Columns(params string[] properties);
    }
}