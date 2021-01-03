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
    public partial class CafeBilling : Form
    {
        DatabaseProject.DBAccess dBAccess = new DatabaseProject.DBAccess();
        public CafeBilling()
        {
            InitializeComponent();
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

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBox();

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CafeBilling_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();


          //  txtDateBuy.Text ="" ;

            txtLatte.Text = "0";
            txtCappuccino.Text = "0";
            txtEspresso.Text = "0";
            txtMochaccino.Text = "0";
            txtFilter.Text = "0";
            txtIrish.Text = "0";
            txtFlat.Text = "0";
            txtAffogato.Text = "0";
            txtLong.Text = "0";
            txtCaffe.Text = "0";
            

            txtLatte.Enabled = false;
            txtCappuccino.Enabled = false;
            txtEspresso.Enabled = false;
            txtMochaccino.Enabled = false;
            txtFilter.Enabled = false;
            txtIrish.Enabled = false;
            txtFlat.Enabled = false;
            txtAffogato.Enabled = false;
            txtLong.Enabled = false;
            txtCaffe.Enabled = false;

            ChkLatte.Checked = false;
            ChkCappuccino.Checked = false;
            ChkEspresso.Checked = false;
            ChkMochaccino.Checked = false;
            ChkFilterCoffee.Checked = false;
            ChkIrishCoffee.Checked = false;
            ChkFlatWhite.Checked = false;
            ChkAffogato.Checked = false;
            ChkLongBlack.Checked = false;
            ChkCaffeMocha.Checked = false;
        }

        private void ChkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkLatte.Checked==true)
            {
                txtLatte.Enabled = true;
            }
            if(ChkLatte.Checked==false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void ChkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkCappuccino.Checked==true)
            {
                txtCappuccino.Enabled = true;
            }
            if(ChkCappuccino.Checked==false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void ChkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkEspresso.Checked==true)
            {
                txtEspresso.Enabled = true;
            }
            if(ChkEspresso.Checked==false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";

            }
        }

        private void ChkMochaccino_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkMochaccino.Checked==true)
            {
                txtMochaccino.Enabled = true;
            }
            if(ChkMochaccino.Checked==false)
            {
                txtMochaccino.Enabled = false;
                txtMochaccino.Text = "0";
            }
        }

        private void ChkFilterCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkFilterCoffee.Checked==true)
            {
                txtFilter.Enabled = true;
            }
            if(ChkFilterCoffee.Checked==false)
            {
                txtFilter.Enabled = false;
                txtFilter.Text = "0";
            }
        }

        private void ChkIrishCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkIrishCoffee.Checked==true)
            {
                txtIrish.Enabled = true;
            }
            if(ChkIrishCoffee.Checked==false)
            {
                txtIrish.Enabled = false;
                txtIrish.Text = "0";
            }
        }

        private void ChkFlatWhite_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkFlatWhite.Checked==true)
            {
                txtFlat.Enabled = true;
            }
            if(ChkFlatWhite.Checked==false)
            {
                txtFlat.Enabled = false;
                txtFlat.Text = "0";
            }
        }

        private void ChkAffogato_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkAffogato.Checked==true)
            {
                txtAffogato.Enabled = true;
            }
            if(ChkAffogato.Checked==false)
            {
                txtAffogato.Enabled = false;
                txtAffogato.Text = "0";
            }
        }

        private void ChkLongBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkLongBlack.Checked==true)
            {
                txtLong.Enabled = true;
            }
            if(ChkLongBlack.Checked==false)
            {
                txtLong.Enabled = false;
                txtLong.Text = "0";
            }
        }

        private void ChkCaffeMocha_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkCaffeMocha.Checked==true)
            {
                txtCaffe.Enabled = true;
            }
            if(ChkCaffeMocha.Checked==false)
            {
                txtCaffe.Enabled = false;
                txtCaffe.Text = "0";
            }
        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();

        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void txtMochaccino_Click(object sender, EventArgs e)
        {
            txtMochaccino.Text = "";
            txtMochaccino.Focus();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void txtIrish_Click(object sender, EventArgs e)
        {
            txtIrish.Text = "";
            txtIrish.Focus();
        }

        private void txtFlat_Click(object sender, EventArgs e)
        {
            txtFlat.Text = "";
            txtFlat.Focus();
        }

        private void txtAffogato_Click(object sender, EventArgs e)
        {
            txtAffogato.Text = "";
            txtAffogato.Focus();
        }

        private void txtLong_Click(object sender, EventArgs e)
        {
            txtLong.Text = "";
            txtLong.Focus();
        }

        private void txtCaffe_Click(object sender, EventArgs e)
        {
            txtCaffe.Text = "";
            txtCaffe.Focus();
        }

        private void ButtonReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t" + "BHAI BHAI COFFEE Shop" + Environment.NewLine);
            rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Mochaccino \t\t" + txtMochaccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Filter Coffee \t\t" + txtFilter.Text + Environment.NewLine);
            rtfReceipt.AppendText("Irish Coffe \t\t" + txtIrish.Text + Environment.NewLine);
            rtfReceipt.AppendText("Flat White \t\t" + txtFlat.Text + Environment.NewLine);
            rtfReceipt.AppendText("Affogato \t\t" + txtAffogato.Text + Environment.NewLine);
            rtfReceipt.AppendText("Long Black \t\t" + txtLong.Text + Environment.NewLine);
            rtfReceipt.AppendText("Caffe Mocha \t\t" + txtCaffe.Text + Environment.NewLine);
            rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t\t"+txtServiceCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t" + txtTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t" + txtSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t" + txtTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t\t" + lblDate.Text);

            string CoffeeToken = txtToken.Text;
            string DateOfBuy = txtDateBuy.Text;
            string Cf1 = ChkLatte.Text;
            string Cf2 = ChkCappuccino.Text;
            string Cf3 = ChkEspresso.Text;
            string Cf4 = ChkMochaccino.Text;
            string Cf5 = ChkFilterCoffee.Text;
            string Cf6 = ChkIrishCoffee.Text;
            string Cf7 = ChkFlatWhite.Text;
            string Cf8 = ChkAffogato.Text;
            string Cf9 = ChkLongBlack.Text;
            string Cf10 = ChkCaffeMocha.Text;
            string Cq1 = txtLatte.Text;
            string Cq2 = txtCappuccino.Text;
            string Cq3 = txtEspresso.Text;
            string Cq4 = txtMochaccino.Text;
            string Cq5 = txtFilter.Text;
            string Cq6 = txtIrish.Text;
            string Cq7 = txtFlat.Text;
            string Cq8 = txtAffogato.Text;
            string Cq9 = txtLong.Text;
            string Cq10 = txtCaffe.Text;
            string Cp1 = PrLatte.Text;
            string Cp2 = PrCappuccino.Text;
            string Cp3 = PrEspresso.Text;
            string Cp4 = PrMochaccino.Text;
            string Cp5 = PrFilterCoffee.Text;
            string Cp6 = PrIrishCoffee.Text;
            string Cp7 = PrFlatWhite.Text;
            string Cp8 = PrAffogato.Text;
            string Cp9 = PrLongBlack.Text;
            string Cp10 = PrCaffeMocha.Text;

            if(ChkLatte.Checked==true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf1, @Cq1, @Cp1, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf1", Cf1);
                InsertComm.Parameters.AddWithValue("@Cq1", Cq1);
                InsertComm.Parameters.AddWithValue("@Cp1", Cp1);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if(row==1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkCappuccino.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf2, @Cq2, @Cp2, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf2", Cf2);
                InsertComm.Parameters.AddWithValue("@Cq2", Cq2);
                InsertComm.Parameters.AddWithValue("@Cp2", Cp2);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkEspresso.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf3, @Cq3, @Cp3, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf3", Cf3);
                InsertComm.Parameters.AddWithValue("@Cq3", Cq3);
                InsertComm.Parameters.AddWithValue("@Cp3", Cp3);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkMochaccino.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf4, @Cq4, @Cp4, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf4", Cf4);
                InsertComm.Parameters.AddWithValue("@Cq4", Cq4);
                InsertComm.Parameters.AddWithValue("@Cp4", Cp4);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkFilterCoffee.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf5, @Cq5, @Cp5, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf5", Cf5);
                InsertComm.Parameters.AddWithValue("@Cq5", Cq5);
                InsertComm.Parameters.AddWithValue("@Cp5", Cp5);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkIrishCoffee.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf6, @Cq6, @Cp6, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf6", Cf6);
                InsertComm.Parameters.AddWithValue("@Cq6", Cq6);
                InsertComm.Parameters.AddWithValue("@Cp6", Cp6);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkFlatWhite.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf7, @Cq7, @Cp7, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf7", Cf7);
                InsertComm.Parameters.AddWithValue("@Cq7", Cq7);
                InsertComm.Parameters.AddWithValue("@Cp7", Cp7);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkAffogato.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf8, @Cq8, @Cp8, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf8", Cf8);
                InsertComm.Parameters.AddWithValue("@Cq8", Cq8);
                InsertComm.Parameters.AddWithValue("@Cp8", Cp8);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkLongBlack.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf9, @Cq9, @Cp9, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf9", Cf9);
                InsertComm.Parameters.AddWithValue("@Cq9", Cq9);
                InsertComm.Parameters.AddWithValue("@Cp9", Cp9);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }

            if (ChkCaffeMocha.Checked == true)
            {
                SqlCommand InsertComm = new SqlCommand("insert into CoffeeBuy(TokenNo, CoffeeName, Quantity, Price, DateofBuying) values(@CoffeeToken, @Cf10, @Cq10, @Cp10, @DateOfBuy)");
                InsertComm.Parameters.AddWithValue("@CoffeeToken", CoffeeToken);
                InsertComm.Parameters.AddWithValue("@Cf10", Cf10);
                InsertComm.Parameters.AddWithValue("@Cq10", Cq10);
                InsertComm.Parameters.AddWithValue("@Cp10", Cp10);
                InsertComm.Parameters.AddWithValue("@DateOfBuy", DateOfBuy);
                int row = dBAccess.executeQuery(InsertComm);
                if (row == 1)
                {
                    MessageBox.Show("Informations are Successfully Inserted!");
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //rtfReceipt.Loadfile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void PrFlatWhite_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTotal_Click(object sender, EventArgs e)
        {
            

                void Latte()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[0]["Price"].ToString();
                    int i = Convert.ToInt32(txtLatte.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtLatte.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtLatte.Text);
                    txtSubTotal.Text = i.ToString();
                    PrLatte.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtLatte.Text) * k;
                    txtTotal.Text = g.ToString();

                }



                void Cappuccino()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[1]["Price"].ToString();
                    int i = Convert.ToInt32(txtCappuccino.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtCappuccino.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtCappuccino.Text);
                    txtSubTotal.Text = i.ToString();
                    PrCappuccino.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtCappuccino.Text) * k;
                    txtTotal.Text = g.ToString();

                }

                void Espresso()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[2]["Price"].ToString();
                    int i = Convert.ToInt32(txtEspresso.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtEspresso.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtEspresso.Text);
                    txtSubTotal.Text = i.ToString();
                    PrEspresso.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtEspresso.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                void Mochaccino()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[3]["Price"].ToString();
                    int i = Convert.ToInt32(txtMochaccino.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtMochaccino.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtMochaccino.Text);
                    txtSubTotal.Text = i.ToString();
                    PrMochaccino.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtMochaccino.Text) * k;
                    txtTotal.Text = g.ToString();

                }

                void FilterCoffee()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[4]["Price"].ToString();
                    int i = Convert.ToInt32(txtFilter.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtFilter.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtFilter.Text);
                    txtSubTotal.Text = i.ToString();
                    PrFilterCoffee.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtFilter.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                void IrishCoffee()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[5]["Price"].ToString();
                    int i = Convert.ToInt32(txtIrish.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtIrish.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtIrish.Text);
                    txtSubTotal.Text = i.ToString();
                    PrIrishCoffee.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtIrish.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                void FlatWhite()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[6]["Price"].ToString();
                    int i = Convert.ToInt32(txtFlat.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtFlat.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtFlat.Text);
                    txtSubTotal.Text = i.ToString();
                    PrFlatWhite.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtFlat.Text) * k;
                    txtTotal.Text = g.ToString();

                }

                void Affogato()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[7]["Price"].ToString();
                    int i = Convert.ToInt32(txtAffogato.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtAffogato.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtAffogato.Text);
                    txtSubTotal.Text = i.ToString();
                    PrAffogato.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtAffogato.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                void LongBlack()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[8]["Price"].ToString();
                    int i = Convert.ToInt32(txtLong.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtLong.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtLong.Text);
                    txtSubTotal.Text = i.ToString();
                    PrLongBlack.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtLong.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                void CaffeMocha()
                {
                    String query = "Select Price From CoffeeList";
                    String query2 = "Select Vat From OtherData";
                    DataTable t = new DataTable();
                    DataTable t2 = new DataTable();
                    dBAccess.readDatathroughAdapter(query, t);
                    dBAccess.readDatathroughAdapter(query2, t2);
                    String a = t.Rows[9]["Price"].ToString();
                    int i = Convert.ToInt32(txtCaffe.Text) * Convert.ToInt32(a);
                    int c = Convert.ToInt32(a);
                    String b = t2.Rows[0]["Vat"].ToString();
                    int j = Convert.ToInt32(txtCaffe.Text) * Convert.ToInt32(b);
                    int d = Convert.ToInt32(b);
                    txtServiceCharge.Text = "1";
                    int m = Convert.ToInt32(txtServiceCharge.Text);
                    int l = Convert.ToInt32(txtServiceCharge.Text) * Convert.ToInt32(txtCaffe.Text);
                    txtSubTotal.Text = i.ToString();
                    PrCaffeMocha.Text = i.ToString();
                    txtTax.Text = j.ToString();
                    txtServiceCharge.Text = l.ToString();
                    int k = (c + d + m);
                    int g = Convert.ToInt32(txtCaffe.Text) * k;
                    txtTotal.Text = g.ToString();

                }


                if (ChkLatte.Checked == true)
                {
                    Latte();
                }
                if (ChkCappuccino.Checked == true)
                {
                    Cappuccino();

                }
                if (ChkEspresso.Checked == true)
                {
                    Espresso();
                }

                if (ChkMochaccino.Checked == true)
                {
                    Mochaccino();
                }
                if (ChkFilterCoffee.Checked == true)
                {
                    FilterCoffee();
                }
                if (ChkIrishCoffee.Checked == true)
                {
                    IrishCoffee();
                }
                if (ChkFlatWhite.Checked == true)
                {
                    FlatWhite();
                }
                if (ChkAffogato.Checked == true)
                {
                    Affogato();
                }
                if (ChkLongBlack.Checked == true)
                {
                    LongBlack();
                }
                if (ChkCaffeMocha.Checked == true)
                {
                    CaffeMocha();
                }

                if (ChkLatte.Checked == true && ChkCappuccino.Checked == true || ChkLatte.Checked == true && ChkEspresso.Checked == true || ChkLatte.Checked == true && ChkMochaccino.Checked == true || ChkLatte.Checked == true && ChkFilterCoffee.Checked == true || ChkLatte.Checked == true && ChkIrishCoffee.Checked == true || ChkLatte.Checked == true && ChkFlatWhite.Checked == true || ChkLatte.Checked == true && ChkAffogato.Checked == true || ChkLatte.Checked == true && ChkLongBlack.Checked == true || ChkLatte.Checked == true && ChkCaffeMocha.Checked == true || ChkCappuccino.Checked == true && ChkEspresso.Checked == true || ChkCappuccino.Checked == true && ChkMochaccino.Checked == true || ChkCappuccino.Checked == true && ChkFilterCoffee.Checked == true || ChkCappuccino.Checked == true && ChkIrishCoffee.Checked == true || ChkCappuccino.Checked == true && ChkFlatWhite.Checked == true || ChkCappuccino.Checked == true && ChkAffogato.Checked == true || ChkCappuccino.Checked == true && ChkLongBlack.Checked == true || ChkCappuccino.Checked == true && ChkCaffeMocha.Checked == true || ChkEspresso.Checked == true && ChkMochaccino.Checked == true || ChkEspresso.Checked == true && ChkFilterCoffee.Checked == true || ChkEspresso.Checked == true && ChkIrishCoffee.Checked == true || ChkEspresso.Checked == true && ChkFlatWhite.Checked == true || ChkEspresso.Checked == true && ChkAffogato.Checked == true || ChkEspresso.Checked == true && ChkLongBlack.Checked == true || ChkEspresso.Checked == true && ChkCaffeMocha.Checked == true || ChkMochaccino.Checked == true && ChkFilterCoffee.Checked == true || ChkMochaccino.Checked == true && ChkIrishCoffee.Checked == true || ChkMochaccino.Checked == true && ChkFlatWhite.Checked == true || ChkMochaccino.Checked == true && ChkAffogato.Checked == true || ChkMochaccino.Checked == true && ChkLongBlack.Checked == true || ChkMochaccino.Checked == true && ChkCaffeMocha.Checked == true || ChkFilterCoffee.Checked == true && ChkIrishCoffee.Checked == true || ChkFilterCoffee.Checked == true && ChkFlatWhite.Checked == true || ChkFilterCoffee.Checked == true && ChkAffogato.Checked == true || ChkFilterCoffee.Checked == true && ChkLongBlack.Checked == true || ChkFilterCoffee.Checked == true && ChkCaffeMocha.Checked == true || ChkIrishCoffee.Checked == true && ChkFlatWhite.Checked == true || ChkIrishCoffee.Checked == true && ChkAffogato.Checked == true || ChkIrishCoffee.Checked == true && ChkLongBlack.Checked == true || ChkIrishCoffee.Checked == true && ChkCaffeMocha.Checked == true || ChkFlatWhite.Checked == true && ChkAffogato.Checked == true || ChkFlatWhite.Checked == true && ChkLongBlack.Checked == true || ChkFlatWhite.Checked == true && ChkCaffeMocha.Checked == true || ChkAffogato.Checked == true && ChkLongBlack.Checked == true || ChkAffogato.Checked == true && ChkCaffeMocha.Checked == true || ChkLongBlack.Checked == true && ChkCaffeMocha.Checked == true)
                {
                    MessageBox.Show("Sorry, Seeing More Than One Coffee Prices are not allowed.");
                }

            
        }

        private void lblService_Click(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePass_Click(object sender, EventArgs e)
        {
            CofeShop.UpdatePasswordForm up = new CofeShop.UpdatePasswordForm();
            this.Hide();
            up.Show();
        }
    }
}
