using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace Example2
{
    public class DAL
    {
        WebService.WebService1 serviceObj;
        public DAL()
        {
            serviceObj = new WebService.WebService1();
        }

        public DataTable GetAllStudents()
        {
            try
            {
                return serviceObj.GetAllStudents();
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable("Error");
                dt.Columns.Add("ErrorMessage");
                dt.Rows.Add(ex.Message);
                return dt;
            }
        }

        public DataTable GetStudent(string StudentId)
        {
            try
            {
                //return null;
                return serviceObj.GetStudent(StudentId);
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable("Error");
                dt.Columns.Add("ErrorMessage");
                dt.Rows.Add(ex.Message);
                return dt;
            }
        }
    }
}