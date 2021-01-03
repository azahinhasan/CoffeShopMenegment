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
using System.IO;

namespace CofeShop
{
    public partial class UpdatePasswordForm : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        string ID = LoginForm.ID;

        //string ID = "3";
        public UpdatePasswordForm()
        {
            InitializeComponent();
        }

        private void SignOut_button_Click(object sender, EventArgs e)        //Update Button
        {
            DataTable TampTable = new DataTable();

            string qurey = "Select * from AllUser Where ID ='" + ID + "' AND Password ='" + textBox3.Text + "'";

            db.readDatathroughAdapter(qurey, TampTable);

            if (TampTable.Rows.Count == 1)
            {

                string qurey2 = "Select * from AllUser Where Password ='" + textBox1.Text + "'";

                DataTable TampTable2 = new DataTable();
                db.readDatathroughAdapter(qurey2, TampTable2);

                if (TampTable2.Rows.Count >= 1)
                {
                    MessageBox.Show("This Password is Already Takken! Try Again.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (textBox1.Text != textBox2.Text)
                {
                    MessageBox.Show("Confarmed Password and New Password Not Matched!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string query3 = "Update AllUser SET Password ='" + textBox1.Text + "' where ID = ' " + ID + "'";

                    SqlCommand updateData = new SqlCommand(query3);

                    updateData.Parameters.AddWithValue("@Password", textBox1.Text);

                    int row = db.executeQuery(updateData);

                    if (row == 1)
                    {
                        MessageBox.Show("Information Updated! Please Log In Again", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoginForm l = new LoginForm();
                        l.Show();
                        this.Hide();

                    }
                }

            }
            else
            {
                MessageBox.Show("Wrong Pass", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)   //Back Button
        {
            string position = LoginForm.position;

            if (position == "Owner")
            {
                OwnerForm w = new OwnerForm();
                w.Show();
                this.Hide();
            }

            else if (position == "Receptionist")
            {

                Coffee_Shop_Management_System.CafeBilling w = new Coffee_Shop_Management_System.CafeBilling();
                w.Show();
                this.Hide();
            }

            else if (position == "Cook")
            {
                Coffee_Shop_Management_System.CoffeeDetails w = new Coffee_Shop_Management_System.CoffeeDetails();
                w.Show();
                this.Hide();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        string mood;
        //static public string ID;
        void DarkMood()
        {
            mood = "ON";
            //MessageBox.Show(mood, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string update = "Update AllUser SET DarkMood ='" + mood + "' where ID = ' " + ID + " ' ";
            SqlCommand updateData = new SqlCommand(update);
            updateData.Parameters.AddWithValue("@DarkMood", mood);
            int row = db.executeQuery(updateData);

            if (row == 1)
            {

                this.BackColor = Color.FromArgb(64, 64, 64);
                label3.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }


        }


        void LightMood()
        {
            mood = "OFF";
            string update = "Update AllUser SET DarkMood ='" + mood + "' where ID = ' " + ID + " ' ";
            SqlCommand updateData = new SqlCommand(update);
            updateData.Parameters.AddWithValue("@DarkMood", mood);
            int row = db.executeQuery(updateData);

            if (row == 1)
            {


                this.BackColor = Color.White;
                label3.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;

            }


        }
        private void UpdatePasswordForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ID = LoginForm.ID;
            DataTable TampTable = new DataTable();
            string qurey = "Select * from AllUser Where ID ='" + ID + "'";

            db.readDatathroughAdapter(qurey, TampTable);
            if (TampTable.Rows.Count == 1)
            {

                mood = TampTable.Rows[0]["DarkMood"].ToString();

                if (mood == "OFF" || mood == "")
                {

                    this.LightMood();
                }

                else if (mood == "ON")
                {
                    this.DarkMood();

                }
            }
        }
    }
}
