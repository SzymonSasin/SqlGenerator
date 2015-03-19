namespace SqlGenerator
{
    //Select
    //    .AllValues  | .Parameter
    //From <tableName>
    //Where a =b
    //    AND c = d

    public interface ISelect
    {
        IFrom AllColumns();

        IFrom Columns(params string[] properties);
    }

    public interface IFrom
    {
        IFrom Table(string table);

        IFrom Table(string table, string alias);
    }

    public interface IWhere : IGenerate
    {
        IWhereOperator For(string leftValue);
    }

    public interface IWhereOperator
    {
        IWhereJoin IsEqualTo(string rightValue);

        IWhereJoin IsGreat(string rightValue);

        IWhereJoin IsLower(string rightValue);

        IWhereJoin InBetween(string rightValue);

        IWhereJoin Like(string rightValue);
    }

    public interface IWhereJoin : IGenerate
    {
        IWhere And();

        IWhere Or();
    }

    public interface IGenerate
    {
        string ToString();
    }
}