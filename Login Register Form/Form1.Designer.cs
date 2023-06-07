namespace Login_Register_Form
{
    partial class pnlMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.pnlregister = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtregusername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtregphone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtregemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcomfirmpwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsginup = new System.Windows.Forms.Button();
            this.txtregpwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkregister = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnllogin.SuspendLayout();
            this.pnlregister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.student);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 434);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.LimeGreen;
            this.pnllogin.Controls.Add(this.pnlregister);
            this.pnllogin.Controls.Add(this.linkregister);
            this.pnllogin.Controls.Add(this.label5);
            this.pnllogin.Controls.Add(this.btnlogin);
            this.pnllogin.Controls.Add(this.txtpassword);
            this.pnllogin.Controls.Add(this.label4);
            this.pnllogin.Controls.Add(this.txtusername);
            this.pnllogin.Controls.Add(this.label3);
            this.pnllogin.Controls.Add(this.label2);
            this.pnllogin.Location = new System.Drawing.Point(210, 12);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(484, 434);
            this.pnllogin.TabIndex = 1;
            this.pnllogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlregister
            // 
            this.pnlregister.Controls.Add(this.btnclose);
            this.pnlregister.Controls.Add(this.txtregusername);
            this.pnlregister.Controls.Add(this.label12);
            this.pnlregister.Controls.Add(this.txtregphone);
            this.pnlregister.Controls.Add(this.label13);
            this.pnlregister.Controls.Add(this.txtregemail);
            this.pnlregister.Controls.Add(this.label10);
            this.pnlregister.Controls.Add(this.txtcomfirmpwd);
            this.pnlregister.Controls.Add(this.label11);
            this.pnlregister.Controls.Add(this.linklogin);
            this.pnlregister.Controls.Add(this.label6);
            this.pnlregister.Controls.Add(this.btnsginup);
            this.pnlregister.Controls.Add(this.txtregpwd);
            this.pnlregister.Controls.Add(this.label7);
            this.pnlregister.Controls.Add(this.txtfullname);
            this.pnlregister.Controls.Add(this.label8);
            this.pnlregister.Controls.Add(this.label9);
            this.pnlregister.Location = new System.Drawing.Point(3, 0);
            this.pnlregister.Name = "pnlregister";
            this.pnlregister.Size = new System.Drawing.Size(481, 433);
            this.pnlregister.TabIndex = 9;
            this.pnlregister.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(403, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 25;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtregusername
            // 
            this.txtregusername.Location = new System.Drawing.Point(52, 318);
            this.txtregusername.Name = "txtregusername";
            this.txtregusername.Size = new System.Drawing.Size(296, 20);
            this.txtregusername.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LimeGreen;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(48, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Suggested username";
            // 
            // txtregphone
            // 
            this.txtregphone.Location = new System.Drawing.Point(50, 273);
            this.txtregphone.Name = "txtregphone";
            this.txtregphone.Size = new System.Drawing.Size(296, 20);
            this.txtregphone.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LimeGreen;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(48, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "phone";
            // 
            // txtregemail
            // 
            this.txtregemail.Location = new System.Drawing.Point(50, 229);
            this.txtregemail.Name = "txtregemail";
            this.txtregemail.Size = new System.Drawing.Size(296, 20);
            this.txtregemail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LimeGreen;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(46, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email";
            // 
            // txtcomfirmpwd
            // 
            this.txtcomfirmpwd.Location = new System.Drawing.Point(50, 189);
            this.txtcomfirmpwd.Name = "txtcomfirmpwd";
            this.txtcomfirmpwd.Size = new System.Drawing.Size(296, 20);
            this.txtcomfirmpwd.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LimeGreen;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(48, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Comfirm Password";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.linklogin.Location = new System.Drawing.Point(211, 397);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(34, 15);
            this.linklogin.TabIndex = 16;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Login";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = " Have an account ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnsginup
            // 
            this.btnsginup.BackColor = System.Drawing.SystemColors.Menu;
            this.btnsginup.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsginup.ForeColor = System.Drawing.Color.Black;
            this.btnsginup.Location = new System.Drawing.Point(50, 345);
            this.btnsginup.Name = "btnsginup";
            this.btnsginup.Size = new System.Drawing.Size(110, 30);
            this.btnsginup.TabIndex = 14;
            this.btnsginup.Text = "Sign Up";
            this.btnsginup.UseVisualStyleBackColor = false;
            this.btnsginup.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtregpwd
            // 
            this.txtregpwd.Location = new System.Drawing.Point(50, 144);
            this.txtregpwd.Name = "txtregpwd";
            this.txtregpwd.Size = new System.Drawing.Size(296, 20);
            this.txtregpwd.TabIndex = 13;
            this.txtregpwd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LimeGreen;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(46, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(50, 99);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(296, 20);
            this.txtfullname.TabIndex = 11;
            this.txtfullname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LimeGreen;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(46, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Full Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LimeGreen;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 34);
            this.label9.TabIndex = 9;
            this.label9.Text = "Register";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // linkregister
            // 
            this.linkregister.AutoSize = true;
            this.linkregister.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkregister.ForeColor = System.Drawing.Color.DarkOrange;
            this.linkregister.Location = new System.Drawing.Point(261, 379);
            this.linkregister.Name = "linkregister";
            this.linkregister.Size = new System.Drawing.Size(50, 15);
            this.linkregister.TabIndex = 8;
            this.linkregister.TabStop = true;
            this.linkregister.Text = "Register";
            this.linkregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Don\'t have an account ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Red;
            this.btnlogin.Location = new System.Drawing.Point(247, 231);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 38);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(152, 166);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(296, 20);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(58, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(146, 109);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(296, 20);
            this.txtusername.TabIndex = 2;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign In";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Lime;
            this.student.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.Black;
            this.student.Location = new System.Drawing.Point(15, 303);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(172, 50);
            this.student.TabIndex = 0;
            this.student.Text = "Student\r\nEnrollment System";
            this.student.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.student.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnllogin);
            this.Name = "pnlMain";
            this.Text = "AfriHub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.pnlregister.ResumeLayout(false);
            this.pnlregister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlregister;
        private System.Windows.Forms.LinkLabel linkregister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsginup;
        private System.Windows.Forms.TextBox txtregpwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtregphone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtregemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcomfirmpwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtregusername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnclose;
    }
}

