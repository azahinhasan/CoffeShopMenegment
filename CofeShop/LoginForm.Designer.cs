namespace CofeShop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ID_taxtbox = new System.Windows.Forms.TextBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_taxtbox
            // 
            this.ID_taxtbox.Location = new System.Drawing.Point(495, 212);
            this.ID_taxtbox.Name = "ID_taxtbox";
            this.ID_taxtbox.Size = new System.Drawing.Size(221, 20);
            this.ID_taxtbox.TabIndex = 0;
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Pass_textBox.Location = new System.Drawing.Point(495, 255);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(221, 20);
            this.Pass_textBox.TabIndex = 1;
            this.Pass_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pass_textBox__KeyPress);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ID_label.Location = new System.Drawing.Point(395, 212);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(27, 21);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "ID";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Pass_label.Location = new System.Drawing.Point(395, 255);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(82, 21);
            this.Pass_label.TabIndex = 3;
            this.Pass_label.Text = "Password";
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.Color.Silver;
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.ForeColor = System.Drawing.Color.Black;
            this.Reset_button.Location = new System.Drawing.Point(495, 348);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(105, 39);
            this.Reset_button.TabIndex = 28;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = false;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Login_button.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.Black;
            this.Login_button.Location = new System.Drawing.Point(615, 348);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(101, 39);
            this.Login_button.TabIndex = 27;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(574, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Forget Password?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 621);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(114, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(42, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bhai Bhai";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(722, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(489, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 34);
            this.label4.TabIndex = 67;
            this.label4.Text = "Please LogIn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(418, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 21);
            this.label5.TabIndex = 68;
            this.label5.Text = "**For Customer ID and Password are 0**";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.ID_taxtbox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_taxtbox;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

