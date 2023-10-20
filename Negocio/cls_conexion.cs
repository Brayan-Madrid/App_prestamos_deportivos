using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=ERO-SENNIN\\SQLEXPRESS;Initial Catalog=dbs_prestamos_deportivos;Integrated Security=True");
    }
}
}
