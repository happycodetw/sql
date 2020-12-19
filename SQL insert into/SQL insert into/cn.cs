using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_insert_into
{
    public static class cn
    {
        public static SqlConnection cnn
        {
            get
            {
                return new SqlConnection("Data Source=.;Initial Catalog=Disneyland_Shanghai_ANO;Integrated Security=True");
            }
        }
    }
}
