using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL dalObject = new DAL();
                ddlStudent.DataSource = dalObject.GetAllStudents();
                ddlStudent.DataTextField = "StudentName";
                ddlStudent.DataValueField = "StudentId";
                ddlStudent.DataBind();
            }
        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAL dalObject = new DAL();
            System.Data.DataTable dt = dalObject.GetStudent(ddlStudent.SelectedValue);
            txtName.Text = dt.Rows[0]["StudentName"].ToString();
            txtAdmissionYear.Text = Convert.ToDateTime(dt.Rows[0]["AdmissionYear"]).ToShortDateString();
        }
    }
}