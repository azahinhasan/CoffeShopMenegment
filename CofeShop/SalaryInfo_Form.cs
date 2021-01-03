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
    public partial class SalaryInfo_Form : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        //DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        static public string ID, eName, January, Amount,Year,Month,AmountWithoutBouns;
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
                //label2.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(64, 64, 64);
                label4.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label1.ForeColor = Color.White;

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
                label4.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;

            }


        }

        private void SalaryInfo_Form_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MaximizeBox = false;
            numericUpDown1.Maximum = 50000000000;
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

        static public string bonus,TotalAmount;

        private void SignOut_button_Click(object sender, EventArgs e)
        {
            OwnerForm OF = new OwnerForm();
            OF.Show();
            this.Hide();
        }

        void emptyTextBox() { MessageBox.Show("All TaxBox is not Fillup or Any thing Wrong!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        private void button3_Click(object sender, EventArgs e) //Load Button
        {
            label2.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;


            ID = textBox2.Text;
           // eName = textBox1.Text;
            Month = comboBox1.Text;
            Amount = numericUpDown1.Text;
            Year = comboBox2.Text;
            bonus= numericUpDown2.Text;
            AmountWithoutBouns = Amount;
            Amount =Convert.ToString(Convert.ToInt32(Amount) + Convert.ToInt32(bonus));


            //if (ID == "") { label2.ForeColor = Color.Red; emptyTextBox(); }

            //else if (Month == "") { label13.ForeColor = Color.Red; emptyTextBox(); }

            //else if (Year == "") { label4.ForeColor = Color.Red; emptyTextBox(); }

            // ID = "2";
            //else
            //{
                button1.Enabled = true;

                string qurey = "Select * from SalaryList where ID = '" +ID+ "'";

                DataTable TampTable = new DataTable();
                db.readDatathroughAdapter(qurey, TampTable);
            if (TampTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = TampTable;

                eName = TampTable.Rows[0]["Name"].ToString();

                db.closeConn();

            }
            //}
        }
        int row = 0;
        public SalaryInfo_Form()
        {
            InitializeComponent();
        }

        void addSal(string Month)    //sallllllllllllllllllll
        {


            
            if (Month == "January")
            {
              //MessageBox.Show(ID+" "+Amount+" "+Year, "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                string update = "Update SalaryList SET January ='" + Amount+"' where ID = '"+ID+"'AND Year ='"+Year+"'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@January", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "February")
            {

                string update = "Update SalaryList SET February ='"+ Amount +"' where ID = '"+ ID +"'AND Year ='"+Year +"'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@February", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "March")
            {
                string update = "Update SalaryList SET March ='"+Amount+"' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@March", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "April")
            {
                string update = "Update SalaryList SET April ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@April", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "May")
            {
                string update = "Update SalaryList SET May ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@May", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "June")
            {
                string update = "Update SalaryList SET June ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@June", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "July")
            {
                string update = "Update SalaryList SET July ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@July", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "August")
            {
                string update = "Update SalaryList SET August ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@August", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "September")
            {
                string update = "Update SalaryList SET September ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@September", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "October")
            {
                string update = "Update SalaryList SET October ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@October", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "November")
            {
                string update = "Update SalaryList SET November ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@November", Amount);
                row = db.executeQuery(updateData);

            }
            else if (Month == "December")
            {
                string update = "Update SalaryList SET December ='" + Amount + "' where ID = '" + ID + " 'AND Year ='" + Year + "'";
                SqlCommand updateData = new SqlCommand(update);
                updateData.Parameters.AddWithValue("@December", Amount);
                row = db.executeQuery(updateData);

            }



        }

        private void button1_Click(object sender, EventArgs e) //Save Button
        {

            ID = textBox2.Text;
            Year = comboBox2.Text;
            Month = comboBox1.Text;
            Amount = numericUpDown1.Text;
            Year = comboBox2.Text;
            bonus = numericUpDown2.Text;
            AmountWithoutBouns = Amount;
            Amount = Convert.ToString(Convert.ToInt32(Amount) + Convert.ToInt32(bonus));
            //  eName

            if (ID == "") { label2.ForeColor = Color.Red; emptyTextBox(); }

            else if (Month == "") { label13.ForeColor = Color.Red; emptyTextBox(); }

            else if (Year == "") { label4.ForeColor = Color.Red; emptyTextBox(); }


            else
            {
                DataTable TampTable = new DataTable();

                string qurey = "Select * from SalaryList Where ID ='" + ID + "' AND Year ='" + Year + "'";

                db.readDatathroughAdapter(qurey, TampTable);



                if (TampTable.Rows.Count == 1)
                {

                    addSal(Month);
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PrintReciptOFSalary P = new PrintReciptOFSalary();
                    P.Show();
                    // this.Hide();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("No data Found accoding to given year.Wanna create New?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (dialog == DialogResult.Yes)
                    {
                        SqlCommand insert2 = new SqlCommand("insert into SalaryList(ID,Name,Year) values(@ID,@eName,@Year)");   //insert in salary

                        insert2.Parameters.AddWithValue("@ID", ID);
                        insert2.Parameters.AddWithValue("@eName", eName);
                        insert2.Parameters.AddWithValue("@Year", Year);
                        row = db.executeQuery(insert2);

                        if (row == 1)
                        {
                            MessageBox.Show("Done"); addSal(Month); PrintReciptOFSalary P = new PrintReciptOFSalary();
                            P.Show();
                        }

                    }
                }
            }
        }
    }
}


// Condition for IF Salary given
//exception for upload PIC
