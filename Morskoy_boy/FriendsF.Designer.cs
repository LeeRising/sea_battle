using MaterialSkin;

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
            this.friendsListBox1 = new Morskoy_boy.UI.MyControls.friendsListBox();
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
            "Busy"});
            this.stateComboBox.Location = new System.Drawing.Point(0, 64);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(218, 29);
            this.stateComboBox.TabIndex = 1;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // friendsListBox1
            // 
            this.friendsListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friendsListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.friendsListBox1.FormattingEnabled = true;
            this.friendsListBox1.ItemHeight = 66;
            this.friendsListBox1.Location = new System.Drawing.Point(0, 94);
            this.friendsListBox1.Name = "friendsListBox1";
            this.friendsListBox1.Size = new System.Drawing.Size(218, 251);
            this.friendsListBox1.TabIndex = 0;
            // 
            // FriendsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 345);
            this.ControlBox = false;
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.friendsListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FriendsF";
            this.Text = "My Friends";
            this.Activated += new System.EventHandler(this.FriendsF_Activated);
            this.Load += new System.EventHandler(this.FriendsF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.MyControls.friendsListBox friendsListBox1;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
    }
}