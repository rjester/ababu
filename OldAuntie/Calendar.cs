﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Calendar
    {
        public Calendar()
        {
        }

        public static DataTable GetAllCalendar()
        {
            string query = "SELECT * FROM calendars";
            return Globals.DBCon.Execute(query);
        }
    }

    public class CalendarItem
    {
        private int Id { get; set; }
        private int CalendarId { get; set; }
        private int UserId { get; set; }
        private string Description { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private DateTime Created { get; set; }
        private DateTime Updated { get; set; }



        public CalendarItem(int id)
        {
            Load(id);
        }


        public CalendarItem Load(int id)
        {
            Id = id;

            string query = "SELECT * FROM calendar_items a WHERE a.id = " + id;
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                CalendarId = (int)result["calendar_id"];
                UserId = (int)result["user_id"];
                Description = result["description"].ToString();
                StartDate = (DateTime)result["start_date"];
                EndDate = (DateTime)result["end_date"];

                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return this;
        }



        public int Save()
        {
            if (Exists())
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }


        public bool Exists()
        {
            if (Id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Update()
        {
            int affected_rows = 0;
            string query = "UPDATE calendar_items SET " +
                "calendar_id=@calendar_id, " +
                "user_id=@user_id, " +
                "description=@description, " +
                "start_date=@start_date, " +
                "end_date=@end_date, " +
                "created=@created, " +
                "updated=@updated " +
                "WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@calendar_id", CalendarId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@description", Description);
            Cmd.Parameters.AddWithValue("@start_date", StartDate);
            Cmd.Parameters.AddWithValue("@end_date", EndDate);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }



        public int Insert()
        {
            int affected_rows = 0;
            string query = "INSERT INTO calendar_items (calendar_id, user_id, description, start_date, end_date, created) " +
                "VALUES (@calendar_id, @user_id, @description, @start_date, @end_date, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@calendar_id", CalendarId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@description", Description);
            Cmd.Parameters.AddWithValue("@start_date", StartDate);
            Cmd.Parameters.AddWithValue("@end_date", EndDate);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);
            Cmd.Parameters.AddWithValue("@updated", Updated);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM owners WHERE id = @id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }






    }
}