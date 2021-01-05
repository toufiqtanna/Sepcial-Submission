using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Submission.Models
{
    public class AeroplaneDetails
    {
        SqlConnection conn;
        public AeroplaneDetails(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddUser(AeroplaneDetail aeroplanedetail)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Aeroplane_Details VALUES ('{0}','{1}','{2}','{3}','{4}')", aeroplanedetail.PlaneID, aeroplanedetail.PlaneName, aeroplanedetail.FlightNumber, aeroplanedetail.Source, aeroplanedetail.Destination);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }

        public ArrayList GetAllUsers()
        {
            ArrayList aeroplanedetails = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Aeroplane_Details";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AeroplaneDetail aeroplanedetail = new AeroplaneDetail();
                aeroplanedetail = new AeroplaneDetail();
                aeroplanedetail.PlaneID = reader.GetString(reader.GetOrdinal("PlaneID"));
                aeroplanedetail.PlaneName = reader.GetString(reader.GetOrdinal("PlaneName"));
                aeroplanedetail.FlightNumber = reader.GetString(reader.GetOrdinal("FlightNumber"));
                aeroplanedetail.Source = reader.GetString(reader.GetOrdinal("Source"));
                aeroplanedetail.Destination = reader.GetString(reader.GetOrdinal("Destination"));
                aeroplanedetails.Add(aeroplanedetail);
            }
            conn.Close();
            return aeroplanedetails;
        }
        public AeroplaneDetail GetUser(string PlaneID)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Aeroplane_Details WHERE PlaneID='{0}'", PlaneID);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            AeroplaneDetail aeroplanedetail = null;
            while (reader.Read())
            {
                aeroplanedetail = new AeroplaneDetail();
                aeroplanedetail.PlaneID = reader.GetString(reader.GetOrdinal("PlaneID"));
                aeroplanedetail.PlaneName = reader.GetString(reader.GetOrdinal("PlaneName"));
                aeroplanedetail.FlightNumber = reader.GetString(reader.GetOrdinal("FlightNumber"));
                aeroplanedetail.Source = reader.GetString(reader.GetOrdinal("Source"));
                aeroplanedetail.Destination = reader.GetString(reader.GetOrdinal("Destination"));
            }
            conn.Close();
            return aeroplanedetail;
        }
        public bool UpdateUser(AeroplaneDetail aeroplanedetail)
        //public bool UpdateUser(AeroplaneDetail aeroplanedetail)
        {
            //conn.Open();
            string query = "UPDATE Aeroplane_Details SET PlaneName=@PlaneName WHERE PlaneID=@PlaneID";
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@PlaneName", aeroplanedetail.PlaneID);
            cmd.Parameters.AddWithValue("@PlaneID", aeroplanedetail.PlaneName);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteUser(string PlaneID)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Aeroplane_Details WHERE PlaneID='{0}'", PlaneID);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
