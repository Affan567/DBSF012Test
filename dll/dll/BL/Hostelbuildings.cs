using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.BL
{
    internal class Hostelbuildings
    {

        private int buildingID;
        private string buildingName;
        private int floors;
        private int rooms;
        private int WardenID;
        private int ServantID;



        public Hostelbuildings(int buildingID, string buildingName, int floors, int rooms, int wardenID, int servantID)//For update
        {
            this.buildingID = buildingID;
            this.buildingName = buildingName;
            this.floors = floors;
            this.rooms = rooms;
            WardenID = wardenID;
            ServantID = servantID;
        }
        public Hostelbuildings( string buildingName, int floors, int rooms, int wardenID, int servantID)//For Add
        {
            
            this.buildingName = buildingName;
            this.floors = floors;
            this.rooms = rooms;
            WardenID = wardenID;
            ServantID = servantID;
        }

        public void setbuildingID(int buildingID)
        {
            this.buildingID = buildingID;
        }
        public void setbuildingName(string buildingName)
        {
            this.buildingName = buildingName;
        }
        public void setRooms(int rooms)
        {
            this.rooms = rooms;
        }

        public void setWardenID(int WardenID)
        {
            this.WardenID = WardenID;
        }
        public void setServantID(int servantID)
        {
            this.ServantID = servantID;
        }
        public void setfloors(int floors)
        {
            this.floors = floors;
        }

        public int getRooms()
        {
            return rooms;
        }
        public int getfloors()
        {
            return floors;
        }

        public string getBuildingName()
        {
            return buildingName;
        }

        public int getBuildingID() { 
            return buildingID;
        }
        public int getWardenID()
        {
            return WardenID;
        }
        public int getServantID()
        {
            return ServantID;
        }


        public void AddHostelBuilding(Hostelbuildings h)
        {
            DL.HostelBuildings.Addbuildings(h.getBuildingName(),h.getRooms(),h.getfloors(),h.getServantID(),h.getWardenID());

        }

        public void DeleteBuildings(Hostelbuildings h)
        {
            DL.HostelBuildings.Deletebuildings(h.getBuildingID());
        }
        public void UpdateBuildings(Hostelbuildings h)
        {
            DL.HostelBuildings.UpdateBuilding(h.getBuildingID(), h.getBuildingName(), h.getRooms(), h.getfloors(), h.getServantID(), h.getWardenID());
        }

    }
}
