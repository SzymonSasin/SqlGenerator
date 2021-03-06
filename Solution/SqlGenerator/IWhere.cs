﻿using System;
using System.Linq;

namespace SqlGenerator
{
    public interface IWhere : IQuery
    {
        IWhereOperator Where(string leftValue);

        IWhereJoin Bracket(Func<IWhere, IWhereJoin> where);
    }
}