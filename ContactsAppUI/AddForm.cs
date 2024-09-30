using ContactsApp;
using ContactsApp.ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContactsAppUI
{
    public partial class AddForm : Form
    {
        public void buttonEnabler()
        {
            string phoneValidator = new string(maskedTextBox1.Text.Where(Char.IsDigit).ToArray());
            if (phoneValidator.Length == 11)
            {
                OkButton.Enabled = !string.IsNullOrEmpty(firstnameBox.Text) && !string.IsNullOrEmpty(lastnameBox.Text)
                    && !string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(vkBox.Text) && !string.IsNullOrEmpty(phoneValidator) && phoneValidator.Length == 11;

            }
            else
            {
                OkButton.Enabled = false;
                ToolTip okToolTip = new ToolTip();

                okToolTip.Show("Заполните форму корректными значениями, чтобы добавить контакт.", OkButton,
                    (Point)(lastnameBox.Size + new Size(-500, 10)), 5000);
                //OkButton.Enabled = true;
            }
            //todo: исправить активацию кнопки по текст боксу телефона(плейсхолдер активирует кнопку)
            //todo: Добавить возможность редактировать существующий контакт

        }

        private Project _project;
        private Project _sortedContacts;
        private Contacts _contact = new Contacts();

        public Contacts Contact
        {
            get { return _contact; }
            set
            {
                _contact.FirstName = value.FirstName;
                _contact.LastName = value.LastName;
                _contact.phoneNumber.Number = value.phoneNumber.Number;
                _contact.BirthDay = value.BirthDay;
                _contact.Email = value.Email;
                _contact.Vkid = value.Vkid;
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            _contact.LastName = lastnameBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (_contact.LastName != null & _contact.BirthDay != null)
            {
                lastnameBox.Text = _contact.LastName;
                firstnameBox.Text = _contact.FirstName;
                birthdayBox.Value = _contact.BirthDay;
                maskedTextBox1.Text = _contact.phoneNumber.Number;
                emailBox.Text = _contact.Email;
                vkBox.Text = _contact.Vkid;
                OkButton.Enabled = true;
            }
            else 
            {
                birthdayBox.Value = new DateTime(1900, 01, 01);
                OkButton.Enabled = false;
            }

            
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            _contact.phoneNumber.Number = maskedTextBox1.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void firstnameBox_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            _contact.FirstName = firstnameBox.Text;
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            _contact.Email = emailBox.Text;
        }

        private void vkBox_TextChanged(object sender, EventArgs e)
        {
            buttonEnabler();
            _contact.Vkid = vkBox.Text;
        }

        private void birthdayBox_ValueChanged(object sender, EventArgs e)
        {
            _contact.BirthDay = birthdayBox.Value;
        }
    }
}
