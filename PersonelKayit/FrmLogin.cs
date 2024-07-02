using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayit
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1F6TS0S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Yonetici " +
                "where KullaniciAd=@p1 and Sifre=@p2" , conn);
            cmd.Parameters.AddWithValue("@p1", TxtUsername.Text);
            cmd.Parameters.AddWithValue("@p2" , TxtPassword.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifresi!");
            }

            conn.Close();
        }
    }
}
