using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Coffee_Shop_Management_System
{
    public partial class CoffeeDetails : Form
    {
        DatabaseProject.DBAccess dbAccess = new DatabaseProject.DBAccess();
        //DataTable dt = new DataTable();
        public CoffeeDetails()
        {
            InitializeComponent();
        }

        private void CoffeeDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            
        }
        public void display()
        {
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CoffeeBuy";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/
        }

      /* private void CoffeeDetails_Load1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.testDataDataSet1.Table);

        }*/

       private void btnup_Click(object sender, EventArgs e)
        {
            string Token = txtToken.Text;
            string Coffee = txtCoffeeName.Text;
            string Quantity = txtQuantity.Text;
            string Price = txtPrice.Text;
            string Date = dateTime.Text;
            if(Token.Equals(""))
            {
                MessageBox.Show("Please Write Token No.");
            }
           else if (Coffee.Equals(""))
            {
                MessageBox.Show("Please Write Coffee Name");
            }
           else if (Quantity.Equals(""))
            {
                MessageBox.Show("Please Write Coffee Quantity");
            }
           else if (Price.Equals(""))
            {
                MessageBox.Show("Please Write Coffee Price");
            }
           else if (Date.Equals(""))
            {
                MessageBox.Show("Please Write Date and Time");
            }

            else
            {
                string query = "Update CoffeeBuy SET CoffeeName='" + @Coffee + "', Quantity='" + @Quantity + "', Price='" + @Price + "', DateofBuying='" + @Date + "' Where TokenNo='" +@Token + "'";
                SqlCommand UpdateQuery = new SqlCommand(query);
                UpdateQuery.Parameters.AddWithValue("@Token", Token);
                UpdateQuery.Parameters.AddWithValue("@Coffee", Coffee);
                UpdateQuery.Parameters.AddWithValue("@Quantity", Quantity);
                UpdateQuery.Parameters.AddWithValue("@Price", Price);
                UpdateQuery.Parameters.AddWithValue("@Date", Date);
                int row = dbAccess.executeQuery(UpdateQuery);
                if(row==1)
                {
                    MessageBox.Show("Updated Successfully!");
                }
            }

        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            String Token = txtToken.Text;
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog==DialogResult.Yes)
            {
                string query = "Delete from CoffeeBuy Where TokenNo='" + Token + "'";
                SqlCommand DeleteQuery = new SqlCommand(query);
                int row = dbAccess.executeQuery(DeleteQuery);
                if(row==1)
                {
                    MessageBox.Show("Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error Found! Please Try Again.");
                }
            }
        }

        private void ShowBtn_Click_1(object sender, EventArgs e)
        {
            string query = "Select * from CoffeeBuy";

            DataTable dt = new DataTable();
            dbAccess.readDatathroughAdapter(query, dt);
            dataGrid.DataSource = dt;
            dbAccess.closeConn();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CoffeeDetails_Load_1(object sender, EventArgs e)
        {

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

        private void ResetDataGrid()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is DataGridView)
                        (control as DataGridView).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetDataGrid();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            CofeShop.UpdatePasswordForm up = new CofeShop.UpdatePasswordForm();
            this.Hide();
            up.Show();
        }
    }
}
