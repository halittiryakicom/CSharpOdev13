using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev13
{
    internal class Baby
    {
        private DateTime _birthDay;
        private string _name;
        private string _surname;

        //default constructor
        public Baby() {
            _birthDay = DateTime.Now;
            Console.WriteLine($"Ingaaaaaaaaaaaaaaaaaaaa, {_birthDay}");
        }
        
        //alternatif constructor
        public Baby(string name, string surname) {
            _name = name;
            _surname = surname;
            _birthDay = DateTime.Now;
            Console.WriteLine($"Ingaaaaaaaaaaaaaaaaaaaa, {_birthDay}");
        }
        
        public void Information()
        {
            Console.WriteLine($"AD: {_name}\nSOYAD: {_surname}\nDOĞUM TARİHİ: {_birthDay}");
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }
    }  
}
