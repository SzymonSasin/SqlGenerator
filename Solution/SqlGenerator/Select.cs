namespace SqlGenerator
{
    public sealed class Select
    {
        private string tableName;
        private string tableNameAlias;

        internal Select(params object[] parameters)
        {
        }

        public Select From(string tableName, string alias = null)
        {
            this.tableName = tableName;

            SetAlias(alias);

            return this;
        }

        public override string ToString()
        {
            return string.Empty;
        }

        private void SetAlias(string alias)
        {
            if (alias == null)
            {
                this.tableNameAlias = this.tableName[0].ToString();
            }
            else
            {
                this.tableNameAlias = alias;
            }
        }
    }
}