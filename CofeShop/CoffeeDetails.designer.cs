namespace Coffee_Shop_Management_System
{
    partial class CoffeeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnup = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(169, 156);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Coffee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Token No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(169, 129);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(116, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(169, 102);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(116, 20);
            this.txtCoffeeName.TabIndex = 8;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(169, 75);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(116, 20);
            this.txtToken.TabIndex = 9;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Location = new System.Drawing.Point(48, 245);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(99, 33);
            this.btnup.TabIndex = 20;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndlt
            // 
            this.btndlt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlt.ForeColor = System.Drawing.Color.White;
            this.btndlt.Location = new System.Drawing.Point(183, 245);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(102, 33);
            this.btndlt.TabIndex = 20;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = false;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.Location = new System.Drawing.Point(48, 296);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(84, 28);
            this.ShowBtn.TabIndex = 21;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Black;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(182, 292);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(102, 32);
            this.BtnExit.TabIndex = 22;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(368, 19);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(472, 341);
            this.dataGrid.TabIndex = 23;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(169, 186);
            this.dateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(116, 20);
            this.dateTime.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Coffee Details";
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.Location = new System.Drawing.Point(-1, -2);
            this.btnUpdatePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(140, 19);
            this.btnUpdatePass.TabIndex = 26;
            this.btnUpdatePass.Text = "Update Password";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(48, 341);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CoffeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(861, 384);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCoffeeName);
            this.Controls.Add(this.txtToken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CoffeeDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndlt;
       // private TestDataDataSet1 testDataDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
       // private TestDataDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBuyingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Button btnReset;
    }
}

