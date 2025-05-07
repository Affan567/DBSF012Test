using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.DL
{
    public class Complaints
    {
        public DataTable GetComplaintOfaStudent(int userid)
        {
            string query = "SELECT * FROM complaints as c join students as s on c.StudentID = s.StudentID join users as u on s.userID = u.userID Where s.userId = {0} ";
            query = String.Format(query, userid);
            return DatabaseHelper.getDataTable(query);
        }


        public DataTable GetComplaintOfAllStudent()
        {
            string query = "SELECT * FROM complaints Where ";
            return DatabaseHelper.getDataTable(query);
        }




    }


}
