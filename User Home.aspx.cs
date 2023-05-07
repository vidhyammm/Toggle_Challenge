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
    public partial class User_Home : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string stl = "select * from User_tab where User_ID='" + Session["User_ID"] + "'";
            SqlDataReader dr = obj.fun_exeReader(stl);
            while (dr.Read())
            {
                Label2.Text = dr["User_Name"].ToString();
                Label3.Text = dr["User_Department"].ToString();
            }
            if (!IsPostBack)
            {
                string sel = "select item_Id,Item_Name from Item_Tab11";
                DataSet ds = obj.Fun_exeadapter(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Item_Name";
                DropDownList1.DataValueField = "item_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--Select--");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            string k = DropDownList1.SelectedItem.Value;
            string ins = "insert into Listed_Tab values('" + k + "','" + Label2.Text + "','" + Label3.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            if (i != 0)
            {
                Label1.Text = "SUCCESSFULLY ADDED";
            }
        }
    }
}