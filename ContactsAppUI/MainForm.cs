﻿using System;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form

    {
        public void buttonEnabler()
        {
            button1.Enabled = !string.IsNullOrEmpty(FirstNameBox.Text) && !string.IsNullOrEmpty(LastNameBox.Text)
                && !string.IsNullOrEmpty(EmailBox.Text) && !string.IsNullOrEmpty(VkBox.Text) && !string.IsNullOrEmpty(maskedTextBox1.Text);
           //todo: исправить активацию кнопки по текст боксу телефона(плейсхолдер активирует кнопку)
           //todo: Добавить возможность редактировать существующий контакт
          
        }
        int buttonCount = 0;
        private Project _project;
        //private Project sortedContacts;

        //Создаем новый телефон
        private PhoneNumber _phoneNumber = new PhoneNumber();

        private Contacts _contacts = new Contacts();
        //В эту строку будет записываться текст ошибки
        private string _textException;
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
            var selectedIndex = listBox1.SelectedIndex;
            //Contacts contact2 = new Contacts("Вова", "Гупсень", new DateTime(1999, 05, 05), "krutoy@mail.ru", 79999999999, "vk12345");
            Contacts contact1 = new Contacts(FirstNameBox.Text, LastNameBox.Text, dateTimePicker1.Value, EmailBox.Text, maskedTextBox1.Text, VkBox.Text);
            //_project.Contact.Add(contact1);
            sortedContacts.Contact.Add(contact1);
            _project.Contact = sortedContacts.Contact.OrderBy(x => x.LastName).ToList();
            ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
            //ProjectManager.SaveToFile(sortedContacts, ProjectManager.FilePath);
            _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
            listBox1.Items.Clear();
            int ContactCount = 0;
            foreach (var lastname in _project.Contact)
            {
                listBox1.Items.Add(_project.Contact[ContactCount].LastName);
                ContactCount++;

            }


        }
        //Данный метод нужен для проверки работоспособности логики PhoneNumber через TextBox

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {

            int countException = 0;
            ToolTip phoneToolTip = new ToolTip();//тултип будет выводить определенный текст под textbox в зависимости от соблюденных условий логики PhoneNumber
            phone_textbox.SelectionStart = phone_textbox.Text.Length; //Выбираем начало ввода текста 
            Regex phonepattern = new Regex(@"^[7]{1}");
            if (phone_textbox.Text.Length != 0)
            {
                //char[] fst = new char[phone_textbox.Text.Length];
                //fst[0] = phone_textbox.Text[0];
                phone_textbox.Text = phone_textbox.Text.Replace(phone_textbox.Text[0], '7');//заменяем первый символ на 7
            }

            else
            {
                return;
            }
            try
            {



                if (phone_textbox.Text.Length != 0)
                {
                    //_phoneNumber.Number = Convert.ToInt64(phone_textbox.Text);
                }
                else
                {
                    return;
                }
            }

            catch (ArgumentException exception)
            {
                _textException = exception.Message;
                countException++;
            }

            if (countException != 0)
            {
                phone_textbox.BackColor = Color.Red;
                phoneToolTip.Show(_textException, phone_textbox,
                    (Point)(phone_textbox.Size + new Size(width: -400, height: 10)), duration: 1000);

            }

            else
            {
                phone_textbox.BackColor = Color.White;
                phoneToolTip.Show(text: "Правильно", phone_textbox,
                    (Point)(phone_textbox.Size + new Size(width: -200, height: 10)), duration: 1000);
            }
        }
        //Убираем возможность вводить любые символы кроме чисел
        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)Keys.Back)//Разрешает использовать BackSpace
            //return;
            //e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar); //не запрещает использовать Вставку с любыми символами в буфере из-за чего крашит.
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;//Разрешает вводить только цифры и нажатие BackSpace
            phone_textbox.MaxLength = 11;

        }
        //Замена первого символа на 7 в строке номера телефона
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox1.SelectionStart = textBox1.Text.Length;
            if (textBox1.Text.Length != 0)
            {
                char[] fst = new char[textBox1.Text.Length];
                fst[0] = textBox1.Text[0];
                textBox1.Text = textBox1.Text.Replace(fst[0], '7');
            }
            else
            {
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            
            if (FirstNameBox.Text.Length != 0)
            {
                //textBox2.Text = _contacts.FirstName;
                buttonCount++;
            }
            else
            {
                return;
            }
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox2.Text = _contacts.FirstName;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Text = "_contacts.FirstName";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            if (LastNameBox.Text.Length == 0)
            {
                //textBox3.Text = _phoneNumber.Number.ToString();
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //Тут просто проверял правильность работоспособности логики Project и ProjectManager. Сериализует заданный список и затем десериализует его, и затем возвращает в заданные textBox поля контакта
        private void MainForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //textBox2.Text = _project.contact1.FirstName;
            Contacts contact1 = new Contacts("Вова", "Яупсень", new DateTime(1999, 05, 05), "krutoy@mail.ru", "79999999999", "vk12345");
            Contacts contact2 = new Contacts("Петя", "Апкин", new DateTime(2003, 04, 05), "sobaka@mail.ru", "79000000000", "vk00001");
            //contact1.BirthDay = new DateTime(1999, 05, 05);
            Project project1 = new Project();
            project1.Contact.Add(contact1);
            project1.Contact.Add(contact2);

            //ProjectManager.SaveToFile(project1, ProjectManager.FilePath);

            //Project project2 = ProjectManager.LoadFromFile(ProjectManager.FilePath); 

            _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);

            /*
            textBox2.Text = _project.Contact[0].FirstName;
            //textBox2.Text = contact1.FirstName;
            textBox3.Text = _project.Contact[0].LastName;
            textBox4.Text = _project.Contact[0].Email;
            textBox5.Text = _project.Contact[0].phoneNumber.Number.ToString();
            textBox6.Text = _project.Contact[0].Vkid;
            dateTimePicker1.Value = _project.Contact[0].BirthDay;
            */
            // Создаем новый список с сортировкой по фамилии оригинального списка
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
            //Цикл вывода фамилий контактов в листбокс
            int ContactCount = 0;
            foreach (var lastname in sortedContacts.Contact)
            {
                listBox1.Items.Add(sortedContacts.Contact[ContactCount].LastName);
                ContactCount++;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //var sortedContacts = _project.Contact.OrderBy(x => x.LastName).ToList();
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
            var selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                FirstNameBox.Text = null;

                LastNameBox.Text = null;
                EmailBox.Text = null;
                PhoneNumberBox.Text = null;
                VkBox.Text = null;
                dateTimePicker1.Value = new DateTime(1900, 01, 01);
            }

            if (selectedIndex >= 0)
            {
                FirstNameBox.Text = sortedContacts.Contact[selectedIndex].FirstName;
                LastNameBox.Text = sortedContacts.Contact[selectedIndex].LastName;
                EmailBox.Text = sortedContacts.Contact[selectedIndex].Email;
                maskedTextBox1.Text = sortedContacts.Contact[selectedIndex].phoneNumber.Number.ToString();
                VkBox.Text = sortedContacts.Contact[selectedIndex].Vkid;
                dateTimePicker1.Value = sortedContacts.Contact[selectedIndex].BirthDay;
            }
        }



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            buttonEnabler();

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
            var selectedIndex = listBox1.SelectedIndex;
            //var sortedContacts = _project.Contact.OrderBy(x => x.LastName).ToList();
            if (selectedIndex >= 0)
            {
                sortedContacts.Contact.RemoveAt(selectedIndex);
                ProjectManager.SaveToFile(sortedContacts, ProjectManager.FilePath);
                _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
                listBox1.Items.Clear();
                int ContactCount = 0;
                foreach (var lastname in sortedContacts.Contact)
                {
                    listBox1.Items.Add(sortedContacts.Contact[ContactCount].LastName);
                    ContactCount++;

                }
            }
        }
    }
}
