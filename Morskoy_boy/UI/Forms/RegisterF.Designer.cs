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
            this.loginL = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.passTb = new System.Windows.Forms.TextBox();
            this.passL = new System.Windows.Forms.Label();
            this.rppassTb = new System.Windows.Forms.TextBox();
            this.rppassL = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.firstnL = new System.Windows.Forms.Label();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.avaPB = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.lastnL = new System.Windows.Forms.Label();
            this.birthL = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.sexL = new System.Windows.Forms.GroupBox();
            this.femaleL = new System.Windows.Forms.RadioButton();
            this.maleL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaPB)).BeginInit();
            this.sexL.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(18, 84);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(36, 13);
            this.loginL.TabIndex = 0;
            this.loginL.Text = "Login:";
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
            this.regBtn.TabIndex = 10;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(79, 113);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(151, 20);
            this.passTb.TabIndex = 2;
            this.passTb.UseSystemPasswordChar = true;
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Location = new System.Drawing.Point(18, 116);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(56, 13);
            this.passL.TabIndex = 4;
            this.passL.Text = "Password:";
            // 
            // rppassTb
            // 
            this.rppassTb.Location = new System.Drawing.Point(94, 146);
            this.rppassTb.Name = "rppassTb";
            this.rppassTb.Size = new System.Drawing.Size(136, 20);
            this.rppassTb.TabIndex = 3;
            this.rppassTb.UseSystemPasswordChar = true;
            this.rppassTb.TextChanged += new System.EventHandler(this.rppassTb_TextChanged);
            // 
            // rppassL
            // 
            this.rppassL.AutoSize = true;
            this.rppassL.Location = new System.Drawing.Point(18, 149);
            this.rppassL.Name = "rppassL";
            this.rppassL.Size = new System.Drawing.Size(70, 13);
            this.rppassL.TabIndex = 6;
            this.rppassL.Text = "Repeat pass:";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(60, 177);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(170, 20);
            this.emailTb.TabIndex = 4;
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
            this.fnameTb.TabIndex = 5;
            // 
            // firstnL
            // 
            this.firstnL.AutoSize = true;
            this.firstnL.Location = new System.Drawing.Point(18, 210);
            this.firstnL.Name = "firstnL";
            this.firstnL.Size = new System.Drawing.Size(58, 13);
            this.firstnL.TabIndex = 10;
            this.firstnL.Text = "First name:";
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
            this.avaPB.Image = ((System.Drawing.Image)(resources.GetObject("avaPB.Image")));
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
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back to login";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lnameTb
            // 
            this.lnameTb.Location = new System.Drawing.Point(83, 237);
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(147, 20);
            this.lnameTb.TabIndex = 6;
            // 
            // lastnL
            // 
            this.lastnL.AutoSize = true;
            this.lastnL.Location = new System.Drawing.Point(18, 240);
            this.lastnL.Name = "lastnL";
            this.lastnL.Size = new System.Drawing.Size(59, 13);
            this.lastnL.TabIndex = 32;
            this.lastnL.Text = "Last name:";
            // 
            // birthL
            // 
            this.birthL.AutoSize = true;
            this.birthL.Location = new System.Drawing.Point(303, 257);
            this.birthL.Name = "birthL";
            this.birthL.Size = new System.Drawing.Size(45, 13);
            this.birthL.TabIndex = 34;
            this.birthL.Text = "Birthday";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "";
            this.birthdayPicker.Location = new System.Drawing.Point(248, 279);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(158, 20);
            this.birthdayPicker.TabIndex = 9;
            this.birthdayPicker.Value = new System.DateTime(2017, 1, 28, 11, 14, 0, 0);
            // 
            // sexL
            // 
            this.sexL.Controls.Add(this.femaleL);
            this.sexL.Controls.Add(this.maleL);
            this.sexL.Location = new System.Drawing.Point(11, 266);
            this.sexL.Name = "sexL";
            this.sexL.Size = new System.Drawing.Size(219, 40);
            this.sexL.TabIndex = 36;
            this.sexL.TabStop = false;
            this.sexL.Text = "Sex:";
            // 
            // femaleL
            // 
            this.femaleL.AutoSize = true;
            this.femaleL.Location = new System.Drawing.Point(145, 17);
            this.femaleL.Name = "femaleL";
            this.femaleL.Size = new System.Drawing.Size(56, 17);
            this.femaleL.TabIndex = 8;
            this.femaleL.Text = "female";
            this.femaleL.UseVisualStyleBackColor = true;
            // 
            // maleL
            // 
            this.maleL.AutoSize = true;
            this.maleL.Checked = true;
            this.maleL.Location = new System.Drawing.Point(30, 17);
            this.maleL.Name = "maleL";
            this.maleL.Size = new System.Drawing.Size(47, 17);
            this.maleL.TabIndex = 7;
            this.maleL.TabStop = true;
            this.maleL.Text = "male";
            this.maleL.UseVisualStyleBackColor = true;
            // 
            // RegisterF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.ControlBox = false;
            this.Controls.Add(this.sexL);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.birthL);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.lastnL);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.firstnL);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rppassTb);
            this.Controls.Add(this.rppassL);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.avaPB);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.loginL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterF";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register new user";
            this.Load += new System.EventHandler(this.RegisterF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaPB)).EndInit();
            this.sexL.ResumeLayout(false);
            this.sexL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.PictureBox avaPB;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.TextBox rppassTb;
        private System.Windows.Forms.Label rppassL;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label firstnL;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label lastnL;
        private System.Windows.Forms.Label birthL;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.GroupBox sexL;
        private System.Windows.Forms.RadioButton femaleL;
        private System.Windows.Forms.RadioButton maleL;
    }
}