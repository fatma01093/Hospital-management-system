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
    public partial class bill : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=sara\SQL;Initial Catalog=hospital;Integrated Security=True");
        public String User = "";
        
        bool st = true;
        bool idnotFound = true;
        public bool outpatient = false;
        string room_no = "";

        public bill()
        {
            InitializeComponent();       
            setBillNo();
            c.Open();
        }

        void setBillNo()
        {
            int bno = 0;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Bill_no FROM Inpatientbill", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                String wn = item[0].ToString();
                bno = Convert.ToInt32(wn);
            }
            bno = bno + 1;
            billno.Text = bno.ToString();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               
                try
                {

              

                    if (pid.Text == "")
                    {
                        MessageBox.Show("Load a patient ID first");
                    }
                    else
                    {
                        SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        p_name, room_no from Inpatient
          where (Inpatient.p_id = '" + pid.Text + "')", c);
                        DataTable dt = new DataTable();
                        cm.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            pname.Text = item[0].ToString();
                           room_no= item[1].ToString();
                            idnotFound = false;
                            setBillNo();
                            total_cost();
                        }
                        if (idnotFound)
                        {
                            MessageBox.Show("Id is not available.");
                        }
                    }
                    idnotFound = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

       
            
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            switch (User)
            {
                case "Admin":

                    this.Close();
                    Main m = new Main();
                     m.Show();
                    break;
                            

                case "Administration":
                    this.Close();
                    Administration a = new Administration();
                    a.Show();

                    break;
            }
            c.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button7_Click(object sender, EventArgs e)
        {

            pid.Text = "";
            pname.Text = "";
            room_charge.Text = "";
            others.Text = "";
            textBox2.Text = "";
            setBillNo();

        }

      
        void total_cost()
        {
            SqlDataAdapter sd = new SqlDataAdapter("SELECT p_name,room_no FROM Inpatient  where p_id Like('" + pid.Text + "')", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                pname.Text = item[0].ToString();
                room_no = item[1].ToString();


            }
            
            SqlDataAdapter sd2 = new SqlDataAdapter("SELECT charge from room  where room_no Like('%" + room_no + "%')", c);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);
            foreach (DataRow item in dt2.Rows)
            {
                room_charge.Text = item[0].ToString();
               
            }
           int total_= Convert.ToInt32(room_charge.Text) + 1000;
            textBox2.Text = total_.ToString();

        }

      


     

       

        private void button8_Click(object sender, EventArgs e)
        {
           

           
                if (pid.Text == "" )
                {
                    MessageBox.Show("Fill id boxe");
                    this.Close();
                    bill b = new bill();
                    b.Show();

                }
                else
                {
                  

                    SqlCommand cm = new SqlCommand("INSERT INTO Inpatientbill (Bill_no,  Total_Amount,p_id) VALUES ('" +  Convert.ToInt32(billno.Text) + "','" +textBox2.Text+ "','" + pid.Text +"')", c);
                    cm.ExecuteNonQuery();
                SqlCommand cm2 = new SqlCommand(@"UPDATE  Inpatient SET    Check_out_date = '" + billdate.Value + "' WHERE (p_id = '" + pid.Text + "')", c); ;
                                  cm2.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved.");

                    setBillNo();
                  
                    pid.Text = "";
                    pname.Text = "";
                    room_charge.Text = "";
                  
                    others.Text = "0";
                    
                    st = false;
                }

            
            
        }

        
      

       

       
        


       
    }
}
