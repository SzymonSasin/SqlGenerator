using System;
using System.Linq;

namespace SqlGenerator
{
    internal sealed class From : SqlCommandPart, IFrom
    {
        private string alias;
        private string table;

        internal From(SqlBuilder builder)
            : base(builder)
        {
        }

        public IWhere Table(string table)
        {
            var alias = GetDefaultAlias(table);

            return this.Table(table, alias);
        }

        public IWhere Table(string table, string alias)
        {
            this.Builder.AddAlias(alias);
            this.Builder.AddSqlTemplate(this.GetSqlTempalte(table));

            return new Where(this.Builder);
        }

        private static string GetDefaultAlias(string table)
        {
            var alias = table.Substring(0, 1).ToLower();
            return alias;
        }

        private string GetSqlTempalte(string table)
        {
            return " FROM "
                + table
                + " {0}";
        }
    }
}