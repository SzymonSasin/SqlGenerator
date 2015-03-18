using System.Collections.Generic;
using System.Linq;

namespace SqlGenerator
{
    internal sealed class SelectGenerator : ISelect
    {
        private IEnumerable<string> parameters;
        private string tableName;
        private string alias;

        internal SelectGenerator(IEnumerable<string> parameters, string tableName, string alias = null)
        {
            this.parameters = parameters;

            this.PopulateTableNameAndAliasProperties(tableName, alias);
        }

        public static SelectGenerator CreateFrom<T>()
        {
            var properties = typeof(T)
                .GetProperties()
                .Select(x => x.Name);

            return new SelectGenerator(properties, typeof(T).Name, null);
        }

        public ISelect From(string tableName, string alias = null)
        {
            PopulateTableNameAndAliasProperties(tableName, alias);

            return this;
        }

        public override string ToString()
        {
            return string.Format(
                "SELECT {2}.{0} FROM {1} {2}",
                BuildParameters(),
                this.tableName,
                this.alias);
        }

        private string BuildParameters()
        {
            var parameterSeparator = ", " + this.alias + ".";
            return string.Join(parameterSeparator, this.parameters);
        }

        private void PopulateTableNameAndAliasProperties(string tableName, string alias)
        {
            this.tableName = tableName;
            this.alias = GetAlias(alias);
        }

        private string GetAlias(string alias)
        {
            var tableAlias = alias == null ?
                this.tableName[0].ToString() :
                alias;

            return tableAlias.ToLower();
        }
    }
}