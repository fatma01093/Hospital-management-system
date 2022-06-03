using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalmanagementSystem
{
    
    public partial class Administration : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=sara\SQL;Initial Catalog=hospital;Integrated Security=True");
        Timer t = new Timer();
        patient patientAdministration;
        bill InpatientBill;
        bill OutpatientBill;

        Attandance StuffAttendance;
        public Administration()
        {
            InitializeComponent();
        }
         
        void UpdateLogOut()
        {

            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            if (hh > 12)
            {
                hh = hh - 12;
                AmPm.Text = "Pm";
            }
            else
            {
                AmPm.Text = "Am";
            }

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }



            timeLabel.Text = time;
        }

       

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            word w = new word();
            this.Hide();
            w.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            room r = new room();
            this.Hide();
            r.Show();
        }

        

        private void inpatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientAdministration = new patient();
            patientAdministration.Home = "stuff";
            patientAdministration.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateLogOut();
            this.Close();
            
            Login l = new Login();
            l.Show();
        }

      

        
        private void inpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InpatientBill = new bill();
            InpatientBill.ShowDialog();
        }

      

        private void stuffAttandanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StuffAttendance = new Attandance();
            StuffAttendance.ShowDialog();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void outpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutpatientBill = new bill();
            OutpatientBill.PatientCateogtyLeble.Text = " Outpatient's Bill";
           
            OutpatientBill.outpatient = true;
          
            OutpatientBill.ShowDialog();
        }

        

        
       
        

        
    }
}
