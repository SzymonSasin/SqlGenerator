using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IWhere : IQuery
    {
        IWhereOperator For(string leftValue);

        IWhereJoin Bracket(Func<IWhere, IWhereJoin> where);
    }
}