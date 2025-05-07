using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.BL
{
    public class Rooms
    {

        public Rooms() { }
        public object getTotalRooms()
        {
            return DL.Rooms.getTotalRoomsFromDB();
        }
        
        
        public void viewRoom()
        {
            DL.Rooms.viewRoomsData();
        }


    
    }

}
