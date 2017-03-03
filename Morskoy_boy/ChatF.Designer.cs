namespace Morskoy_boy
{
    partial class ChatF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatF));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chatsTab = new MetroFramework.Controls.MetroTabControl();
            this.messageSendPanel = new System.Windows.Forms.Panel();
            this.sendBtn = new MetroFramework.Controls.MetroButton();
            this.messageText = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.messageSendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chatsTab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.messageSendPanel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chatsTab
            // 
            this.chatsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatsTab.Location = new System.Drawing.Point(3, 3);
            this.chatsTab.Name = "chatsTab";
            this.chatsTab.Size = new System.Drawing.Size(444, 228);
            this.chatsTab.TabIndex = 0;
            // 
            // messageSendPanel
            // 
            this.messageSendPanel.Controls.Add(this.sendBtn);
            this.messageSendPanel.Controls.Add(this.messageText);
            this.messageSendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageSendPanel.Location = new System.Drawing.Point(3, 237);
            this.messageSendPanel.Name = "messageSendPanel";
            this.messageSendPanel.Size = new System.Drawing.Size(444, 60);
            this.messageSendPanel.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(350, 10);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(88, 40);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messageText
            // 
            this.messageText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.messageText.CustomBackground = true;
            this.messageText.Location = new System.Drawing.Point(0, 0);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(344, 60);
            this.messageText.TabIndex = 1;
            // 
            // ChatF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatF";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ChatF";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.messageSendPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal MetroFramework.Controls.MetroTabControl chatsTab;
        private System.Windows.Forms.Panel messageSendPanel;
        private MetroFramework.Controls.MetroTextBox messageText;
        private MetroFramework.Controls.MetroButton sendBtn;
    }
}