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
    public partial class patient : Form
    {
        public String Home = "";     
      
     
        String Status = "";
        SqlConnection c = new SqlConnection(@"Data Source=sara\SQL;Initial Catalog=hospital;Integrated Security=True");
        bool st = true;
        int IdNo = 100000;
       
        public patient()
        {
            
            
            InitializeComponent();
            setPatientId();
            psearchtype.SelectedIndex = 0;
            Display();
          
            setWord();
          
        }

        private void RefreshAll()
        {
           
            Display();
            setPatientId();
            pid.Text = "";
            pname.Text = "";
            pgender.SelectedIndex = -1;
            page.Text = "";
            room_no.Text = "";
            pcountry.SelectedIndex = -1;
            pmobile.Text = "";
            pword.SelectedIndex = -1;
            BloodGroup.SelectedIndex = -1;
            admitdate.Text = "";
            psearch.Text = "";
            psearchtype.SelectedIndex = -1;
            textBox1.Text = "";
           
        }

        void setPatientId()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT p_id FROM Inpatient", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                
                    IdNo = IdNo + 1;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void setWord()
        {
            try { 
            SqlDataAdapter sd = new SqlDataAdapter("SELECT w_no FROM Word", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            pword.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {


                pword.Items.Add(item[0].ToString());

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void InsertPatient()
        {
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO Inpatient (p_id, p_name,p_gender, p_age, city, country, p_mobile, w_no, admit_date,room_no,BloodGroup) VALUES ('" +
                pid.Text + "','" + pname.Text + "','" + pgender.Text + "','" + page.Text + "','"  + textBox1.Text + "','" + pcountry.Text + "','" + pmobile.Text + "','" + pword.Text + "','"+ admitdate.Text + "','" +room_no.Text + "','" + BloodGroup.Text +"')", c);
                cm.ExecuteNonQuery();
                c.Close();

           ///     MessageBox.Show("Successfully Added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePatient()
        {
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"UPDATE  Inpatien SET    p_id = '" + pid.Text + "', p_name = '" + pname.Text + "', p_age = '" + page.Text + "', p_gender = '" + pgender.Text + "', BloodGroup = '" + BloodGroup.Text + "', city = '" + textBox1.Text + "', country = '" + pcountry.Text + "', p_mobile = '" + pmobile.Text  + "', w_no = '" + pword.Text + "', admit_date = '" + admitdate.Text  + "' WHERE (p_id = '" + pid.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Updated.");
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePatient()
        {

            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"DELETE FROM Inpatient WHERE (p_id = '" + pid.Text + "') ", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDataGridViewRows(DataRow item)
        {
            try { 
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
            dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
            dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
            dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
            dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
            dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
            

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}

        void Display()
        {
            try { 
            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Inpatient ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                addDataGridViewRows(item);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                pid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                pgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                BloodGroup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                pcountry.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pmobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                pword.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                admitdate.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                room_no.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                
                
              
             
                

               
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
                
                
            

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cc = new SqlDataAdapter(" SELECT p_id FROM Inpatient", c);

                DataTable dw = new DataTable();

                cc.Fill(dw);


                foreach (DataRow item in dw.Rows)
                {

                    int n = 0;
                    string[] wn = new string[4];
                    wn[n] = item[0].ToString();


                    if (pid.Text == wn[n])
                    {
                        MessageBox.Show("ID Already used.\n Select another.");

                        st = false;
                    }
                }

                if (st)
                {
                    if (pid.Text == "" || pname.Text == "" || pgender.Text == "" || room_no.Text == "" || pcountry.Text == "" || pmobile.Text == "" || pword.Text == ""  || admitdate.Text == "" )
                    {
                        MessageBox.Show("Fill all boxes");

                    }
                    else
                    {

                        InsertPatient();

                        Display();
                        MessageBox.Show("Inserted Successfully");
                        RefreshAll();
                        st = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (pid.Text == "")
                {
                    MessageBox.Show("Select an patient's information to update");
                }
                else
                {

                    UpdatePatient();
                    Display();
                   
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DeletePatient();
                Display();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void F5_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }    
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Home != "")
            {
                switch (Home)
                {
                    case "Admin":
                        this.Close();
                        Main m = new Main();
                        Home = "";
                         m.Show();
                    break;

                    case "stuff":
                    this.Close();
                    Administration am = new Administration();
                    Home = "";
                    am.Show();
                    break;

                }
            }
        }

        private void psearch_TextChanged(object sender, EventArgs e)
        {
            switch (psearchtype.Text)
            { 
            
                case "Name":
                    SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_name like ('%"+psearch.Text+"%')",c);
           
            DataTable dt = new DataTable();

            cm.Fill(dt);

             dataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
            }
                    break;


                case "ID":
                    SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_id like ('%" + psearch.Text + "%')", c);

                    DataTable dtid = new DataTable();

                    cmid.Fill(dtid);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtid.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Mobile":
                    SqlDataAdapter cmobile = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_mobile like ('%" + psearch.Text + "%')", c);

                    DataTable dtmobile = new DataTable();

                    cmobile.Fill(dtmobile);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtmobile.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Gender":
                    SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_gender like ('%" + psearch.Text + "%')", c);

                    DataTable dg = new DataTable();

                    cg.Fill(dg);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dg.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Age":
                    SqlDataAdapter ce = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_age like ('%" + psearch.Text + "%')", c);

                    DataTable de = new DataTable();

                    ce.Fill(de);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in de.Rows)
                    {
                        int n = dataGridView1.Rows.Add();

                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "Country":
                    SqlDataAdapter cco = new SqlDataAdapter("SELECT * FROM Inpatient WHERE country like ('%" + psearch.Text + "%')", c);

                    DataTable dco = new DataTable();

                    cco.Fill(dco);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dco.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

                case "City":
                    SqlDataAdapter cci = new SqlDataAdapter("SELECT * FROM Inpatient WHERE city like ('%" + psearch.Text + "%')", c);

                    DataTable dci = new DataTable();

                    cci.Fill(dci);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dci.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;


                case "Blood Group":
                    SqlDataAdapter cbg = new SqlDataAdapter("SELECT * FROM Inpatient WHERE BloodGroup like ('%" + psearch.Text + "%')", c);

                    DataTable dbg = new DataTable();

                    cbg.Fill(dbg);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dbg.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    }
                    break;

            }
        }
        private void patient_Load(object sender, EventArgs e)
        {

        }
        private void FreeBed()
        {
            try
            {
                c.Open();

                SqlCommand cm = new SqlCommand(@"DELETE FROM Bed WHERE(p_id = '"+pid.Text+"')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("The bed is free now.");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }
     
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            admitdate.Text = dateTimePicker1.Text;
        }

    }
}
