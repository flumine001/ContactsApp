namespace ContactsAppUI
{
    partial class AddForm
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
            firstnameBox = new TextBox();
            lastnameBox = new TextBox();
            emailBox = new TextBox();
            vkBox = new TextBox();
            birthdayBox = new DateTimePicker();
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // firstnameBox
            // 
            firstnameBox.Location = new Point(94, 59);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(420, 23);
            firstnameBox.TabIndex = 0;
            firstnameBox.TextChanged += firstnameBox_TextChanged;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(94, 30);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(420, 23);
            lastnameBox.TabIndex = 1;
            lastnameBox.TextChanged += lastnameBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(94, 146);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(420, 23);
            emailBox.TabIndex = 3;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // vkBox
            // 
            vkBox.Location = new Point(94, 175);
            vkBox.Name = "vkBox";
            vkBox.Size = new Size(420, 23);
            vkBox.TabIndex = 4;
            vkBox.TextChanged += vkBox_TextChanged;
            // 
            // birthdayBox
            // 
            birthdayBox.Location = new Point(94, 88);
            birthdayBox.Name = "birthdayBox";
            birthdayBox.Size = new Size(142, 23);
            birthdayBox.TabIndex = 5;
            birthdayBox.ValueChanged += birthdayBox_ValueChanged;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(324, 204);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(92, 28);
            OkButton.TabIndex = 6;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += button1_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(422, 204);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(92, 28);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Surname:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 88);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 117);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 146);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 175);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "vk.com:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(94, 117);
            maskedTextBox1.Mask = "7(999) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(420, 23);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 238);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(birthdayBox);
            Controls.Add(vkBox);
            Controls.Add(emailBox);
            Controls.Add(lastnameBox);
            Controls.Add(firstnameBox);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstnameBox;
        private TextBox lastnameBox;
        private TextBox emailBox;
        private TextBox vkBox;
        private DateTimePicker birthdayBox;
        private Button OkButton;
        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
    }
}