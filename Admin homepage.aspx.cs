using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Toggle_Challenge
{
    public partial class Admin_homepage : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Item.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("item updation.aspx");
        }
    }
}