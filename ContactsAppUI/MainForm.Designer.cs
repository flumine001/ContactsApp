namespace ContactsAppUI
{
    partial class MainForm
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
            button1 = new Button();
            phone_textbox = new TextBox();
            textBox1 = new TextBox();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            EmailBox = new TextBox();
            PhoneNumberBox = new TextBox();
            VkBox = new TextBox();
            textBox7 = new TextBox();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(579, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // phone_textbox
            // 
            phone_textbox.BackColor = SystemColors.Control;
            phone_textbox.Location = new Point(73, 73);
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Size = new Size(194, 23);
            phone_textbox.TabIndex = 1;
            phone_textbox.TextChanged += phone_textbox_TextChanged;
            phone_textbox.KeyPress += phone_textbox_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 408);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // FirstNameBox
            // 
            FirstNameBox.BackColor = Color.Gray;
            FirstNameBox.BorderStyle = BorderStyle.None;
            FirstNameBox.Location = new Point(579, 63);
            FirstNameBox.Multiline = true;
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(248, 23);
            FirstNameBox.TabIndex = 3;
            FirstNameBox.MouseClick += textBox2_MouseClick;
            FirstNameBox.TextChanged += textBox2_TextChanged;
            // 
            // LastNameBox
            // 
            LastNameBox.BackColor = Color.Gray;
            LastNameBox.Location = new Point(579, 112);
            LastNameBox.Multiline = true;
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(248, 23);
            LastNameBox.TabIndex = 4;
            LastNameBox.TextChanged += textBox3_TextChanged;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.Gray;
            EmailBox.Location = new Point(579, 156);
            EmailBox.Multiline = true;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(248, 23);
            EmailBox.TabIndex = 5;
            EmailBox.TextChanged += textBox4_TextChanged;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.BackColor = Color.Gray;
            PhoneNumberBox.Location = new Point(579, 197);
            PhoneNumberBox.Multiline = true;
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(248, 23);
            PhoneNumberBox.TabIndex = 6;
            PhoneNumberBox.TextChanged += textBox5_TextChanged;
            // 
            // VkBox
            // 
            VkBox.BackColor = Color.Gray;
            VkBox.Location = new Point(579, 241);
            VkBox.Multiline = true;
            VkBox.Name = "VkBox";
            VkBox.Size = new Size(248, 23);
            VkBox.TabIndex = 7;
            VkBox.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(579, 281);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(248, 23);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(73, 112);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 274);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(362, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(396, 223);
            maskedTextBox1.Mask = "7(999) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 23);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(716, 390);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Remove_Click;
            // 
            // button3
            // 
            button3.Location = new Point(826, 390);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 589);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(textBox7);
            Controls.Add(VkBox);
            Controls.Add(PhoneNumberBox);
            Controls.Add(EmailBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(textBox1);
            Controls.Add(phone_textbox);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox phone_textbox;
        private TextBox textBox1;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox EmailBox;
        private TextBox PhoneNumberBox;
        private TextBox VkBox;
        private TextBox textBox7;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Button button3;
    }
}
