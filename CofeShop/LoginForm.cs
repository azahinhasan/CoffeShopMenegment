using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;

namespace CofeShop
{

    public partial class LoginForm : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        DataTable TampTable = new DataTable();
        string pass;
        int id, seen_value = 0;
        static public string ID, position;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (ID_taxtbox.Text == "") { id = 0; }
            else { id = Convert.ToInt32(ID_taxtbox.Text); }
            pass = Pass_textBox.Text;


            if (id == 0)
            {
                Coffee_Shop_Management_System.WelcomePage b = new Coffee_Shop_Management_System.WelcomePage();
                b.Show();
                this.Hide();
            }


            string qurey = "Select * from AllUser Where ID ='" +id+ "'AND Password ='" +pass+ "'";

                db.readDatathroughAdapter(qurey, TampTable);

                if (TampTable.Rows.Count == 1)
                {

                    position = TampTable.Rows[0]["Position"].ToString();
                    ID = TampTable.Rows[0]["ID"].ToString();


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
                else
                {

                    MessageBox.Show("Wrong Password or ID!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You donn't have any access.Please Contect with Owner", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ID_taxtbox.Text = "";
            Pass_textBox.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            Pass_textBox.PasswordChar = '⚫';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (seen_value == 0) { Pass_textBox.PasswordChar = default(char); seen_value = 1; }   //unmask
            else { Pass_textBox.PasswordChar = '⚫'; seen_value = 0; }
        }

        private void Pass_textBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ID_taxtbox.Text == "") { id = 0; }
                else { id = Convert.ToInt32(ID_taxtbox.Text); }
                pass = Pass_textBox.Text;


                if (id == 0  && pass == "0")
                {

                    Coffee_Shop_Management_System.WelcomePage b = new Coffee_Shop_Management_System.WelcomePage();
                    b.Show();
                    this.Hide();
                }

                else
                {
                    string qurey = "Select * from AllUser Where ID ='" + id + "'AND Password ='" + pass + "'";

                    db.readDatathroughAdapter(qurey, TampTable);

                    if (TampTable.Rows.Count == 1)
                    {

                        position = TampTable.Rows[0]["Position"].ToString();
                        ID = TampTable.Rows[0]["ID"].ToString();


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
                    else if (e.KeyChar == (char)Keys.Escape)
                    {
                        ID_taxtbox.Text = "";
                        Pass_textBox.Text = "";
                    }

                }
            }
        }
    }
}
