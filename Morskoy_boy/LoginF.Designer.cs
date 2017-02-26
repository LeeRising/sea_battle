namespace Morskoy_boy
{
    partial class LoginF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginF));
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginL = new System.Windows.Forms.Label();
            this.passL = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(13, 171);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(204, 171);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(24, 87);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(36, 13);
            this.loginL.TabIndex = 2;
            this.loginL.Text = "Login:";
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Location = new System.Drawing.Point(24, 128);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(56, 13);
            this.passL.TabIndex = 3;
            this.passL.Text = "Password:";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(65, 84);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(196, 20);
            this.loginTb.TabIndex = 0;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(83, 125);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(178, 20);
            this.passTb.TabIndex = 1;
            this.passTb.UseSystemPasswordChar = true;
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(107, 171);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 210);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to play";
            this.Activated += new System.EventHandler(this.LoginF_Activated);
            this.Load += new System.EventHandler(this.LoginF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Button regBtn;
    }
}

