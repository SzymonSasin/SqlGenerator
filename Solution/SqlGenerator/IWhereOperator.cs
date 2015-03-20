using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IWhereOperator : IQuery
    {
        IWhereJoin IsEqualTo(string rightValue);

        IWhereJoin IsGreat(string rightValue);

        IWhereJoin IsLower(string rightValue);

        IWhereJoin InBetween(string rightValue);

        IWhereJoin Like(string rightValue);
    }
}