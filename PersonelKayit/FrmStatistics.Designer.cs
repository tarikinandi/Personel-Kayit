namespace PersonelKayit
{
    partial class FrmStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LblSumEmployee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMarriedEmployee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNotMarriedEmployee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSumCity = new System.Windows.Forms.Label();
            this.LblSumSalary = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblAvgSalary = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı :";
            // 
            // LblSumEmployee
            // 
            this.LblSumEmployee.AutoSize = true;
            this.LblSumEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSumEmployee.Location = new System.Drawing.Point(249, 50);
            this.LblSumEmployee.Name = "LblSumEmployee";
            this.LblSumEmployee.Size = new System.Drawing.Size(20, 24);
            this.LblSumEmployee.TabIndex = 1;
            this.LblSumEmployee.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evli Personel Sayısı :";
            // 
            // LblMarriedEmployee
            // 
            this.LblMarriedEmployee.AutoSize = true;
            this.LblMarriedEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMarriedEmployee.Location = new System.Drawing.Point(249, 91);
            this.LblMarriedEmployee.Name = "LblMarriedEmployee";
            this.LblMarriedEmployee.Size = new System.Drawing.Size(20, 24);
            this.LblMarriedEmployee.TabIndex = 3;
            this.LblMarriedEmployee.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bekar Personel Sayısı :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblNotMarriedEmployee
            // 
            this.LblNotMarriedEmployee.AutoSize = true;
            this.LblNotMarriedEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotMarriedEmployee.Location = new System.Drawing.Point(249, 137);
            this.LblNotMarriedEmployee.Name = "LblNotMarriedEmployee";
            this.LblNotMarriedEmployee.Size = new System.Drawing.Size(20, 24);
            this.LblNotMarriedEmployee.TabIndex = 5;
            this.LblNotMarriedEmployee.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şehir Sayısı :";
            // 
            // LblSumCity
            // 
            this.LblSumCity.AutoSize = true;
            this.LblSumCity.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSumCity.Location = new System.Drawing.Point(249, 180);
            this.LblSumCity.Name = "LblSumCity";
            this.LblSumCity.Size = new System.Drawing.Size(20, 24);
            this.LblSumCity.TabIndex = 7;
            this.LblSumCity.Text = "0";
            // 
            // LblSumSalary
            // 
            this.LblSumSalary.AutoSize = true;
            this.LblSumSalary.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSumSalary.Location = new System.Drawing.Point(249, 224);
            this.LblSumSalary.Name = "LblSumSalary";
            this.LblSumSalary.Size = new System.Drawing.Size(20, 24);
            this.LblSumSalary.TabIndex = 9;
            this.LblSumSalary.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş :";
            // 
            // LblAvgSalary
            // 
            this.LblAvgSalary.AutoSize = true;
            this.LblAvgSalary.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAvgSalary.Location = new System.Drawing.Point(249, 268);
            this.LblAvgSalary.Name = "LblAvgSalary";
            this.LblAvgSalary.Size = new System.Drawing.Size(20, 24);
            this.LblAvgSalary.TabIndex = 11;
            this.LblAvgSalary.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ortalama Maaş :";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 404);
            this.Controls.Add(this.LblAvgSalary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblSumSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblSumCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblNotMarriedEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMarriedEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSumEmployee);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSumEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMarriedEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNotMarriedEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSumCity;
        private System.Windows.Forms.Label LblSumSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblAvgSalary;
        private System.Windows.Forms.Label label12;
    }
}