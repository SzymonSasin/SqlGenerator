using System.Collections.Generic;
using System.Linq;

namespace SqlGenerator
{
    internal sealed class Select : SqlCommandPart, ISelect
    {
        public Select()
            : base(new SqlBuilder())
        {
        }

        public IFrom AllColumns()
        {
            return this.Columns("*");
        }

        public IFrom Columns(params string[] properties)
        {
            this.Builder.AddSqlTemplate(this.GetSqlTempalte(properties));
            return new From(this.Builder);
        }

        internal string GetSqlTempalte(IEnumerable<string> properties)
        {
            return "SELECT {0}." + string.Join(", {0}.", properties);
        }
    }
}