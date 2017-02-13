namespace Morskoy_boy
{
    partial class RegisterF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterF));
            this.label1 = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rppassTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.avaPB = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(60, 81);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(170, 20);
            this.loginTb.TabIndex = 1;
            this.loginTb.TextChanged += new System.EventHandler(this.loginTb_TextChanged);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(60, 325);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 30;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(79, 113);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(151, 20);
            this.passTb.TabIndex = 5;
            this.passTb.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // rppassTb
            // 
            this.rppassTb.Location = new System.Drawing.Point(94, 146);
            this.rppassTb.Name = "rppassTb";
            this.rppassTb.Size = new System.Drawing.Size(136, 20);
            this.rppassTb.TabIndex = 7;
            this.rppassTb.UseSystemPasswordChar = true;
            this.rppassTb.TextChanged += new System.EventHandler(this.rppassTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat pass:";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(60, 177);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(170, 20);
            this.emailTb.TabIndex = 9;
            this.emailTb.TextChanged += new System.EventHandler(this.emailTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail:";
            // 
            // fnameTb
            // 
            this.fnameTb.Location = new System.Drawing.Point(82, 207);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(148, 20);
            this.fnameTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "First name:";
            // 
            // oFD
            // 
            this.oFD.Filter = "Image files|*.png;*.jpg|All files|*.*";
            this.oFD.FileOk += new System.ComponentModel.CancelEventHandler(this.oFD_FileOk);
            // 
            // pB3
            // 
            this.pB3.Location = new System.Drawing.Point(236, 177);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(20, 20);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB3.TabIndex = 15;
            this.pB3.TabStop = false;
            // 
            // pB2
            // 
            this.pB2.Location = new System.Drawing.Point(236, 146);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(20, 20);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB2.TabIndex = 14;
            this.pB2.TabStop = false;
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(236, 81);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(20, 20);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB1.TabIndex = 12;
            this.pB1.TabStop = false;
            // 
            // avaPB
            // 
            this.avaPB.Image = global::Morskoy_boy.Properties.Resources._default;
            this.avaPB.Location = new System.Drawing.Point(283, 81);
            this.avaPB.Name = "avaPB";
            this.avaPB.Size = new System.Drawing.Size(117, 146);
            this.avaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avaPB.TabIndex = 2;
            this.avaPB.TabStop = false;
            this.avaPB.Click += new System.EventHandler(this.avaPB_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(283, 325);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(78, 23);
            this.backBtn.TabIndex = 31;
            this.backBtn.Text = "Back to login";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lnameTb
            // 
            this.lnameTb.Location = new System.Drawing.Point(83, 237);
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(147, 20);
            this.lnameTb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Last name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Birthday";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "";
            this.birthdayPicker.Location = new System.Drawing.Point(248, 279);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(158, 20);
            this.birthdayPicker.TabIndex = 35;
            this.birthdayPicker.Value = new System.DateTime(2017, 1, 28, 11, 14, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRb);
            this.groupBox1.Controls.Add(this.maleRb);
            this.groupBox1.Location = new System.Drawing.Point(11, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 40);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex:";
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(145, 17);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(56, 17);
            this.femaleRb.TabIndex = 1;
            this.femaleRb.Text = "female";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Checked = true;
            this.maleRb.Location = new System.Drawing.Point(30, 17);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(47, 17);
            this.maleRb.TabIndex = 0;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "male";
            this.maleRb.UseVisualStyleBackColor = true;
            // 
            // RegisterF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rppassTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.avaPB);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterF";
            this.Text = "Register new user";
            this.Load += new System.EventHandler(this.RegisterF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.PictureBox avaPB;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rppassTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
    }
}