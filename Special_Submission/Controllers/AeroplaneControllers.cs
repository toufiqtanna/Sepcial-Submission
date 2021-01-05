using Special_Submission.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Submission.Controllers
{
    public class AeroplaneControllers
    {
        static Database db = new Database();
       
        public static bool AddUser(dynamic u)
        {
            AeroplaneDetail aeroplanedetail = new AeroplaneDetail();
            aeroplanedetail.PlaneID = u.PlaneID;
            aeroplanedetail.PlaneName = u.PlaneName;
            aeroplanedetail.FlightNumber = u.FlightNumber;
            aeroplanedetail.Source = u.Source;
            aeroplanedetail.Destination = u.Destination;
            return db.AeroplaneDetails.AddUser(aeroplanedetail);

        }
        public static AeroplaneDetail GetUser(string username)
        {
            return db.AeroplaneDetails.GetUser(username);
        }
        public static bool UpdateUser(dynamic u)
        {
            AeroplaneDetail aeroplanedetail = new AeroplaneDetail();
            aeroplanedetail.PlaneID = u.PlaneID;
            aeroplanedetail.PlaneName = u.PlaneName;
            aeroplanedetail.FlightNumber = u.FlightNumber;
            aeroplanedetail.Source = u.Source;
            aeroplanedetail.Destination = u.Destination;
            return db.AeroplaneDetails.AddUser(aeroplanedetail);
        }
        public static bool DeleteUser(string PlaneName)
        {
            return db.AeroplaneDetails.DeleteUser(PlaneName);
        }
        public static ArrayList GetAllUsers()
        {
            return db.AeroplaneDetails.GetAllUsers();
        }
    }
}
