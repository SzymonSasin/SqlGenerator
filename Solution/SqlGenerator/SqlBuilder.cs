using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    internal sealed class SqlBuilder
    {
        private readonly List<string> templates;
        private string alias;

        internal SqlBuilder()
        {
            this.templates = new List<string>();
        }

        public override string ToString()
        {
            var sqlBuilder = new StringBuilder();

            foreach (var template in this.templates)
            {
                sqlBuilder.AppendFormat(template, this.alias);
            }

            return sqlBuilder.ToString();
        }

        internal void AddSqlTemplate(string template)
        {
            this.templates.Add(template);
        }

        internal void AddAlias(string alias)
        {
            this.alias = alias;
        }
    }
}