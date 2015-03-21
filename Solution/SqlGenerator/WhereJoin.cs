using System;

namespace SqlGenerator
{
    internal class WhereJoin : SqlCommandPart, IWhereJoin
    {
        public WhereJoin(SqlBuilder builder)
            : base(builder)
        {
        }

        public IWhere And()
        {
            return AddAndReturn(" AND ");
        }

        public IWhere Or()
        {
            return AddAndReturn(" OR ");
        }

        private IWhere AddAndReturn(string concatenation)
        {
            this.Builder.AddSqlTemplate(concatenation);

            return new WhereQuery(this.Builder);
        }
    }
}