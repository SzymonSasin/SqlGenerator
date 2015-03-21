using System;

namespace SqlGenerator
{
    internal sealed class WhereQuery : SqlCommandPart, IWhere
    {
        private readonly bool includeWhere;

        internal WhereQuery(SqlBuilder builder, bool includeWhere = true)
            : base(builder)
        {
            this.includeWhere = includeWhere;
        }

        public IWhereOperator Where(string leftValue)
        {
            this.Builder.AddSqlTemplate(this.GetSqlTempalte(leftValue));

            return new WhereOperator(this.Builder);
        }

        public IWhereJoin Bracket(Func<IWhere, IWhereJoin> where)
        {
            this.Builder.AddSqlTemplate("(");
            var result = where(new WhereQuery(this.Builder, false));
            this.Builder.AddSqlTemplate(")");

            return result;
        }

        private string GetSqlTempalte(string leftValue)
        {
            var where = this.includeWhere ? " WHERE " : string.Empty;
            return where
                + "{0}."
                + leftValue;
        }
    }
}