using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IWhere : IQuery
    {
        IWhereOperator For(string leftValue);
    }
}