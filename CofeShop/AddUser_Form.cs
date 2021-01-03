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
    public partial class AddUser_Form : Form
    {
        public static string Name, Address, Email, Married_Status, Gander, Working_Time, Shift,Birthday;
        public static string  Password;
        public static string Phone, NID, Montly_Sal, Position, Workking_Status;
        public static byte[] Photo = null;
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();



        public AddUser_Form()
        {
            InitializeComponent();
        }





        string RandomPass()
        {
            Random rnd = new Random();

            string[] l = { "a", "b", "c", "d","e" };
            string[] n = { "1", "2", "3", "4", "5","0","6" };
            string password="";

            for(int i =0; i<3;i++)
            {
                password = password + l[rnd.Next(0, 4)];
            }

            for (int i = 0; i < 3; i++)
            {
                password = password + n[rnd.Next(0, 7)];
            }

            return password;
        }

        private bool IsEMailAddrValid(string emailAddr)
        {
            bool result = true;
            int count = emailAddr.Count(f => f == '@');
            if (count == 0)
            {
                return false;
            }
            if (count > 1)
            {
                return false;
            }
            count = emailAddr.Count(f => f == '.');
            if (count == 0)
            {
                return false;
            }
            if (count > 1)
            {
                return false;
            }
            string theChar = emailAddr.Split('@')[1].ToString();
            int theCharLen = theChar.Split('.')[0].ToString().Length;
            if (theCharLen < 2)
            {
                result = false;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.White)
            {
                LightMood();

            }

            else if(this.BackColor == Color.Black)
            {
                DarkMood();
            }

            Name = textBox1.Text;
            Address = textBox2.Text; Email = textBox3.Text;
            Phone = textBox4.Text; NID = textBox5.Text; 
            Montly_Sal = numericUpDown1.Text;
            Position = comboBox1.Text; Workking_Status = groupBox5.Text;
            Birthday=dateTimePicker1.Text;
            bool isValid = IsEMailAddrValid(Email);

            if (radioButton1.Checked) { Married_Status = "Married"; }
            else if (radioButton2.Checked) { Married_Status = "Unmarried"; }
            else { Married_Status = ""; }

            if (radioButton4.Checked) { Gander = "Male"; }
            else if (radioButton3.Checked) { Gander = "Female"; }
            else { Gander = ""; }

            if (radioButton6.Checked) { Working_Time = "Fulltime"; Shift = "Full"; }
            else if (radioButton5.Checked) { Working_Time = "Halftime";  }
            else { Working_Time = ""; }

            if (radioButton8.Checked) { Shift = "Day"; }
            else if (radioButton7.Checked) { Shift = "Night"; }
            else { Shift = ""; }

            if (radioButton10.Checked) { Workking_Status = "Not Available"; }
            else if (radioButton9.Checked) { Workking_Status = "Available"; }
            else { Workking_Status = ""; }



            //label1.ForeColor = Color.Black;
            //label2.ForeColor = Color.Black;
            //label3.ForeColor = Color.Black;
            //label4.ForeColor = Color.Black;
            //label5.ForeColor = Color.Black;
            //label6.ForeColor = Color.Black;
            //label7.ForeColor = Color.Black;
            //label8.ForeColor = Color.Black;
            //label10.ForeColor = Color.Black;


            void emptyTextBox() { MessageBox.Show("All TaxBox is not Fillup or Any thing Wrong!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            try
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                Photo = brs.ReadBytes((int)stream.Length);
            }
            catch
            {
                Photo = null;
            }


            if (Name.Equals("")) { label1.ForeColor = Color.Red; emptyTextBox();}
            else if (Address.Equals("")) { label2.ForeColor = Color.Red; emptyTextBox(); }

            
            else if (Email.Equals("") || isValid == false) {
                label3.ForeColor = Color.Red; emptyTextBox(); label17.Show(); 
                }

            else if (Phone.Equals("")) { label4.ForeColor = Color.Red; emptyTextBox(); }
            else if (NID.Equals("") || NID.Length!=12) { label5.ForeColor = Color.Red; emptyTextBox();  if (NID.Length != 12) { label15.Show(); } else { label15.Hide(); } }

            else if (Married_Status.Equals("")) { label6.ForeColor = Color.Red; emptyTextBox(); }
            else if (Gander.Equals("")) { label7.ForeColor = Color.Red; emptyTextBox(); }
            else if (Working_Time.Equals("")) { label8.ForeColor = Color.Red; emptyTextBox(); }
            else if (Montly_Sal.Equals("")) { label10.ForeColor = Color.Red; emptyTextBox(); }

            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }
            //else if (Email.Equals("")) { label3.ForeColor = Color.Red; emptyTextBox(); }


            else if (Photo == null) { emptyTextBox(); }


            else
            {
                DialogResult dialog = MessageBox.Show("Do you want to Add This New User?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                  //  Random rnd = new Random();
                    //  Password = rnd.Next(1000, 5000);  ////////////////////////////////////////////////////////////////////////

                    Password = RandomPass();


                    //Photo = null;




                    SqlCommand insert = new SqlCommand("insert into AllUser(Password,Name,NID,Address,Email,Phone,Married_Status,Gander,Working_Time,Montly_Sal,Position,Workking_Status,Shift,Photo,Birthday)" +
                        "" +
                        " values(@Password,@Name,@NID,@Address,@Email,@Phone,@Married_Status,@Gander,@Working_Time,@Montly_Sal,@Position,@Workking_Status,@Shift,@Photo,@Birthday)");

                   insert.Parameters.AddWithValue("@Password", @Password);
                    insert.Parameters.AddWithValue("@Name", Name);
                    insert.Parameters.AddWithValue("@NID", NID);

                    insert.Parameters.AddWithValue("@Address", Address);
                    insert.Parameters.AddWithValue("@Email", Email);
                    insert.Parameters.AddWithValue("@Phone", Phone);
                    insert.Parameters.AddWithValue("@Married_Status", Married_Status);
                    insert.Parameters.AddWithValue("@Gander", Gander);

                    insert.Parameters.AddWithValue("@Working_Time", Working_Time);
                    insert.Parameters.AddWithValue("@Montly_Sal", Montly_Sal);
                    insert.Parameters.AddWithValue("@Position", Position);
                    insert.Parameters.AddWithValue("@Workking_Status", Workking_Status);
                    insert.Parameters.AddWithValue("@Shift", Shift);
                    insert.Parameters.AddWithValue("@Photo",@Photo);
                    insert.Parameters.AddWithValue("@Birthday", Birthday);


                    int row = db.executeQuery(insert);

                    if (row == 1)
                    {
                        PrintUserInfo_Form PUF = new PrintUserInfo_Form();
                        PUF.Show();

                    }
                    string Year = DateTime.Now.ToString("yyyy");

                    DataTable TampTable = new DataTable();
                    string qurey = "Select * from AllUser Where NID ='" + NID + "'AND Name ='" + Name + "'";

                    db.readDatathroughAdapter(qurey, TampTable);
                    string ID;

                    ID = TampTable.Rows[0]["ID"].ToString();



                    SqlCommand insert2 = new SqlCommand("insert into SalaryList(ID,Name,Year) values(@ID,@Name,@Year)");   //insert in salary

                    insert2.Parameters.AddWithValue("@ID", ID);
                    insert2.Parameters.AddWithValue("@Name", Name);
                    insert2.Parameters.AddWithValue("@Year", Year);
                    row = db.executeQuery(insert2);

                    if (row == 1) { MessageBox.Show("Done"); }
                }
            }
        }
        string imgLocation = "";
       // SqlCommand cmd;
        private void Upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog di = new OpenFileDialog();
            di.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (di.ShowDialog() == DialogResult.OK)
            {

                imgLocation = di.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            OwnerForm OF = new OwnerForm();
            OF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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

            this.Hide();
            AddUser_Form a = new AddUser_Form();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
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
                // button2.Text = "ON";
                //label2.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(64, 64, 64);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label10.ForeColor =Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label11.ForeColor = Color.White;
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
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
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
        private void AddUser_Form_Load(object sender, EventArgs e)
        {
            
            label9.Hide(); groupBox4.Hide();
            label15.Hide();
            label17.Hide();
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
                    //I made a change here
                  //this.DarkMood();
                }

                else if (mood == "ON")
                {
                    this.DarkMood();

                }

            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
             label9.Hide(); groupBox4.Hide();
            Shift = "Full";
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label9.Show(); groupBox4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
