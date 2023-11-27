using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            {
            DBHelper dbhelper = new DBHelper();
            //dbhelper.ExecuteScalar();
            DataTable dt = dbhelper.ExecuteDataTable("Select StudentName from dbo.Student Where StudentID = 1");
            string count = dbhelper.ExecuteScalar("Select count(*) from dbo.Student");


            lblText.Text = dt.Rows[0]["StudentName"].ToString();
            //lblText.Text = count;
            //DataSet ds = dbhelper.ExecuteDataAdapter("Select * from dbo.Student");
        }
    }
}