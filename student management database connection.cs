using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Management_system.Database
{
   public static class DB
    {
        private static readonly string connection =" Data Source=mekala;Initial Catalog = studentdatabase; Integrated Security = True; TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
