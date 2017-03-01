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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastCheckBtnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.friendsBtn = new MetroFramework.Controls.MetroTile();
            this.nameL = new MetroFramework.Controls.MetroLabel();
            this.winL = new MetroFramework.Controls.MetroLabel();
            this.loseL = new MetroFramework.Controls.MetroLabel();
            this.rankL = new MetroFramework.Controls.MetroLabel();
            this.gamehistoryBtn = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(168, 24);
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
            this.fastCheckBtnToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fastCheckBtnToolStripMenuItem.Text = "TestBtn";
            this.fastCheckBtnToolStripMenuItem.Click += new System.EventHandler(this.fastCheckBtnToolStripMenuItem_Click);
            // 
            // profileImg
            // 
            this.profileImg.Location = new System.Drawing.Point(12, 103);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(156, 240);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 0;
            this.profileImg.TabStop = false;
            // 
            // friendsBtn
            // 
            this.friendsBtn.BackColor = System.Drawing.Color.White;
            this.friendsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.friendsBtn.Location = new System.Drawing.Point(294, 286);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(93, 79);
            this.friendsBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.friendsBtn.TabIndex = 10;
            this.friendsBtn.Text = "Friends";
            this.friendsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.friendsBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.friendsBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("friendsBtn.TileImage")));
            this.friendsBtn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.friendsBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.friendsBtn.UseTileImage = true;
            this.friendsBtn.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameL.Location = new System.Drawing.Point(195, 103);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(58, 25);
            this.nameL.TabIndex = 11;
            this.nameL.Text = "Name";
            // 
            // winL
            // 
            this.winL.AutoSize = true;
            this.winL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.winL.Location = new System.Drawing.Point(195, 145);
            this.winL.Name = "winL";
            this.winL.Size = new System.Drawing.Size(49, 25);
            this.winL.TabIndex = 12;
            this.winL.Text = "Wins";
            // 
            // loseL
            // 
            this.loseL.AutoSize = true;
            this.loseL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.loseL.Location = new System.Drawing.Point(294, 145);
            this.loseL.Name = "loseL";
            this.loseL.Size = new System.Drawing.Size(53, 25);
            this.loseL.TabIndex = 13;
            this.loseL.Text = "Loses";
            // 
            // rankL
            // 
            this.rankL.AutoSize = true;
            this.rankL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.rankL.Location = new System.Drawing.Point(65, 346);
            this.rankL.Name = "rankL";
            this.rankL.Size = new System.Drawing.Size(49, 25);
            this.rankL.TabIndex = 14;
            this.rankL.Text = "Rank";
            // 
            // gamehistoryBtn
            // 
            this.gamehistoryBtn.BackColor = System.Drawing.Color.White;
            this.gamehistoryBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gamehistoryBtn.Location = new System.Drawing.Point(195, 286);
            this.gamehistoryBtn.Name = "gamehistoryBtn";
            this.gamehistoryBtn.Size = new System.Drawing.Size(93, 79);
            this.gamehistoryBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.gamehistoryBtn.TabIndex = 10;
            this.gamehistoryBtn.Text = "My Games";
            this.gamehistoryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gamehistoryBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gamehistoryBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("gamehistoryBtn.TileImage")));
            this.gamehistoryBtn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gamehistoryBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.gamehistoryBtn.UseTileImage = true;
            this.gamehistoryBtn.Click += new System.EventHandler(this.gamehistoryBtn_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.White;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile2.Location = new System.Drawing.Point(294, 201);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(93, 79);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "VS Player";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.BackColor = System.Drawing.Color.White;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile3.Location = new System.Drawing.Point(195, 201);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(93, 79);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile3.TabIndex = 10;
            this.metroTile3.Text = "VS Comp";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 376);
            this.Controls.Add(this.rankL);
            this.Controls.Add(this.loseL);
            this.Controls.Add(this.winL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.gamehistoryBtn);
            this.Controls.Add(this.friendsBtn);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainF";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "See Battle";
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
        private MenuStrip menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem fastCheckBtnToolStripMenuItem;
        private MetroFramework.Controls.MetroTile friendsBtn;
        private MetroFramework.Controls.MetroLabel nameL;
        private MetroFramework.Controls.MetroLabel winL;
        private MetroFramework.Controls.MetroLabel loseL;
        private MetroFramework.Controls.MetroLabel rankL;
        private MetroFramework.Controls.MetroTile gamehistoryBtn;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}