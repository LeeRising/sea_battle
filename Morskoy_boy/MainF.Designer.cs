using System.Windows.Forms;

namespace Morskoy_boy
{
    partial class MainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gamehistoryBtn = new System.Windows.Forms.Button();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            this.winL = new System.Windows.Forms.Label();
            this.loseL = new System.Windows.Forms.Label();
            this.rankL = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastCheckBtnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(282, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "VS Computer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(282, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "VS Player";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gamehistoryBtn
            // 
            this.gamehistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamehistoryBtn.Location = new System.Drawing.Point(282, 189);
            this.gamehistoryBtn.Name = "gamehistoryBtn";
            this.gamehistoryBtn.Size = new System.Drawing.Size(120, 23);
            this.gamehistoryBtn.TabIndex = 3;
            this.gamehistoryBtn.Text = "Game history";
            this.gamehistoryBtn.UseVisualStyleBackColor = true;
            this.gamehistoryBtn.Click += new System.EventHandler(this.gamehistoryBtn_Click);
            // 
            // friendsBtn
            // 
            this.friendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendsBtn.Location = new System.Drawing.Point(282, 228);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(120, 23);
            this.friendsBtn.TabIndex = 4;
            this.friendsBtn.Text = "Friends";
            this.friendsBtn.UseVisualStyleBackColor = true;
            this.friendsBtn.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.BackColor = System.Drawing.Color.White;
            this.nameL.Location = new System.Drawing.Point(135, 106);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(35, 13);
            this.nameL.TabIndex = 5;
            this.nameL.Text = "label1";
            // 
            // winL
            // 
            this.winL.AutoSize = true;
            this.winL.Location = new System.Drawing.Point(135, 132);
            this.winL.Name = "winL";
            this.winL.Size = new System.Drawing.Size(35, 13);
            this.winL.TabIndex = 6;
            this.winL.Text = "label2";
            // 
            // loseL
            // 
            this.loseL.AutoSize = true;
            this.loseL.Location = new System.Drawing.Point(176, 132);
            this.loseL.Name = "loseL";
            this.loseL.Size = new System.Drawing.Size(35, 13);
            this.loseL.TabIndex = 7;
            this.loseL.Text = "label3";
            // 
            // rankL
            // 
            this.rankL.AutoSize = true;
            this.rankL.Location = new System.Drawing.Point(135, 157);
            this.rankL.Name = "rankL";
            this.rankL.Size = new System.Drawing.Size(35, 13);
            this.rankL.TabIndex = 8;
            this.rankL.Text = "label1";
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.fastCheckBtnToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 65);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(201, 24);
            this.menu.TabIndex = 9;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fastCheckBtnToolStripMenuItem
            // 
            this.fastCheckBtnToolStripMenuItem.Name = "fastCheckBtnToolStripMenuItem";
            this.fastCheckBtnToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.fastCheckBtnToolStripMenuItem.Text = "FastCheckBtn";
            this.fastCheckBtnToolStripMenuItem.Click += new System.EventHandler(this.fastCheckBtnToolStripMenuItem_Click);
            // 
            // profileImg
            // 
            this.profileImg.Location = new System.Drawing.Point(12, 103);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(104, 148);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 0;
            this.profileImg.TabStop = false;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.rankL);
            this.Controls.Add(this.loseL);
            this.Controls.Add(this.winL);
            this.Controls.Add(this.friendsBtn);
            this.Controls.Add(this.gamehistoryBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "MainF";
            this.Text = "Batlle in the see";
            this.Activated += new System.EventHandler(this.MainF_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainF_FormClosed);
            this.Load += new System.EventHandler(this.MainF_Load);
            this.LocationChanged += new System.EventHandler(this.MainF_LocationChanged);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private PictureBox profileImg;
        private Button button1;
        private Button button2;
        private Button gamehistoryBtn;
        private Button friendsBtn;
        private Label nameL;
        private Label loseL;
        private Label winL;
        private Label rankL;
        private MenuStrip menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem fastCheckBtnToolStripMenuItem;
    }
}