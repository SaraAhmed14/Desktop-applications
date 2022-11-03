﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RESTAURANT_PROJECT
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("please enter all data");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");
                    //this is the first way to insert data
                    //  SqlCommand cmd = new SqlCommand("insert into emp values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "''" + textBox5.Text + "') ", con);
                    //this is the second way to insert data
                    SqlCommand cmd = new SqlCommand("insert into customer values(@code,@name,@address,@telephone)", con);
                    cmd.Parameters.AddWithValue("@code", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telephone", textBox4.Text);
                    con.Open();
                    int rowf = cmd.ExecuteNonQuery();
                    if (rowf > 0)
                    {
                        MessageBox.Show("added succefully");
                    }
                    else
                    {
                        MessageBox.Show("not added");
                    }
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
           
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantyDataSet8.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.restaurantyDataSet8.customer);
            // TODO: This line of code loads data into the 'restaurantyDataSet.customer' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'restaurantyDataSet16.customer' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'restaurantyDataSet13.customer' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'restaurantyDataSet6.customer' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'restaurantDataSet3.customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.restaurantDataSet3.customer);
            // TODO: This line of code loads data into the 'restaurantxDataSet3.customer' table. You can move, or remove it, as needed.

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main_screen m = new main_screen();
            m.Show();
            this.Hide();

        }
    }
}
