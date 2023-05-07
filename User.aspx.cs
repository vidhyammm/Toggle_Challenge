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
    public partial class User : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Register_ID)from Log_Tab";
            string regid = obj.Fun_exescalar(sel);

            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ch = DropDownList1.SelectedItem.Text;
            string r1 = RadioButtonList1.SelectedItem.Text;
            string r2 = RadioButtonList2.SelectedItem.Text;
            string ins = "insert into User_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + ch + "','" + r1 + "','" + r2 + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            string inslog = "insert into Log_Tab values(" + reg_id + ",'user','" + TextBox4.Text + "','" + TextBox5.Text + "','active')";
            int j = obj.Fun_exenonquery(inslog);
            if (i != 0 && j != 0)
            {
                Label1.Text = "Registered...";
            }
        }
    }
}