using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coffee_Shop_Management_System
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePassword_Click(object sender, EventArgs e)
        {

        }

        private void MenuList_Click(object sender, EventArgs e)
        {
            this.Hide();
            BhaiBhaiCoffeeShop b = new BhaiBhaiCoffeeShop();
            b.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are You Sure Want to Log Out Buddy?", "Bhai Bhai Coffee Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Good Bye!!\nSee You Again :D");
                Application.Exit();
            }
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
