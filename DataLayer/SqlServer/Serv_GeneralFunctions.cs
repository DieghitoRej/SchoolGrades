﻿using System.Data.Common;

namespace SchoolGrades
{
    internal partial class SqlServer_DataLayer : DataLayer
    {
        internal override object ReadFirstRowFirstField(string Table)
        {
            object r;
            using (DbConnection conn = Connect())
            {
                DbCommand cmd = conn.CreateCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + Table +
                    " LIMIT 1" +
                    ";";
                r = cmd.ExecuteScalar();
            }
            return r;
        }
    }
}
