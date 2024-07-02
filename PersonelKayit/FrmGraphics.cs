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
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1F6TS0S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");

       

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            //graphics 1
            conn.Open();
            SqlCommand cmdg1 = new SqlCommand("Select PerSehir , Count(*) From Tbl_Personel Group by  PerSehir", conn);
            SqlDataReader dr1 = cmdg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            conn.Close();

            //graphics 2
            conn.Open();
            SqlCommand cmdg2 = new SqlCommand("Select PerMeslek , avg(PerMaaş) From Tbl_Personel Group By PerMeslek" , conn);
            SqlDataReader dr2 = cmdg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(dr2[0] , dr2[1]);
            }

            conn.Close();
        }
    }
}
