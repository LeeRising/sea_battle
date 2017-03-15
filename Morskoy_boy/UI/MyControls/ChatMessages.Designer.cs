namespace Morskoy_boy.UI.MyControls
{
    partial class ChatMessages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avaPb = new System.Windows.Forms.PictureBox();
            this.messageText = new MetroFramework.Controls.MetroTextBox();
            this.dateLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.avaPb)).BeginInit();
            this.SuspendLayout();
            // 
            // avaPb
            // 
            this.avaPb.Location = new System.Drawing.Point(3, 3);
            this.avaPb.Name = "avaPb";
            this.avaPb.Size = new System.Drawing.Size(82, 74);
            this.avaPb.TabIndex = 0;
            this.avaPb.TabStop = false;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(91, 3);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(236, 52);
            this.messageText.TabIndex = 1;
            this.messageText.Text = "metroTextBox1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Depth = 0;
            this.dateLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateLabel.Location = new System.Drawing.Point(91, 58);
            this.dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(94, 16);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "materialLabel1";
            // 
            // ChatMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.avaPb);
            this.Name = "ChatMessages";
            this.Size = new System.Drawing.Size(330, 80);
            ((System.ComponentModel.ISupportInitialize)(this.avaPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avaPb;
        private MetroFramework.Controls.MetroTextBox messageText;
        private MaterialSkin.Controls.MaterialLabel dateLabel;
    }
}
