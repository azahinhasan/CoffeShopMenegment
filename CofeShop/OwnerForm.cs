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
    public partial class OwnerForm : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void NewUser_button_Click(object sender, EventArgs e)
        {


        }

        private void SignOut_button_Click(object sender, EventArgs e)
        {

        }

        string mood;
        static public string ID;
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
                button2.Text = "ON";
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(64, 64, 64);                   
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
                button2.Text = "OFF";
                label2.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                this.BackColor = Color.White;

            }
            

        }


        private void button2_Click(object sender, EventArgs e)     //Mood Change
        {
            // this.BackColor = Color.Black;
            //// string ID:
            ID = LoginForm.ID;
           // ID = "3";
            DataTable TampTable = new DataTable();
            string qurey = "Select * from AllUser Where ID ='" + ID + "'";

            db.readDatathroughAdapter(qurey, TampTable);
            if (TampTable.Rows.Count == 1)
            {

                mood = TampTable.Rows[0]["DarkMood"].ToString();

               //Console.WriteLine(ID); MessageBox.Show(mood, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (mood == "OFF" || mood == "")
                {
                    this.DarkMood();
                }

                else if(mood == "ON")
                {
                   // this.DarkMood();
                   this.LightMood();
                }




            }
            else { Console.WriteLine(ID); MessageBox.Show("Failed!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }



        private void OwnerForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //ID = "3";
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




        private void regNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser_Form AUF = new AddUser_Form();
            AUF.Show();
            this.Hide();
        }

        private void updateUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserInfo_Form UUI = new UpdateUserInfo_Form();
            this.Hide();
            UUI.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CofeInfo_Form c = new CofeInfo_Form();
            this.Hide();
            c.Show();
        }



        private void salaryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryInfo_Form s = new SalaryInfo_Form();
            s.Show();
            this.Hide();
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePasswordForm up = new UpdatePasswordForm();
            this.Hide();
            up.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }
    }
}
