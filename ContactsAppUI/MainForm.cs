using System;
using System.Globalization;
using System.Reflection;
using ContactsApp;
using ContactsApp.ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form

    {
        private Project _project;


        //������� ����� �������
        private PhoneNumber _phoneNumber = new PhoneNumber();

        private Contacts _contacts = new Contacts();
        //� ��� ������ ����� ������������ ����� ������
        private string _textException;
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //ProjectManager.SaveToFile(_project);
        }
        //������ ����� ����� ��� �������� ����������������� ������ PhoneNumber ����� TextBox

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {

            int countException = 0;
            ToolTip phoneToolTip = new ToolTip();//������ ����� �������� ������������ ����� ��� textbox � ����������� �� ����������� ������� ������ PhoneNumber
            phone_textbox.SelectionStart = phone_textbox.Text.Length; //�������� ������ ����� ������ 
            if (phone_textbox.Text.Length != 0)
            {
                //char[] fst = new char[phone_textbox.Text.Length];
                //fst[0] = phone_textbox.Text[0];
                phone_textbox.Text = phone_textbox.Text.Replace(phone_textbox.Text[0], '7');//�������� ������ ������ �� 7
            }

            else
            {
                return;
            }
            try
            {



                if (phone_textbox.Text.Length != 0)
                {
                    _phoneNumber.Number = Convert.ToInt64(phone_textbox.Text);
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
                phoneToolTip.Show(text: "���������", phone_textbox,
                    (Point)(phone_textbox.Size + new Size(width: -200, height: 10)), duration: 1000);
            }
        }
        //������� ����������� ������� ����� ������� ����� �����
        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)Keys.Back)//��������� ������������ BackSpace
                //return;
            //e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar); //�� ��������� ������������ ������� � ������ ��������� � ������ ��-�� ���� ������.
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar !=8;//��������� ������� ������ ����� � ������� BackSpace
            phone_textbox.MaxLength = 11;

        }
        //������ ������� ������� �� 7 � ������ ������ ��������
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
            if (textBox2.Text.Length == 0)
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
            if (textBox3.Text.Length == 0)
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
        //��� ������ �������� ������������ ����������������� ������ Project � ProjectManager. ����������� �������� ������ � ����� ������������� ���, � ����� ���������� � �������� textBox ���� ��������
        private void MainForm_Load(object sender, EventArgs e)
        {
            //textBox2.Text = _project.contact1.FirstName;
            Contacts contact1 = new Contacts("����", "�������", new DateTime(1999, 05, 05), "krutoy@mail.ru", 79999999999, "vk12345");
            //contact1.BirthDay = new DateTime(1999, 05, 05);
            Project project1 = new Project();
            project1.Contact.Add(contact1);
            ProjectManager.SaveToFile(project1, ProjectManager.FilePath);

            //Project project2 = ProjectManager.LoadFromFile(ProjectManager.FilePath); 

            _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
            textBox2.Text = _project.Contact[0].FirstName;
            //textBox2.Text = contact1.FirstName;
            textBox3.Text = _project.Contact[0].LastName;
            textBox4.Text = _project.Contact[0].Email;
            textBox5.Text = _project.Contact[0].phoneNumber.ToString();
            textBox6.Text = contact1.Vkid;
            dateTimePicker1.Value = _project.Contact[0].BirthDay;

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
    }
}
