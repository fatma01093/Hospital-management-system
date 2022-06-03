using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HospitalmanagementSystem
{
   
    public partial class Main : Form
    {
        
        Timer t = new Timer();
        patient patientReg;
        Attendance CheckAttendance;
        Attandance checkAttandance;
      
        bill billCheck;
       
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient pt = new patient();
            pt.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            word w = new word();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            room r = new room();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctor d = new doctor();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill b = new bill();
            b.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender,EventArgs e )
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh > 12)
            {
                hh = hh - 12;
                AmPm.Text = "Pm";
            }
            else
            {
                AmPm.Text = "Am";
            }

           

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

        


       

      

        private void inpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void managementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientReg = new patient();

            patientReg.label16.Text = "PATIENT INFORMATION";
            patientReg.Home = "Admin";
        
            patientReg.ShowDialog();

        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void checkInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctor d = new doctor();
            d.Show();
        }

        private void checkAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAttendance = new Attendance();
            CheckAttendance.category.Text = "Doctor";
            CheckAttendance.ShowDialog();
        }

        private void allStuffAttandanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkAttandance = new Attandance();
            checkAttandance.ShowDialog();
        }

     

      


       

        private void managementToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

      
       

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            billCheck = new bill();
            billCheck.User = "Admin";
            billCheck.PatientCateogtyLeble.Text = "Inpatiet Bill";
        
            billCheck.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add n = new add();
            n.Show();
        }

        private void checkInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
