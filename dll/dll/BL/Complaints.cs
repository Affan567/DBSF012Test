using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.BL
{
    public class Complaints
    {
        private int complaintID;
        private string description;
        private DateTime Date;
        private string status;



        public int GetComplaintID()
        {
            return complaintID;
        }

        public string Getdescription()
        {
            return description;
        }
        public string Status()
        {
            return status;
        }

        public DateTime Getdate()
        {
            return Date;
        }

        public DataTable GetComplaint(int userID)
        {
            DL.Complaints dl = new DL.Complaints();
            return dl.GetComplaintOfaStudent(userID);
        }

        public DataTable GetAllComplaints()
        {
            DL.Complaints dl = new DL.Complaints();
            return dl.GetComplaintOfAllStudent();
        }


    }
}
