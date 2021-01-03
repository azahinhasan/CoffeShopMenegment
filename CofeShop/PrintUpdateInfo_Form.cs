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
    public partial class PrintUpdateInfo_Form : Form
    {
        public PrintUpdateInfo_Form()
        {
            InitializeComponent();
        }

        private void PrintUpdateInfo_Form_Load(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("M/d/yyyy");
            label1.Text = UpdateUserInfo_Form.Name;
            label5.Text = UpdateUserInfo_Form.Password;
            label3.Text = UpdateUserInfo_Form.ID;
            label7.Text = UpdateUserInfo_Form.Phone;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            this.button1.Show();
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


            ControlBox = true;
        }
    }
}
