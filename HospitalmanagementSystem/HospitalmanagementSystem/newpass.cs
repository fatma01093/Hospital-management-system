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
    public partial class newpass : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=sara\SQL;Initial Catalog=hospital;Integrated Security=True");
        
        string NewEmail = "";


        public newpass(string Email)
        {
            InitializeComponent();
            NewEmail = Email;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==textBox2.Text)
          {
            
                   try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       register
                            SET passward = '" + textBox2.Text + "' WHERE (Email = '" + NewEmail + "')", c);
                            cm.ExecuteNonQuery();
                            c.Close();
                            MessageBox.Show("Password reset successfull.");
                        }





                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                       
                    this.Close();
                  Login r = new Login();
                      r.Show();
               
            }
            else
            {
                MessageBox.Show("Passwords are different");
            }
          
    
      

    }

       

        private void newpass_Load(object sender, EventArgs e)
        {

        }
    }
}
