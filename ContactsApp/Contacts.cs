using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий контакт.
    /// </summary>
    public class Contacts : ICloneable
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _firstname;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _lastname;

        //private string _phonenumber;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// E-mail контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// ID Вконтакте
        /// </summary>
        private string _vkid;

        public PhoneNumber phoneNumber = new PhoneNumber();

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                
                if (value.Length > 50 )
                {
                    throw new ArgumentException("Имя не может быть больше 50 символов");
                }
                else
                {
                    _firstname = value;


                }
                
            }

        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия не может быть больше 50 символов");
                }
                else
                {
                    _lastname = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get { return _birthday; }
            set
            {
                // Устанавливаем ограничение на дату по условию задачи
                DateTime minDateTime = new DateTime(1900, 01, 01); //дата не может быть раньше 01.01.1990
                DateTime maxDateTime = DateTime.Now; //Дата не может быть позже текущей
                if (value > maxDateTime && value < minDateTime)
                {
                    throw new ArgumentException("Дата рождения не может быть ниже 1900 года и выше текущего времени");
                }
                else
                {
                    _birthday = value;
                }
            }
        }
        /// <summary>
        /// Метод, устанавливающий и возвращающий email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Email не может быть больше 50 символов");
                }
                else
                {
                    _email = value;
                }
            }
        }
        /// <summary>
        /// Устанавливает и возвращает VK id
        /// </summary>
        public string Vkid
        {
            get { return _vkid; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("VK id не может быть больше 15 символов");
                }
                else
                {
                    _vkid = value;
                }
            }
        }

        /// <summary>
        /// Конструктор класса с 6 входными параметрами.
        /// </summary>
        /// <param name="phoneNumber"></param> Номер телефона.
        /// <param name="firstname"></param> Имя контакта.
        /// <param name="lastname"></param> Фамилия контакта.
        /// <param name="email"></param> E-mail.
        /// <param name="birthday"></param> Дата рождения контакта.
        /// <param name="vkid"></param> ID Vk.
        public Contacts(string firstname, string lastname, DateTime birthday, string email, string phoneNumber ,
            string vkid)
        {
            
            FirstName = firstname;
            LastName = lastname;
            BirthDay = birthday;
            Email = email;
            this.phoneNumber.Number = phoneNumber;
            Vkid = vkid;

        }

        /// <summary>
        /// Клонирование контакта
        /// </summary>
        ///
        public object Clone()
        {
            return new Contacts (FirstName, LastName, BirthDay, Email, phoneNumber.Number, Vkid);
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Contacts()
        {
        }
        

    }

    
}
