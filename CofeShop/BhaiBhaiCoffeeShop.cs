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

namespace Coffee_Shop_Management_System
{
    public partial class BhaiBhaiCoffeeShop : Form
    {
        DatabaseProject.DBAccess dBAccess = new DatabaseProject.DBAccess();

        public BhaiBhaiCoffeeShop()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void BhaiBhaiCoffeeShop_Load(object sender, EventArgs e)
        {
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Credit Card");

            lbDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            textLatte.Text = "0";
            textCappuccino.Text = "0";
            textEspresso.Text = "0";
            textMochaccino.Text = "0";
            textFilterCoffee.Text = "0";
            textIrishCoffee.Text = "0";
            textFlatWhite.Text = "0";
            textAffogato.Text = "0";
            textLongBlack.Text = "0";
            textCaffeMocha.Text = "0";
           

            textLatte.Enabled = false;
            textCappuccino.Enabled = false;
            textEspresso.Enabled = false;
            textMochaccino.Enabled = false;
            textFilterCoffee.Enabled = false;
            textIrishCoffee.Enabled = false;
            textFlatWhite.Enabled = false;
            textAffogato.Enabled = false;
            textLongBlack.Enabled = false;
            textCaffeMocha.Enabled = false;


            chLatte.Checked = false;
            chCappuccino.Checked = false;
            chEspresso.Checked = false;
            chMochaccino.Checked = false;
            chFilterCoffee.Checked = false;
            chIrishCoffee.Checked = false;
            chFlatWhite.Checked = false;
            chAffogato.Checked = false;
            chLongBlack.Checked = false;
            chCaffeMocha.Checked = false;


        }

        private void chLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chLatte.Checked == true)
            {
                textLatte.Enabled = true;
            }
            else
            {
                textLatte.Enabled = false;
                textLatte.Text = "0";
            }
        }

        private void chCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chCappuccino.Checked == true)
            {
                textCappuccino.Enabled = true;
            }
            else
            {
                textCappuccino.Enabled = false;
                textCappuccino.Text = "0";
            }
        }

        private void chEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chEspresso.Checked == true)
            {
                textEspresso.Enabled = true;
            }
            else
            {
                textEspresso.Enabled = false;
                textEspresso.Text = "0";
            }
        }

        private void chMochaccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chMochaccino.Checked == true)
            {
                textMochaccino.Enabled = true;
            }
            else
            {
                textMochaccino.Enabled = false;
                textMochaccino.Text = "0";
            }
        }

        private void chFilterCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chFilterCoffee.Checked == true)
            {
                textFilterCoffee.Enabled = true;
            }
            else
            {
                textFilterCoffee.Enabled = false;
                textFilterCoffee.Text = "0";
            }
        }

        private void chIrishCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chIrishCoffee.Checked == true)
            {
                textIrishCoffee.Enabled = true;
            }
            else
            {
                textIrishCoffee.Enabled = false;
                textIrishCoffee.Text = "0";
            }
        }

        private void chFlatWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chFlatWhite.Checked == true)
            {
                textFlatWhite.Enabled = true;
            }
            else
            {
                textFlatWhite.Enabled = false;
                textFlatWhite.Text = "0";
            }
        }

        private void chAffogato_CheckedChanged(object sender, EventArgs e)
        {
            if (chAffogato.Checked == true)
            {
                textAffogato.Enabled = true;
            }
            else
            {
                textAffogato.Enabled = false;
                textAffogato.Text = "0";
            }
        }

        private void chLongBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chLongBlack.Checked == true)
            {
                textLongBlack.Enabled = true;
            }
            else
            {
                textLongBlack.Enabled = false;
                textLongBlack.Text = "0";
            }
        }

        private void chCaffeMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chCaffeMocha.Checked == true)
            {
                textCaffeMocha.Enabled = true;
            }
            else
            {
                textCaffeMocha.Enabled = false;
                textCaffeMocha.Text = "0";
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (chLatte.Checked == true)
            {
                e.Graphics.DrawString(chLatte.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 120);
                e.Graphics.DrawString(textLatte.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 120);
            }
            if (chCappuccino.Checked == true)
            {
                e.Graphics.DrawString(chCappuccino.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 170);
                e.Graphics.DrawString(textCappuccino.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 170);
            }
            if (chEspresso.Checked == true)
            {
                e.Graphics.DrawString(chEspresso.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 210);
                e.Graphics.DrawString(textEspresso.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 210);
            }
            if (chMochaccino.Checked == true)
            {
                e.Graphics.DrawString(chMochaccino.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 260);
                e.Graphics.DrawString(textMochaccino.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 260);
            }
            if (chFilterCoffee.Checked == true)
            {
                e.Graphics.DrawString(chFilterCoffee.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 310);
                e.Graphics.DrawString(textFilterCoffee.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 310);
            }
            if (chIrishCoffee.Checked == true)
            {
                e.Graphics.DrawString(chIrishCoffee.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 360);
                e.Graphics.DrawString(textIrishCoffee.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 360);
            }
            if (chFlatWhite.Checked == true)
            {
                e.Graphics.DrawString(chFlatWhite.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 410);
                e.Graphics.DrawString(textFlatWhite.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 410);
            }
            if (chAffogato.Checked == true)
            {
                e.Graphics.DrawString(chAffogato.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 460);
                e.Graphics.DrawString(textAffogato.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 460);
            }
            if (chLongBlack.Checked == true)
            {
                e.Graphics.DrawString(chLongBlack.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 510);
                e.Graphics.DrawString(textLongBlack.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 510);
            }
            if (chCaffeMocha.Checked == true)
            {
                e.Graphics.DrawString(chCaffeMocha.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 120, 560);
                e.Graphics.DrawString(textCaffeMocha.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 250, 560);
            }
            e.Graphics.DrawString(coffee.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 330, 60);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are You Sure Want to Exit Buddy?", "Bhai Bhai Coffee Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Have a Nice Day Buddy");
                //Application.Exit();
                this.Hide();
                WelcomePage w = new WelcomePage();
                w.ShowDialog();
            }
        }

        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void ResetCheckBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBox();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            void Latte()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if (t0.Rows[0]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[0]["Price"].ToString();
                    int i = Convert.ToInt32(textLatte.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textLatte.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textLatte.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textLatte.Text) * k;
                    txtTotals.Text = g.ToString();
                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another Buddy :D");
                }
            }



            void Cappuccino()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[1]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[1]["Price"].ToString();
                    int i = Convert.ToInt32(textCappuccino.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textCappuccino.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textCappuccino.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textCappuccino.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffe is not available yet.\nYou can try another one Buddy :D");
                }
            }

            void Espresso()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if (t0.Rows[2]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[2]["Price"].ToString();
                    int i = Convert.ToInt32(textEspresso.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textEspresso.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textEspresso.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textEspresso.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another Buddy :D");
                }
            }


            void Mochaccino()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[3]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[3]["Price"].ToString();
                    int i = Convert.ToInt32(textMochaccino.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textMochaccino.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textMochaccino.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text=l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textMochaccino.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }

            void FilterCoffee()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[4]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[4]["Price"].ToString();
                    int i = Convert.ToInt32(textFilterCoffee.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textFilterCoffee.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textFilterCoffee.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textFilterCoffee.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }


            void IrishCoffee()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[5]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[5]["Price"].ToString();
                    int i = Convert.ToInt32(textIrishCoffee.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textIrishCoffee.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textIrishCoffee.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textIrishCoffee.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }


            void FlatWhite()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[6]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[6]["Price"].ToString();
                    int i = Convert.ToInt32(textFlatWhite.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textFlatWhite.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textFlatWhite.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textFlatWhite.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }

            void Affogato()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[7]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[7]["Price"].ToString();
                    int i = Convert.ToInt32(textAffogato.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textAffogato.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textAffogato.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textAffogato.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }


            void LongBlack()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[8]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[8]["Price"].ToString();
                    int i = Convert.ToInt32(textLongBlack.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textLongBlack.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textLongBlack.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textLongBlack.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }


            void CaffeMocha()
            {
                String q = "Select Status From CoffeeList";
                DataTable t0 = new DataTable();
                dBAccess.readDatathroughAdapter(q, t0);
                if(t0.Rows[9]["Status"].ToString()=="Yes")
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[9]["Price"].ToString();
                    int i = Convert.ToInt32(textCaffeMocha.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(textCaffeMocha.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    textServiceCharge.Text = "1";
                    int m = Convert.ToInt32(textServiceCharge.Text);
                    int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textCaffeMocha.Text);
                    txtSubTotal.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    textServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(textCaffeMocha.Text) * k;
                    txtTotals.Text = g.ToString();

                    if (cmbPayment.Text == "Cash")
                    {
                        txtPayShow.Enabled = true;
                        int chng = (Convert.ToInt32(txtPayShow.Text)) - (Convert.ToInt32(txtTotals.Text));
                        txtChange.Text = chng.ToString();
                        if (Convert.ToInt32(txtPayShow.Text) < Convert.ToInt32(txtTotals.Text))
                        {
                            MessageBox.Show("Your Payment Number is Lower than Total Price Buddy");
                        }
                    }
                    else
                    {
                        txtPayShow.Enabled = false;
                        txtPayShow.Text = "0";
                        txtChange.Enabled = false;
                        txtChange.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, This Coffee is not available yet.\nYou can try another one Buddy :D");
                }
            }


            if (chLatte.Checked == true)
            {
                Latte();
            }
            if (chCappuccino.Checked == true)
            {
                Cappuccino();

            }
            if(chEspresso.Checked==true)
            {
                Espresso();
            }

            if(chMochaccino.Checked==true)
            {
                Mochaccino();
            }
            if (chFilterCoffee.Checked == true)
            {
                FilterCoffee();
            }
            if (chIrishCoffee.Checked == true)
            {
                IrishCoffee();
            }
            if (chFlatWhite.Checked == true)
            {
                FlatWhite();
            }
            if (chAffogato.Checked == true)
            {
                Affogato();
            }
            if (chLongBlack.Checked == true)
            {
                LongBlack();
            }
            if (chCaffeMocha.Checked == true)
            {
                CaffeMocha();
            }

            if(chLatte.Checked==true && chCappuccino.Checked==true || chLatte.Checked==true && chEspresso.Checked==true || chLatte.Checked==true && chMochaccino.Checked==true || chLatte.Checked==true && chFilterCoffee.Checked==true || chLatte.Checked==true && chIrishCoffee.Checked==true || chLatte.Checked==true && chFlatWhite.Checked==true || chLatte.Checked==true && chAffogato.Checked==true || chLatte.Checked==true && chLongBlack.Checked==true || chLatte.Checked==true && chCaffeMocha.Checked==true || chCappuccino.Checked==true && chEspresso.Checked==true || chCappuccino.Checked==true && chMochaccino.Checked==true || chCappuccino.Checked==true && chFilterCoffee.Checked==true || chCappuccino.Checked==true && chIrishCoffee.Checked==true || chCappuccino.Checked==true && chFlatWhite.Checked==true || chCappuccino.Checked==true && chAffogato.Checked==true || chCappuccino.Checked==true && chLongBlack.Checked==true || chCappuccino.Checked==true && chCaffeMocha.Checked==true || chEspresso.Checked==true && chMochaccino.Checked==true || chEspresso.Checked==true && chFilterCoffee.Checked==true || chEspresso.Checked==true && chIrishCoffee.Checked==true || chEspresso.Checked==true && chFlatWhite.Checked==true || chEspresso.Checked==true && chAffogato.Checked==true || chEspresso.Checked==true && chLongBlack.Checked==true || chEspresso.Checked==true && chCaffeMocha.Checked==true || chMochaccino.Checked==true && chFilterCoffee.Checked==true || chMochaccino.Checked==true && chIrishCoffee.Checked==true || chMochaccino.Checked==true && chFlatWhite.Checked==true || chMochaccino.Checked==true && chAffogato.Checked==true || chMochaccino.Checked==true && chLongBlack.Checked==true || chMochaccino.Checked==true && chCaffeMocha.Checked==true || chFilterCoffee.Checked==true && chIrishCoffee.Checked==true || chFilterCoffee.Checked==true && chFlatWhite.Checked==true || chFilterCoffee.Checked==true && chAffogato.Checked==true || chFilterCoffee.Checked==true && chLongBlack.Checked==true || chFilterCoffee.Checked==true && chCaffeMocha.Checked==true || chIrishCoffee.Checked==true && chFlatWhite.Checked==true || chIrishCoffee.Checked==true && chAffogato.Checked==true || chIrishCoffee.Checked==true && chLongBlack.Checked==true || chIrishCoffee.Checked==true && chCaffeMocha.Checked==true || chFlatWhite.Checked==true && chAffogato.Checked==true || chFlatWhite.Checked==true && chLongBlack.Checked==true || chFlatWhite.Checked==true && chCaffeMocha.Checked==true || chAffogato.Checked==true && chLongBlack.Checked==true || chAffogato.Checked==true && chCaffeMocha.Checked==true || chLongBlack.Checked==true && chCaffeMocha.Checked==true)
            {
                MessageBox.Show("Sorry Buddy You Can Only See Price of Per Coffee.\nSeeing More Than One Coffee Prices are not allowed.\nAgain Sorry Buddy :'( ");
            }

            
        }

        private void btn_PriceCoffee_Click(object sender, EventArgs e)
        {
            
            void PriceLatte()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[0]["Price"].ToString();
                int i = Convert.ToInt32(textLatte.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textLatte.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textLatte.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textLatte.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if(chLatte.Checked==true)
            {
                PriceLatte();
            }
            void PriceCappuccino()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[1]["Price"].ToString();
                int i = Convert.ToInt32(textCappuccino.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textCappuccino.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textCappuccino.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textCappuccino.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chCappuccino.Checked == true)
            {
                PriceCappuccino();
            }

            void priceEspresso()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[2]["Price"].ToString();
                int i = Convert.ToInt32(textEspresso.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textEspresso.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textEspresso.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textEspresso.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if(chEspresso.Checked==true)
            {
                priceEspresso();
            }

            void priceMochaccino()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[3]["Price"].ToString();
                int i = Convert.ToInt32(textMochaccino.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textMochaccino.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textMochaccino.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textMochaccino.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chMochaccino.Checked == true)
            {
                priceMochaccino();
            }

            void priceFilterCoffee()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[4]["Price"].ToString();
                int i = Convert.ToInt32(textFilterCoffee.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textFilterCoffee.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textFilterCoffee.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textFilterCoffee.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chFilterCoffee.Checked == true)
            {
                priceFilterCoffee();
            }

            void priceIrishCoffee()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[5]["Price"].ToString();
                int i = Convert.ToInt32(textIrishCoffee.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textIrishCoffee.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textIrishCoffee.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textIrishCoffee.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chIrishCoffee.Checked == true)
            {
                priceIrishCoffee();
            }

            void priceFlatWhite()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[6]["Price"].ToString();
                int i = Convert.ToInt32(textFlatWhite.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textFlatWhite.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textFlatWhite.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textFlatWhite.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chFlatWhite.Checked == true)
            {
                priceFlatWhite();
            }

            void priceAffogato()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[7]["Price"].ToString();
                int i = Convert.ToInt32(textAffogato.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textAffogato.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textAffogato.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textAffogato.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chAffogato.Checked == true)
            {
                priceAffogato();
            }

            void priceLongBlack()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[8]["Price"].ToString();
                int i = Convert.ToInt32(textLongBlack.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textLongBlack.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textLongBlack.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textLongBlack.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chLongBlack.Checked == true)
            {
                priceLongBlack();
            }

            void priceCaffeMocha()
            {
                String query = "Select Price From CoffeeList";
                String query2 = "Select Vat From OtherData";
                DataTable t = new DataTable();
                DataTable t2 = new DataTable();
                dBAccess.readDatathroughAdapter(query, t);
                dBAccess.readDatathroughAdapter(query2, t2);
                String a = t.Rows[9]["Price"].ToString();
                int i = Convert.ToInt32(textCaffeMocha.Text) * Convert.ToInt32(a);
                int c = Convert.ToInt32(a);
                String b = t2.Rows[0]["Vat"].ToString();
                int j = Convert.ToInt32(textCaffeMocha.Text) * Convert.ToInt32(b);
                int d = Convert.ToInt32(b);
                textServiceCharge.Text = "1";
                int m = Convert.ToInt32(textServiceCharge.Text);
                int l = Convert.ToInt32(textServiceCharge.Text) * Convert.ToInt32(textCaffeMocha.Text);
                txtSubTotal.Text = i.ToString();
                txtTax.Text = j.ToString();
                textServiceCharge.Text = l.ToString();
                int k = (c + d + m);
                int g = Convert.ToInt32(textCaffeMocha.Text) * k;
                txtTotals.Text = g.ToString();
            }
            if (chCaffeMocha.Checked == true)
            {
                priceCaffeMocha();
            }

            if (chLatte.Checked == true && chCappuccino.Checked == true || chLatte.Checked == true && chEspresso.Checked == true || chLatte.Checked == true && chMochaccino.Checked == true || chLatte.Checked == true && chFilterCoffee.Checked == true || chLatte.Checked == true && chIrishCoffee.Checked == true || chLatte.Checked == true && chFlatWhite.Checked == true || chLatte.Checked == true && chAffogato.Checked == true || chLatte.Checked == true && chLongBlack.Checked == true || chLatte.Checked == true && chCaffeMocha.Checked == true || chCappuccino.Checked == true && chEspresso.Checked == true || chCappuccino.Checked == true && chMochaccino.Checked == true || chCappuccino.Checked == true && chFilterCoffee.Checked == true || chCappuccino.Checked == true && chIrishCoffee.Checked == true || chCappuccino.Checked == true && chFlatWhite.Checked == true || chCappuccino.Checked == true && chAffogato.Checked == true || chCappuccino.Checked == true && chLongBlack.Checked == true || chCappuccino.Checked == true && chCaffeMocha.Checked == true || chEspresso.Checked == true && chMochaccino.Checked == true || chEspresso.Checked == true && chFilterCoffee.Checked == true || chEspresso.Checked == true && chIrishCoffee.Checked == true || chEspresso.Checked == true && chFlatWhite.Checked == true || chEspresso.Checked == true && chAffogato.Checked == true || chEspresso.Checked == true && chLongBlack.Checked == true || chEspresso.Checked == true && chCaffeMocha.Checked == true || chMochaccino.Checked == true && chFilterCoffee.Checked == true || chMochaccino.Checked == true && chIrishCoffee.Checked == true || chMochaccino.Checked == true && chFlatWhite.Checked == true || chMochaccino.Checked == true && chAffogato.Checked == true || chMochaccino.Checked == true && chLongBlack.Checked == true || chMochaccino.Checked == true && chCaffeMocha.Checked == true || chFilterCoffee.Checked == true && chIrishCoffee.Checked == true || chFilterCoffee.Checked == true && chFlatWhite.Checked == true || chFilterCoffee.Checked == true && chAffogato.Checked == true || chFilterCoffee.Checked == true && chLongBlack.Checked == true || chFilterCoffee.Checked == true && chCaffeMocha.Checked == true || chIrishCoffee.Checked == true && chFlatWhite.Checked == true || chIrishCoffee.Checked == true && chAffogato.Checked == true || chIrishCoffee.Checked == true && chLongBlack.Checked == true || chIrishCoffee.Checked == true && chCaffeMocha.Checked == true || chFlatWhite.Checked == true && chAffogato.Checked == true || chFlatWhite.Checked == true && chLongBlack.Checked == true || chFlatWhite.Checked == true && chCaffeMocha.Checked == true || chAffogato.Checked == true && chLongBlack.Checked == true || chAffogato.Checked == true && chCaffeMocha.Checked == true || chLongBlack.Checked == true && chCaffeMocha.Checked == true)
            {
                MessageBox.Show("Sorry Buddy You Can Only See Price of Per Coffee.\nSeeing More Than One Coffee Prices are not allowed.\nAgain Sorry Buddy :'( ");
            }
        }
    }
}
