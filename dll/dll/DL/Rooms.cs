using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dll.DL
{
    internal class Rooms
    {


        public static DataTable viewRoomsData()
        {
            string query = "Select RoomID , RoomNumber,Status  From rooms";
            DataTable dt = DatabaseHelper.getDataTable(query);
            return dt;
        }


        public static object getTotalRoomsFromDB()
        {
            string query = "Select Count(RoomID) from rooms";
            query = String.Format(query);
            return DatabaseHelper.ExecuteScalar(query);
        
        }
    }
}
