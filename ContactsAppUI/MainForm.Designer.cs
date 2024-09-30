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
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            EmailBox = new TextBox();
            VkBox = new TextBox();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            SearchBox = new TextBox();
            button4 = new Button();
            EditButton = new Button();
            BirthDayInfo = new Label();
            BirthDayShow = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            editContactToolStripMenuItem = new ToolStripMenuItem();
            removeContactToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button3 = new Button();
            phone_textbox = new TextBox();
            textBox1 = new TextBox();
            PhoneNumberBox = new TextBox();
            textBox7 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameBox
            // 
            FirstNameBox.BackColor = SystemColors.Window;
            FirstNameBox.Location = new Point(385, 61);
            FirstNameBox.Multiline = true;
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(420, 23);
            FirstNameBox.TabIndex = 3;
            FirstNameBox.MouseClick += textBox2_MouseClick;
            FirstNameBox.TextChanged += textBox2_TextChanged;
            // 
            // LastNameBox
            // 
            LastNameBox.BackColor = SystemColors.Window;
            LastNameBox.Location = new Point(385, 32);
            LastNameBox.Multiline = true;
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(420, 23);
            LastNameBox.TabIndex = 4;
            LastNameBox.TextChanged += textBox3_TextChanged;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = SystemColors.Window;
            EmailBox.Location = new Point(385, 148);
            EmailBox.Multiline = true;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(420, 23);
            EmailBox.TabIndex = 5;
            EmailBox.TextChanged += textBox4_TextChanged;
            // 
            // VkBox
            // 
            VkBox.BackColor = SystemColors.Window;
            VkBox.Location = new Point(385, 177);
            VkBox.Multiline = true;
            VkBox.Name = "VkBox";
            VkBox.Size = new Size(420, 23);
            VkBox.TabIndex = 7;
            VkBox.TextChanged += textBox6_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 424);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(385, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(385, 119);
            maskedTextBox1.Mask = "7(999) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(420, 23);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(174, 507);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Remove_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(51, 32);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(249, 23);
            SearchBox.TabIndex = 14;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 508);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(93, 508);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 16;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // BirthDayInfo
            // 
            BirthDayInfo.AutoSize = true;
            BirthDayInfo.Location = new Point(352, 250);
            BirthDayInfo.Name = "BirthDayInfo";
            BirthDayInfo.Size = new Size(199, 15);
            BirthDayInfo.TabIndex = 17;
            BirthDayInfo.Text = "Сегодня день рождение празднует:";
            // 
            // BirthDayShow
            // 
            BirthDayShow.AutoSize = true;
            BirthDayShow.Location = new Point(557, 250);
            BirthDayShow.Name = "BirthDayShow";
            BirthDayShow.Size = new Size(43, 15);
            BirthDayShow.TabIndex = 18;
            BirthDayShow.Text = "111111";
            BirthDayShow.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 19;
            label1.Text = "Find:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 35);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 20;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 64);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 21;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 96);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 22;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 122);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 23;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 151);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 24;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 180);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 25;
            label7.Text = "vk.com:";
            label7.Click += label7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, editContactToolStripMenuItem, removeContactToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(162, 22);
            addContactToolStripMenuItem.Text = "Add Contact";
            addContactToolStripMenuItem.Click += addContactToolStripMenuItem_Click;
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(162, 22);
            editContactToolStripMenuItem.Text = "Edit Contact";
            editContactToolStripMenuItem.Click += editContactToolStripMenuItem_Click;
            // 
            // removeContactToolStripMenuItem
            // 
            removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            removeContactToolStripMenuItem.Size = new Size(162, 22);
            removeContactToolStripMenuItem.Text = "Remove Contact";
            removeContactToolStripMenuItem.Click += removeContactToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 507);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(455, 507);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // phone_textbox
            // 
            phone_textbox.BackColor = SystemColors.Control;
            phone_textbox.Location = new Point(385, 547);
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Size = new Size(194, 23);
            phone_textbox.TabIndex = 1;
            phone_textbox.TextChanged += phone_textbox_TextChanged;
            phone_textbox.KeyPress += phone_textbox_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(695, 547);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.BackColor = SystemColors.Window;
            PhoneNumberBox.Location = new Point(600, 508);
            PhoneNumberBox.Multiline = true;
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(420, 23);
            PhoneNumberBox.TabIndex = 6;
            PhoneNumberBox.TextChanged += textBox5_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(600, 479);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(420, 23);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 590);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BirthDayShow);
            Controls.Add(BirthDayInfo);
            Controls.Add(EditButton);
            Controls.Add(button4);
            Controls.Add(SearchBox);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "ContactApp";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox EmailBox;
        private TextBox VkBox;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private TextBox SearchBox;
        private Button button4;
        private Button EditButton;
        private Label BirthDayInfo;
        private Label BirthDayShow;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem editContactToolStripMenuItem;
        private ToolStripMenuItem removeContactToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
        private Button button3;
        private TextBox phone_textbox;
        private TextBox textBox1;
        private TextBox PhoneNumberBox;
        private TextBox textBox7;
    }
}
