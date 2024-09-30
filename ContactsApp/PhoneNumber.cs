using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{

    /// <summary>
    /// Класс, принимающий и возвращающий телефон.
    /// </summary>
    public class PhoneNumber
    {
        private string _number;

        public string Number
        {
            get { return _number; }
            set
            {
                string str_number = value.ToString();

                //if (str_number.Length == 11 && str_number[0] == '7') //Поначалу сделал проверку на первую цифру, но затем решил просто заменять первый введенный символ в text box на 7
               // if (str_number.Length == 16)
               // {

                    _number = value;
               // }
                //else throw new ArgumentException("Номер должен состоять из 11 цифр и начинаться с 7");
            }
        }
    }
}
