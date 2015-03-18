using System.Collections.Generic;
using System.Linq;

namespace SqlGenerator
{
    internal sealed class SelectGenerator : ISelect
    {
        private IEnumerable<object> parameters;
        private string tableName;
        private string tableNameAlias;

        internal SelectGenerator(IEnumerable<object> parameters, string tableName, string alias = null)
        {
            this.parameters = parameters;

            this.SetTable(tableName, alias);
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
            SetTable(tableName, alias);

            return this;
        }

        public override string ToString()
        {
            return string.Empty;
        }

        private void SetTable(string tableName, string alias)
        {
            this.tableName = tableName;

            SetAlias(alias);
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