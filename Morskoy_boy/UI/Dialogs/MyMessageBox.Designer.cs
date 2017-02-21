namespace Morskoy_boy.UI.Dialogs
{
    partial class MyMessageBox
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
            this.MessageBoxLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btn3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // MessageBoxLabel
            // 
            this.MessageBoxLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MessageBoxLabel.Depth = 0;
            this.MessageBoxLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.MessageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageBoxLabel.Location = new System.Drawing.Point(10, 74);
            this.MessageBoxLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MessageBoxLabel.Name = "MessageBoxLabel";
            this.MessageBoxLabel.Size = new System.Drawing.Size(378, 73);
            this.MessageBoxLabel.TabIndex = 0;
            this.MessageBoxLabel.Text = "materialLabel1";
            // 
            // btn3
            // 
            this.btn3.Depth = 0;
            this.btn3.Location = new System.Drawing.Point(303, 153);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn3.Name = "btn3";
            this.btn3.Primary = true;
            this.btn3.Size = new System.Drawing.Size(85, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Btn3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            // 
            // btn2
            // 
            this.btn2.Depth = 0;
            this.btn2.Location = new System.Drawing.Point(152, 153);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn2.Name = "btn2";
            this.btn2.Primary = true;
            this.btn2.Size = new System.Drawing.Size(85, 35);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Btn2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Depth = 0;
            this.btn1.Location = new System.Drawing.Point(10, 153);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.Primary = true;
            this.btn1.Size = new System.Drawing.Size(85, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Visible = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.MessageBoxLabel);
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel MessageBoxLabel;
        private MaterialSkin.Controls.MaterialFlatButton btn3;
        private MaterialSkin.Controls.MaterialFlatButton btn2;
        private MaterialSkin.Controls.MaterialFlatButton btn1;
    }
}