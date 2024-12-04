using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Drawing.Text;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ContactsAppUI
{

    public partial class MainForm : Form

    {
        private Project _project;
        private Project sortedContacts;



        private void RemoveContact()
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
        private void AddContact()
        {
            var newForm = new AddForm();
            var resultOfDialog = newForm.ShowDialog();
            if (resultOfDialog == DialogResult.OK)
            {
                var contact = newForm.Contact;
                Project sortedContacts = new Project();

                sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
                sortedContacts.Contact.Add(contact);
                _project.Contact = sortedContacts.Contact.OrderBy(x => x.LastName).ToList();
                ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
                _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
                listBox1.Items.Clear();
                int ContactCount = 0;
                foreach (var lastname in _project.Contact)
                {
                    listBox1.Items.Add(_project.Contact[ContactCount].LastName);
                    ContactCount++;

                }
                Birthday();

            }
            

        }
        private void EditContact()
        {


            var index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Выберите контакт для редактирования");
            }
            else
            {
                if (_project.Contact.Count > 0)
                {

                    var contactOfIndex = _project.Contact[index];

                    Contacts newCloneContact = (Contacts)contactOfIndex.Clone();
                    var newForm = new AddForm();
                    newForm.Contact = newCloneContact;
                    var resultOfDialog = newForm.ShowDialog();
                    if (resultOfDialog == DialogResult.OK)
                    {
                        contactOfIndex = newForm.Contact;
                        Project sortedContacts = new Project();

                        sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
                        sortedContacts.Contact[index].FirstName = contactOfIndex.FirstName;
                        sortedContacts.Contact[index].LastName = contactOfIndex.LastName;
                        sortedContacts.Contact[index].Email = contactOfIndex.Email;
                        sortedContacts.Contact[index].phoneNumber.Number = contactOfIndex.phoneNumber.Number;
                        sortedContacts.Contact[index].Vkid = contactOfIndex.Vkid;
                        sortedContacts.Contact[index].BirthDay = contactOfIndex.BirthDay;
                        
                        _project.Contact = sortedContacts.Contact.OrderBy(x => x.LastName).ToList();
                        ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
                        _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
                        listBox1.Items.Clear();
                        int ContactCount = 0;
                        foreach (var lastname in _project.Contact)
                        {
                            listBox1.Items.Add(_project.Contact[ContactCount].LastName);
                            ContactCount++;

                        }
                        Birthday();

                    }
                }
                else
                {
                    MessageBox.Show("Ноль контактов");
                }
            }
            

        }

       


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

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            if (FirstNameBox.Text.Length != 0)
            {
                //textBox2.Text = _contacts.FirstName;

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
        public void Birthday()
        {
            _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();

            Project _birth = new Project();
            Project _projectbirth = new Project();
            BirthDayShow.Text = null;

            for (int i = 0; i < sortedContacts.Contact.Count; i++)
            {
                if (_project.Contact[i].BirthDay.Day == DateTime.Today.Day &&
                    _project.Contact[i].BirthDay.Month == DateTime.Today.Month)
                {
                    _birth.Contact.Add(sortedContacts.Contact[i]);
                }
            }
            for (int i = 0; i < _birth.Contact.Count; i++)
            {
                BirthDayShow.Text = BirthDayShow.Text + _birth.Contact[i].LastName + ", ";


            }
            string newBirthText = BirthDayShow.Text;
            BirthDayShow.Text = newBirthText.Remove(newBirthText.Length - 2) + "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Project _birth = Project.Birthday(_project, DateTime.Today);
            Birthday();
            
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

            /*Project _birth = new Project();
            Project _projectbirth = new Project();

            for (int i = 0; i < sortedContacts.Contact.Count; i++)
            {
                if (_project.Contact[i].BirthDay.Day == DateTime.Today.Day &&
                    _project.Contact[i].BirthDay.Month == DateTime.Today.Month)
                {
                    _birth.Contact.Add(sortedContacts.Contact[i]);
                }
            }
            for (int i = 0; i < _birth.Contact.Count; i++)
            {
                BirthDayShow.Text = BirthDayShow.Text + _birth.Contact[i].LastName + ", ";
                
                
            }
            string newBirthText = BirthDayShow.Text;
            BirthDayShow.Text = newBirthText.Remove(newBirthText.Length - 2) + "";*/
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
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
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
                //maskedTextBox1.Text = null;
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
            //buttonEnabler();

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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Project sortedContacts = new Project();
            sortedContacts.Contact = _project.Contact.OrderBy(x => x.LastName).ToList();
            if (SearchBox.Text.Length > 0)
            {
                string searchstring = SearchBox.Text[0].ToString().ToUpper();

                bool found = false;
                for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                {

                    if (listBox1.Items[i].ToString().StartsWith(searchstring))
                    {

                        listBox1.SelectedItem = listBox1.Items[i];
                        found = true;
                        break;
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new AboutForm();
            newForm.Show();
        }
    }
}
