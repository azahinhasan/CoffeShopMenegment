using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CofeShop
{
    public partial class PrintUserInfo_Form : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        DataTable TampTable = new DataTable();
        public PrintUserInfo_Form()
        {
            InitializeComponent();
        }

        
        
        private void PrintUserInfo_Form_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            
            string id;

           MemoryStream mstream = new MemoryStream(AddUser_Form.Photo);
           pictureBox1.Image = Image.FromStream(mstream);

            label9.Text = AddUser_Form.Name;
            label11.Text = AddUser_Form.Address;
            label12.Text = AddUser_Form.Email;
            label17.Text = AddUser_Form.Phone;
            label18.Text = AddUser_Form.Married_Status;
            label20.Text = AddUser_Form.Gander;
            label19.Text = AddUser_Form.Workking_Status;
            label22.Text = AddUser_Form.Shift;
            label5.Text = AddUser_Form.Montly_Sal;
            label27.Text = AddUser_Form.NID;
            label25.Text = AddUser_Form.Working_Time;
            label29.Text =AddUser_Form.Password;
            label16.Text = AddUser_Form.Position;
            label31.Text = DateTime.Now.ToString("M/d/yyyy");

            string qurey = "Select * from AllUser Where NID ='" + label27.Text + "'AND Name ='" + label9.Text + "'";

            db.readDatathroughAdapter(qurey, TampTable);

            if (TampTable.Rows.Count == 1)
            {
                id = TampTable.Rows[0]["ID"].ToString();
                label30.Text = id;
            }



            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            this.Print_button.Show();

        }
        Bitmap bmp;
        private void Print_button_Click(object sender, EventArgs e)
        {
            Print_button.Hide();

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

            Print_button.Show();


            ControlBox = true;
        }


    }
}
