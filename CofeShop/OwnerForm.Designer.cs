namespace CofeShop
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.regNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.updatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(832, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 25);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dark Mood";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.toolStripSplitButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(972, 25);
            this.toolStrip2.TabIndex = 90;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regNewUserToolStripMenuItem,
            this.updateUserInformationToolStripMenuItem,
            this.salaryInformationToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripDropDownButton1.Text = "Employee";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // regNewUserToolStripMenuItem
            // 
            this.regNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regNewUserToolStripMenuItem.Image")));
            this.regNewUserToolStripMenuItem.Name = "regNewUserToolStripMenuItem";
            this.regNewUserToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.regNewUserToolStripMenuItem.Text = "Registration  New User";
            this.regNewUserToolStripMenuItem.Click += new System.EventHandler(this.regNewUserToolStripMenuItem_Click);
            // 
            // updateUserInformationToolStripMenuItem
            // 
            this.updateUserInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateUserInformationToolStripMenuItem.Image")));
            this.updateUserInformationToolStripMenuItem.Name = "updateUserInformationToolStripMenuItem";
            this.updateUserInformationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.updateUserInformationToolStripMenuItem.Text = "Update User Information";
            this.updateUserInformationToolStripMenuItem.Click += new System.EventHandler(this.updateUserInformationToolStripMenuItem_Click);
            // 
            // salaryInformationToolStripMenuItem
            // 
            this.salaryInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salaryInformationToolStripMenuItem.Image")));
            this.salaryInformationToolStripMenuItem.Name = "salaryInformationToolStripMenuItem";
            this.salaryInformationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.salaryInformationToolStripMenuItem.Text = "Salary Information";
            this.salaryInformationToolStripMenuItem.Click += new System.EventHandler(this.salaryInformationToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 22);
            this.toolStripButton2.Text = "Cofffee Infromation";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripSplitButton1.Text = "Other";
            // 
            // updatePasswordToolStripMenuItem
            // 
            this.updatePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatePasswordToolStripMenuItem.Image")));
            this.updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            this.updatePasswordToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.updatePasswordToolStripMenuItem.Text = "Update Password";
            this.updatePasswordToolStripMenuItem.Click += new System.EventHandler(this.updatePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 46);
            this.label1.TabIndex = 91;
            this.label1.Text = "Please Choose Option from Tool Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(598, 34);
            this.label3.TabIndex = 92;
            this.label3.Text = "**Welcome To Bhai Bhai Coffee Shop Portal**";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 616);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem regNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem salaryInformationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem updatePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}