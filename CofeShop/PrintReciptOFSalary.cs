using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeShop
{
    public partial class PrintReciptOFSalary : Form
    {
        DatabaseProject.DBAccess db = new DatabaseProject.DBAccess();
        public PrintReciptOFSalary()
        {
            InitializeComponent();
        }
        string eName,ID;
        private void PrintReciptOFSalary_Load(object sender, EventArgs e)
        {
           ID = LoginForm.ID; ;

           // ID = "8";
            string qurey = "Select * from AllUser where ID = ' " + ID + " '";

            DataTable TampTable = new DataTable();
            db.readDatathroughAdapter(qurey, TampTable);

            eName = TampTable.Rows[0]["Name"].ToString();

            db.closeConn();


            label28.Text = eName;
            label3.Text = SalaryInfo_Form.eName;
            label4.Text = SalaryInfo_Form.ID;
            label10.Text = SalaryInfo_Form.Month;
            label12.Text = SalaryInfo_Form.AmountWithoutBouns;
            label32.Text = SalaryInfo_Form.bonus;
            label34.Text = SalaryInfo_Form.Amount;
            label30.Text = DateTime.Now.ToString("M/d/yyyy"); //date

            label17.Text = eName;
            label22.Text = SalaryInfo_Form.eName;
            label21.Text = SalaryInfo_Form.ID;
            label15.Text = SalaryInfo_Form.Month;
            label13.Text = SalaryInfo_Form.AmountWithoutBouns;
            label38.Text = SalaryInfo_Form.bonus;
            label36.Text = SalaryInfo_Form.Amount;
            label19.Text = DateTime.Now.ToString("M/d/yyyy");


        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 2, 2, this.Size);
            printPreviewDialog1.ShowDialog();

            button1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            this.button1.Show();
        }
    }


}

