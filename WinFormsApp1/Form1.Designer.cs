namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbName = new TextBox();
            tbLastName = new TextBox();
            label2 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            btSave = new Button();
            lbErrorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 42);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 1;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(12, 105);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(125, 27);
            tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "LastName";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 172);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(12, 236);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(125, 27);
            tbPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // btSave
            // 
            btSave.Location = new Point(198, 320);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 9;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // lbErrorMessage
            // 
            lbErrorMessage.AutoSize = true;
            lbErrorMessage.Location = new Point(375, 215);
            lbErrorMessage.Name = "lbErrorMessage";
            lbErrorMessage.Size = new Size(0, 20);
            lbErrorMessage.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbErrorMessage);
            Controls.Add(btSave);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbLastName);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbPhone;
        private Label label4;
        private Button btSave;
        private Label lbErrorMessage;
    }
}