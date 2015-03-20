namespace SqlGenerator
{
    internal sealed class Where : SqlCommandPart, IWhere
    {
        internal Where(SqlBuilder builder)
            : base(builder)
        {
        }

        public IWhereOperator For(string leftValue)
        {
            this.Builder.AddSqlTemplate(this.GetSqlTempalte(leftValue));

            return new WhereOperator(this.Builder);
        }

        private string GetSqlTempalte(string leftValue)
        {
            return " WHERE {0}."
                + leftValue;
        }
    }
}