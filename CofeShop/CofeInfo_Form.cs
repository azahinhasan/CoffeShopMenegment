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
    public partial class CofeInfo_Form : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        static public string ID;
        public CofeInfo_Form()
        {
            InitializeComponent();
        }
        string mood;
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
                // button2.Text = "ON";
                this.BackColor = Color.FromArgb(64, 64, 64);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label16.ForeColor = Color.White;

                radioButton6.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
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
                // button2.Text = "OFF";
                //////label2.ForeColor = Color.Black;
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;

                radioButton6.ForeColor = Color.Black;
                radioButton5.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  //Load All Coffee List
        {
            string qurey = "Select * from CoffeeList ";

            DataTable TampTable = new DataTable();
            db.readDatathroughAdapter(qurey, TampTable);
            dataGridView1.DataSource = TampTable;
            db.closeConn();
        }

        private void CofeInfo_Form_Load(object sender, EventArgs e)   
        {
            // button2
            MaximizeBox = false;
            numericUpDown1.Maximum = 50000000;
            numericUpDown2.Maximum = 50000000;
            ID = LoginForm.ID;
            DataTable TampTable = new DataTable();
            string qurey = "Select * from AllUser Where ID ='" + ID + "'";   //For Dark Mood

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


            string qurey2 = "Select * from CoffeeList ";         //for Cofee List
            DataTable TampTable2 = new DataTable();
            db.readDatathroughAdapter(qurey2, TampTable2);
            dataGridView1.DataSource = TampTable2;
            db.closeConn();


            qurey2 = "Select Vat from OtherData ";
            DataTable TampTable3 = new DataTable();
            db.readDatathroughAdapter(qurey2, TampTable3);
            textBox4.Text = TampTable3.Rows[0]["Vat"].ToString();

           // textBox4.Text = qurey2.Rows[0].ToString();
        }

        static public string cName, Available_Status;
        static public int Price;

        private void button2_Click(object sender, EventArgs e)                      //update Coffee Info            
        {
            cName = textBox2.Text;
            Price = Convert.ToInt32(numericUpDown2.Text);
            if (radioButton5.Checked) { Available_Status = "Yes"; }
            else if (radioButton6.Checked) { Available_Status = "No"; }

            string query = "Update CoffeeList SET CoffeeName ='" + cName + "',Price ='" + Price + "',Status ='" + Available_Status + "' where ID = ' " + textBox1.Text + " ' ";

            SqlCommand updateData = new SqlCommand(query);

            updateData.Parameters.AddWithValue("@CoffeeName", cName);
            updateData.Parameters.AddWithValue("@Price", Price);
            updateData.Parameters.AddWithValue("@Status", Available_Status);



            int row = db.executeQuery(updateData);

            if (row == 1)
            {
                MessageBox.Show("Information Updated", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button4_Click(object sender, EventArgs e)        //Load Button
        {
            DataTable TampTable = new DataTable();

            button2.Enabled = true;
            string qurey = "Select * from CoffeeList Where ID ='" + textBox1.Text + "'";

            db.readDatathroughAdapter(qurey, TampTable);

            if (TampTable.Rows.Count == 1)
            {
                textBox1.ReadOnly = true;
                textBox2.Text = TampTable.Rows[0]["CoffeeName"].ToString(); 
                string tempPrice = TampTable.Rows[0]["Price"].ToString();
                numericUpDown2.Value = Convert.ToInt32(tempPrice);

                Available_Status= TampTable.Rows[0]["Status"].ToString();
                if (Available_Status == "Yes") { radioButton5.Checked = true; }
                else { radioButton6.Checked = true; }

            }
            else { }


        }

        private void button5_Click(object sender, EventArgs e)    //Save Vat Button
        {

            string Vat = textBox4.Text;
            string query = "Update OtherData SET Vat ='" + Vat + "'  where ID = ' " + "1" + " ' ";

            SqlCommand updateData = new SqlCommand(query);

            updateData.Parameters.AddWithValue("@Vat", Vat);
            int row = db.executeQuery(updateData);

            if (row == 1)
            {
                label15.Text = "New Vat Updated";
                label15.ForeColor = Color.Blue;

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OwnerForm OF = new OwnerForm();
            OF.Show();
            this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            //label2.Hide();
            //label4.Hide();
            //label12.Hide();
            //label6.Hide();
            //label8.Hide();
            //textBox1.Hide();
            //textBox2.Hide();
            //groupBox3.Hide();
            //numericUpDown2.Hide();
            //Remove_button.Hide();
            //button2.Hide();

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            panel1.Show();

            panel2.Hide();



        }



        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            panel2.Show();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panel1.Show();

            panel2.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CofeInfo_Form c = new CofeInfo_Form();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)                      //save new items
        {
            cName = textBox3.Text;
            Price = Convert.ToInt32(numericUpDown1.Text);
            if (radioButton1.Checked) { Available_Status = "Yes"; }
            else if (radioButton2.Checked) { Available_Status = "No"; }

            SqlCommand insert = new SqlCommand("insert into CoffeeList(CoffeeName,Price,Status) values(@cName,@Price,@Available_Status)");

            insert.Parameters.AddWithValue("@cName", cName);
            insert.Parameters.AddWithValue("@Price", Price);
            insert.Parameters.AddWithValue("@Available_Status", Available_Status);


            int row = db.executeQuery(insert);

            if (row == 1)
            {
                MessageBox.Show("Adding Successfully");
            }
        }
    }
}
