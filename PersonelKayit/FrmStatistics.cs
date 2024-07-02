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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1F6TS0S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {


            //Total number of employee
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) From Tbl_Personel" , conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                LblSumEmployee.Text = dr1[0].ToString();
            }
            conn.Close();


            // Total married employee
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select count(*) From Tbl_Personel where PerDurum = 1" , conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                LblMarriedEmployee.Text = dr2[0].ToString();
            }
            conn.Close();


            //Total not married employee
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select count(*) From Tbl_Personel where PerDurum = 0" , conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                LblNotMarriedEmployee.Text = dr3[0].ToString();
            }
            conn.Close();


            //Total city 
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("Select count(distinct(persehir)) From Tbl_Personel" , conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                LblSumCity.Text = dr4[0].ToString();
            }
            conn.Close();


            //Total Salary
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("Select sum(PerMaaş) from Tbl_Personel" , conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                LblSumSalary.Text = dr5[0].ToString(); 
            }
            conn.Close();


            //Average Salary
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("Select Avg(PerMaaş) from Tbl_Personel" , conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                LblAvgSalary.Text = dr6[0].ToString();
            }
            conn.Close();

        }
    }
}
