using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.DL
{
    internal class HostelBuildings
    {
        public static bool Addbuildings(string name , int rooms , int floors , int servantID , int wardenID)
        {
            string query = "Insert into hostelbuildings (BuildingName , Floors ,Rooms,WardenID,ServantID) values ('{name}' , {floors},{rooms},{servantID},{wardenID})";
            int rowsaffected = DatabaseHelper.executeDML(query);
            return rowsaffected > 0;
        }

        public static bool Deletebuildings(int buildingid)
        {
            string query = "Delete * from hostelbuildings where BuildingID = {buildingid} ";
            int rowsAffected = DatabaseHelper.executeDML(query);
            return rowsAffected > 0;
        }

        public static bool UpdateBuilding(int buildingid, string buildingName, int rooms, int floors, int servantID, int wardenID)
        {
            string query = "Update Hostelbuildings set BuildingName = '{BuildingName}' Floors = {floors} Rooms = {rooms}  WardenID = {wardenID} ServentID = {servantID}  where BuildingID = {buildingid}";
            int rowsaffected = DatabaseHelper.executeDML(query);
            return rowsaffected > 0;

        }

            
    }
}
