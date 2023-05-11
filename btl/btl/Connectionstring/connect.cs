using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace btl.Connectionstring
{
    class connect
    {
        string cnect = "Data Source=.;Initial Catalog=BTLQuanlydiemTHPT_cshaps;Integrated Security=True";

        public connect()
        {
        }

        public connect(string cnn)
        {
            this.cnect = cnn;
        }

        public SqlConnection Connect()
        {
            SqlConnection Connection = new SqlConnection(cnect);
            return Connection;
        }
    }
}
