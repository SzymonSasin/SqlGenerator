using System;

namespace SqlGenerator
{
    internal sealed class WhereOperator : SqlCommandPart, IWhereOperator
    {
        internal WhereOperator(SqlBuilder builder)
            : base(builder)
        {
        }

        public IWhereJoin InBetween(string rightValue)
        {
            return AddAndReturn(" in ", rightValue);
        }

        public IWhereJoin IsEqualTo(string rightValue)
        {
            return AddAndReturn(" = ", rightValue);
        }

        public IWhereJoin IsGreat(string rightValue)
        {
            return AddAndReturn(" > ", rightValue);
        }

        public IWhereJoin IsLower(string rightValue)
        {
            return AddAndReturn(" < ", rightValue);
        }

        public IWhereJoin Like(string rightValue)
        {
            return AddAndReturn(" like ", rightValue);
        }

        private IWhereJoin AddAndReturn(string operatorForWhere, string rightValue)
        {
            var sqlTempalte = operatorForWhere + rightValue;
            this.Builder.AddSqlTemplate(sqlTempalte);

            return new WhereJoin(this.Builder);
        }
    }
}