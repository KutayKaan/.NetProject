using GameMarkt.Classes;
using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace GameMarkt
{
    public partial class ListGames : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // İlk yükleme için
            {
                LoadGames();
            }
        }

        private void LoadGames()
        {
            try
            {
                // Bağlantı ve komutu using bloğunda açıyoruz
                SQLConnection.CheckConnection(); // Bağlantıyı kontrol ediyoruz

                using (SqlCommand cmdList = new SqlCommand("SELECT * FROM Gametable inner join ProducerTable on GameTable.GameProducerID = ProducerTable.ProducerID WHERE GameConfirmation = @pcon", SQLConnection.connection))
                {
                    cmdList.Parameters.AddWithValue("@pcon", true);

                    // ExecuteReader kullanarak veriyi alıyoruz
                    using (SqlDataReader dr = cmdList.ExecuteReader())
                    {
                        DataList1.DataSource = dr;
                        DataList1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglamak veya göstermek için
                Response.Write($"<script>alert('Bir hata oluştu: {ex.Message}');</script>");
            }
            finally
            {
                // Bağlantıyı kapatma
                if (SQLConnection.connection.State == System.Data.ConnectionState.Open)
                {
                    SQLConnection.connection.Close();
                }
            }
        }
    }
}
