namespace SqlGenerator
{
    public interface ISelect
    {
        ISelect From(string tableName, string alias = null);

        string ToString();
    }
}