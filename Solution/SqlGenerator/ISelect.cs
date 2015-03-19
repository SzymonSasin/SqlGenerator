namespace SqlGenerator
{
    public interface ISelect
    {
        ISelect From(string tableName, string alias = null);

        ISelect Alias(string alias);

        string ToString();
    }
}