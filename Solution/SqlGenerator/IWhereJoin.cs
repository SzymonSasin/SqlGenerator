using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IWhereJoin : IQuery
    {
        IWhere And();

        IWhere Or();
    }
}