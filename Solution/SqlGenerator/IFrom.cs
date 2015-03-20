using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IFrom : IQuery
    {
        IWhere Table(string table);

        IWhere Table(string table, string alias);
    }
}