using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using GameMarkt.Classes;
using System.Data;


namespace GameMarkt
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from UserListTable where UserMail=@pmail and UserPassword=@ppass", SQLConnection.connection);

            SQLConnection.CheckConnection();

            string shaToString = SHA256Converter.ComputeSha256Hash(TextBox2.Text);

            cmd.Parameters.AddWithValue("@pmail", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ppass", shaToString);

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                Response.Write("Giriş Yapıldı");
            }
            else
            {
                Response.Write("Mail adresi veya şifre hatalı");
            }


        }
    }
}