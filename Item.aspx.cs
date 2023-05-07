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
    public partial class Item : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            string ins = "insert into Item_Tab11 values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            if (i != 0)
            {
                Label1.Text = "SUCCESSFULLY INSERTED";
            }
        }
    }
}