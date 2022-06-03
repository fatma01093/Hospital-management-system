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
    public partial class add : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=sara\SQL;Initial Catalog=hospital;Integrated Security=True");
        public add()
        {
            InitializeComponent();
            c.Open();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user_type = comboBox2.SelectedItem.ToString();
                if (user_type == "Doctor")
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO doctor (d_id,  d_name,d_gender,qualification,salary,d_password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" +
                        comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", c);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO stuffs (Stuff_Id,  Stuff_name,gender,qualification,salary,Stuff_password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" +
                        comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", c);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Close();
            this.Close();
        }
    }
}
