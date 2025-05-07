using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dll.DL
{
    internal class Visitors
    {
         static public DataTable ViewVisitors()
        {
            string query = "Select VisitorID , VisitorName , VisitDate from visitors";
            DataTable dt = DatabaseHelper.getDataTable(query);
            return dt;


        }


    
    
    
    }
}
