using System;
using System.Linq;

namespace SqlGenerator
{
    internal abstract class SqlCommandPart
    {
        protected SqlCommandPart(SqlBuilder builder)
        {
            this.Builder = builder;
        }

        protected SqlBuilder Builder { get; private set; }

        public override string ToString()
        {
            return this.Builder.ToString();
        }
    }
}