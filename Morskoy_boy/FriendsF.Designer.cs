using MaterialSkin;
using System.Drawing;

namespace Morskoy_boy
{
    partial class FriendsF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsF));
            this.stateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.contextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.searchTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sendMessageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeFullInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsListB = new Morskoy_boy.UI.MyControls.friendsListBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 23;
            this.stateComboBox.Items.AddRange(new object[] {
            "All",
            "Online",
            "Offline",
            "Busy",
            "Afk"});
            this.stateComboBox.Location = new System.Drawing.Point(0, 64);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(278, 29);
            this.stateComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.stateComboBox.TabIndex = 3;
            this.stateComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenu.Depth = 0;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageMenuItem,
            this.seeFullInfoMenuItem});
            this.contextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenu.Name = "materialContextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(150, 48);
            // 
            // searchTb
            // 
            this.searchTb.Depth = 1;
            this.searchTb.Hint = "Search";
            this.searchTb.Location = new System.Drawing.Point(10, 40);
            this.searchTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.SelectedText = "";
            this.searchTb.SelectionLength = 0;
            this.searchTb.SelectionStart = 0;
            this.searchTb.Size = new System.Drawing.Size(183, 23);
            this.searchTb.TabIndex = 0;
            this.searchTb.UseSystemPasswordChar = false;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // sendMessageMenuItem
            // 
            this.sendMessageMenuItem.Name = "sendMessageMenuItem";
            this.sendMessageMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sendMessageMenuItem.Text = "Send Message";
            // 
            // seeFullInfoMenuItem
            // 
            this.seeFullInfoMenuItem.Name = "seeFullInfoMenuItem";
            this.seeFullInfoMenuItem.Size = new System.Drawing.Size(149, 22);
            this.seeFullInfoMenuItem.Text = "See full info";
            // 
            // friendsListB
            // 
            this.friendsListB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friendsListB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.friendsListB.FormattingEnabled = true;
            this.friendsListB.ItemHeight = 66;
            this.friendsListB.Location = new System.Drawing.Point(0, 93);
            this.friendsListB.Name = "friendsListB";
            this.friendsListB.Size = new System.Drawing.Size(278, 251);
            this.friendsListB.TabIndex = 1;
            // 
            // FriendsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(278, 345);
            this.ControlBox = false;
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.friendsListB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FriendsF";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FriendsF_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.MyControls.friendsListBox friendsListB;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenu;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchTb;
        private System.Windows.Forms.ToolStripMenuItem sendMessageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeFullInfoMenuItem;
    }
}