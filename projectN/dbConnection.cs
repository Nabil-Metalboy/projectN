using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Configuration;


namespace projectN
{
    class dbConnection
    {
        public string cnnStr = "";

        public SqlConnection dbConnect()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            cnnStr = ConfigurationSettings.AppSettings.Get("SqlString");
#pragma warning restore CS0618 // Type or member is obsolete
            return new SqlConnection(cnnStr);
        }

    }
}
