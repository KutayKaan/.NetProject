using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using GameMarkt.Classes;

namespace GameMarkt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into UserListTable (UserMail,UserPassword) values (@pmail,@ppass)", SQLConnection.connection);

            SQLConnection.CheckConnection();


            string newPass = SHA256Converter.ComputeSha256Hash(TextBox3.Text);

            cmd.Parameters.AddWithValue("@pmail", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ppass", newPass);

            cmd.ExecuteNonQuery();



        }
    }
}