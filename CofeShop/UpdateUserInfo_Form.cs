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
    public partial class UpdateUserInfo_Form : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        DatabaseProject.DBAccess db2 = new DatabaseProject.DBAccess();
        public static string Name, Address, Email, Married_Status, Gander, Working_Time, Shift;
        public static string Password;
        public static string ID;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)             //Update Button
        {

            if (this.BackColor == Color.White)
            {
                LightMood();

                //DarkMood();
            }

            else if (this.BackColor == Color.Black)
            {
                DarkMood();
            }

            Name = textBox1.Text;
            Address = textBox2.Text; Email = textBox3.Text;
            Phone = textBox4.Text; NID = textBox5.Text;
            Montly_Sal = numericUpDown1.Text;
            Position = comboBox1.Text; Workking_Status = groupBox5.Text;
            Password = textBox7.Text;


            if (radioButton1.Checked) { Married_Status = "Married"; }
            else if (radioButton2.Checked) { Married_Status = "Unmarried"; }
            else { Married_Status = ""; }

            if (radioButton4.Checked) { Gander = "Male"; }
            else if (radioButton3.Checked) { Gander = "Female"; }
            else { Gander = ""; }

            if (radioButton6.Checked) { Working_Time = "FullTime"; Shift = "Full"; }
            else if (radioButton5.Checked) { Working_Time = "HalfTime"; }
            else { Working_Time = ""; }

            if (radioButton8.Checked) { Shift = "Day"; }
            else if (radioButton7.Checked) { Shift = "Night"; }
            else { Shift = ""; }

            if (radioButton10.Checked) { Workking_Status = "Not"; }
            else if (radioButton9.Checked) { Workking_Status = "Avable"; }
            else { Workking_Status = ""; }






            void emptyTextBox() { MessageBox.Show("All TaxBox is not Fillup or Any thing Wrong!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            if (Name.Equals("")) { label1.ForeColor = Color.Red; emptyTextBox(); }
            else if (Address.Equals("")) { label2.ForeColor = Color.Red; emptyTextBox(); }
            else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            else if (Phone.Equals("")) { label4.ForeColor = Color.Red; emptyTextBox(); }
            else if (NID.Equals("") || NID.Length != 12) { label5.ForeColor = Color.Red; emptyTextBox(); if (NID.Length != 12) { label15.Show(); } else { label15.Hide(); } }

            else if (Married_Status.Equals("")) { label6.ForeColor = Color.Red; emptyTextBox(); }
            else if (Gander.Equals("")) { label7.ForeColor = Color.Red; emptyTextBox(); }
            else if (Working_Time.Equals("")) { label8.ForeColor = Color.Red; emptyTextBox(); }
            else if (Montly_Sal.Equals("")) { label10.ForeColor = Color.Red; emptyTextBox(); }

            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }

            else
            {
                DialogResult dialog = MessageBox.Show("Do you want to Add This New User?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {

                    try
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        Photo = brs.ReadBytes((int)stream.Length);


                    }
                    catch { }



                    string query = "Update AllUser SET Password ='" + Password + "',Name ='" + Name + "',NID ='" + NID + "',Address ='" + Address + "',Email ='" + Email + "', Phone ='" + Phone + "',Married_Status ='"+ Married_Status + "',Gander ='" + Gander + "',Working_Time ='" + Working_Time + "',Montly_Sal ='" + Montly_Sal + "',Position ='" + Position + "',Workking_Status ='" + Workking_Status + "',Shift ='" + Shift + "', Photo = @Photo where ID = ' " + textBox6.Text + " ' ";

                    SqlCommand updateData = new SqlCommand(query);



                    updateData.Parameters.AddWithValue("@Password", Password);
                    updateData.Parameters.AddWithValue("@Name", Name);
                    updateData.Parameters.AddWithValue("@NID", NID);

                    updateData.Parameters.AddWithValue("@Address", Address);
                    updateData.Parameters.AddWithValue("@Email", Email);
                    updateData.Parameters.AddWithValue("@Phone", Phone);
                    updateData.Parameters.AddWithValue("@Married_Status", Married_Status);
                    updateData.Parameters.AddWithValue("@Gander", Gander);

                    updateData.Parameters.AddWithValue("@Working_Time", Working_Time);
                    updateData.Parameters.AddWithValue("@Montly_Sal", Montly_Sal);
                    updateData.Parameters.AddWithValue("@Position", Position);
                    updateData.Parameters.AddWithValue("@Workking_Status", Workking_Status);
                    updateData.Parameters.AddWithValue("@Shift", Shift);
                    updateData.Parameters.AddWithValue("@Photo", Photo);


                    int row = db.executeQuery(updateData);

                    if (row == 1)
                    {
                        MessageBox.Show("Information Updated", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        string imgLocation = "";

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label9.Show(); groupBox4.Show();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label9.Hide(); groupBox4.Hide();
            Shift = "Full";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdateUserInfo_Form UUF = new UpdateUserInfo_Form();
            UUF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
           // textBox7.ReadOnly = false;

            Random rnd = new Random();


                string[] l = { "a", "b", "c", "d", "e" };
                string[] n = { "1", "2", "3", "4", "5", "0", "6" };
                string password = "";

                for (int i = 0; i < 3; i++)
                {
                    password = password + l[rnd.Next(0, 4)];
                }

                for (int i = 0; i < 3; i++)
                {
                    password = password + n[rnd.Next(0, 7)];
                }

            Password = password;
            textBox7.Text = Password;

        }

        private void SignOut_button_Click(object sender, EventArgs e)
        {
            OwnerForm OF = new OwnerForm();
            OF.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintUpdateInfo_Form PUI = new PrintUpdateInfo_Form();
            //this.Hide();
            PUI.Show();

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
               // button2.Text = "ON";
                //label2.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(64, 64, 64);
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton6.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton10.ForeColor = Color.White;
                radioButton9.ForeColor = Color.White;
                radioButton8.ForeColor = Color.White;
                radioButton7.ForeColor = Color.White;
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
                label15.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton4.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                radioButton6.ForeColor = Color.Black;
                radioButton5.ForeColor = Color.Black;
                radioButton10.ForeColor = Color.Black;
                radioButton9.ForeColor = Color.Black;
                radioButton8.ForeColor = Color.Black;
                radioButton7.ForeColor = Color.Black;
            }


        }
        private void UpdateUserInfo_Form_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            button2.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            numericUpDown1.Maximum = 50000000;

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

        private void button1_Click(object sender, EventArgs e)           // Picture Upload
        {
            OpenFileDialog di = new OpenFileDialog();
            di.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (di.ShowDialog() == DialogResult.OK)
            {

                imgLocation = di.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

            }


        }


        public static string Phone, NID, Montly_Sal, Position, Workking_Status;
        public static byte[] Photo = null;

       // DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        DataTable TampTable = new DataTable();

        public UpdateUserInfo_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)                      // Load Button
        {
            button2.Enabled = true;

            string qurey = "Select * from AllUser Where ID ='" +textBox6.Text+ "'";

            db.readDatathroughAdapter(qurey, TampTable);

            if (this.BackColor == Color.White)
            {
                LightMood();

                //DarkMood();
            }

            else if (this.BackColor == Color.Black)
            {
                DarkMood();
            }

            if (TampTable.Rows.Count == 1)
            {



                Password = TampTable.Rows[0]["Password"].ToString();
                Name = TampTable.Rows[0]["Name"].ToString();
                NID = TampTable.Rows[0]["NID"].ToString();
                Address = TampTable.Rows[0]["Address"].ToString();
                Email = TampTable.Rows[0]["Email"].ToString();

                Phone = TampTable.Rows[0]["Phone"].ToString();
                Married_Status = TampTable.Rows[0]["Married_Status"].ToString();
                Gander = TampTable.Rows[0]["Gander"].ToString();
                Working_Time = TampTable.Rows[0]["Working_Time"].ToString();

                Montly_Sal = TampTable.Rows[0]["Montly_Sal"].ToString();
                Position = TampTable.Rows[0]["Position"].ToString();
                Workking_Status = TampTable.Rows[0]["Workking_Status"].ToString();
                Shift = TampTable.Rows[0]["Shift"].ToString();
                ID = TampTable.Rows[0]["ID"].ToString();

                //dateTimePicker1. = TampTable.Rows[0]["ID"].ToString();

                Photo = ((byte[])TampTable.Rows[0]["Photo"]);



                textBox7.Text = Password;
                textBox1.Text = Name;
                textBox2.Text = Address;
                textBox3.Text = Email;
                textBox4.Text = Phone;
                textBox5.Text = NID;


                if (Married_Status == "Married") { radioButton1.Checked = true; radioButton2.Checked = false; }
                else if (Married_Status == "Unmarried") { radioButton2.Checked = true; radioButton1.Checked = false; }

                if (Gander == "Male") { radioButton4.Checked = true; radioButton3.Checked = false; }
                else if (Gander == "Female") { radioButton3.Checked = true; radioButton4.Checked = false; }

                if (Working_Time == "FullTime") { radioButton6.Checked = true; radioButton5.Checked = false; }          ///////////////////////////
                else if (Working_Time == "HalfTime") { radioButton5.Checked = true; radioButton6.Checked = false; }

                if (Shift == "Day") { radioButton8.Checked = true; radioButton7.Checked = false; }
                else if (Shift == "Night") { radioButton7.Checked = true; radioButton8.Checked = false; }

                if (Workking_Status == "Not Available") { radioButton10.Checked = true; radioButton9.Checked = false; }
                else if (Workking_Status == "Available") { radioButton9.Checked = true; radioButton10.Checked = false; }

                //if () { }

                try
                {
                    MemoryStream mstream = new MemoryStream(Photo);
                    pictureBox1.Image = Image.FromStream(mstream);
                }
                catch { }



                if (Position == "Owner") { comboBox1.Text = "Owner"; }
                else if (Position == "Receptionist") { comboBox1.Text = "Receptionist"; }
                else if (Position == "Cook") { comboBox1.Text = "Cook"; }

                textBox6.BackColor = Color.FromArgb(255,128,128);
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;




            }

            else 
            {
                MessageBox.Show("Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}

// lock password