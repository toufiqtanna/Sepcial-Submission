using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Submission.Models
{
    class Database
    {
        public AeroplaneDetails AeroplaneDetails { get; set; }
        public Database()
        {
            string connString = "Server=DESKTOP-N5CIT9Q\\SQLEXPRESS;Integrated Security=true;Database=AeroPlane";
            SqlConnection conn = new SqlConnection(connString);
            AeroplaneDetails = new AeroplaneDetails(conn);
            

        }
    }
}
