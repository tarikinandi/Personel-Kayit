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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1F6TS0S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");
                
        void temizle()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbCity.Text = "";
            TxtJob.Text = "";
            MskSalary.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtName.Focus();

        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("Insert into Tbl_Personel (PerAd , PerSoyad , PerSehir , PerMaaş , PerDurum , PerMeslek)" +
                "values (@name , @surname , @city , @salary , @marriage , @job)" , conn);
            command.Parameters.AddWithValue("@name" , TxtName.Text);
            command.Parameters.AddWithValue("@surname" , TxtSurname.Text);
            command.Parameters.AddWithValue("@city" , CmbCity.Text);
            command.Parameters.AddWithValue("@salary" , MskSalary.Text);
            command.Parameters.AddWithValue("@marriage" , radioButton1.Checked);
            command.Parameters.AddWithValue("@job" , TxtJob.Text);
            command.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Personel Eklendi");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = dataGridView1.SelectedCells[0].RowIndex;
            
            TxtId.Text = dataGridView1.Rows[value].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[value].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[value].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[value].Cells[3].Value.ToString();
            MskSalary.Text = dataGridView1.Rows[value].Cells[4].Value.ToString();
            bool isEvli = Convert.ToBoolean(dataGridView1.Rows[value].Cells[5].Value); 
            if (isEvli)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            TxtJob.Text = dataGridView1.Rows[value].Cells[6].Value.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete From Tbl_Personel Where PerId = @k1" , conn);
            cmdDelete.Parameters.Clear();
            cmdDelete.Parameters.AddWithValue("@k1" , TxtId.Text);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdUpdate = new SqlCommand("Update Tbl_Personel Set PerAd=@a1 , PerSoyad=@a2 , PerSehir=@a3 , PerMaaş=@a4," +
                "PerDurum=@a5,PerMeslek=@a6 Where PerId= @a7", conn);
            cmdUpdate.Parameters.AddWithValue("@a1" , TxtName.Text);
            cmdUpdate.Parameters.AddWithValue("@a2" , TxtSurname.Text);
            cmdUpdate.Parameters.AddWithValue("@a3" , CmbCity.Text);
            cmdUpdate.Parameters.AddWithValue("@a4" , MskSalary.Text);
            cmdUpdate.Parameters.AddWithValue("@a5", radioButton1.Checked);
            cmdUpdate.Parameters.AddWithValue("@a6", TxtJob.Text);
            cmdUpdate.Parameters.AddWithValue("@a7" , TxtId.Text);
            cmdUpdate.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Personel Bilgi Güncellendi!");
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.ShowDialog(); 
            

        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics frg = new FrmGraphics();
            frg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReports frp = new FrmReports();
            frp.Show();
            
        }
    }
}
