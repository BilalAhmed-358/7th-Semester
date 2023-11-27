using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService
{
    public static class DAL
    {
        public static DataTable GetAllStudents()
        {
            string query = @"SELECT * FROM dbo.Student Order By StudentID";
            DBHelper dbh = new DBHelper();
            return dbh.GetDataTable(query);
        }

        public static DataTable GetStudent(string StudentID)
        {
            string query = @"SELECT * FROM dbo.Student WHERE StudentId = @StudentId";
            DBHelper dbh = new DBHelper();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");
            dt.Rows.Add("StudentId", StudentID);

            return dbh.GetDataTable(query,dt);
        }

        public static DataTable GetStudentsSP(string StudentID)
        {
            string spName = "dbo.GetStudent";
            DataTable dt = new DataTable();
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");
            dt.Rows.Add("StudentId", StudentID);

            DBHelper dbh = new DBHelper();
            return dbh.GetDataTableSP(spName, dt);
        }
    }
}