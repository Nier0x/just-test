using System;
using System.Collections.Generic;
using System.Text;
namespace DemoSplitFiles
{
    sealed class ForeignCitizen : Citizen
    {
        //Поля данных класса

        private string ForeignPassport;
        private DateTime VisaOpen;
        private DateTime VisaClose;

        //Конструктор Визы и паспорта

        public ForeignCitizen(string _name, string _surname, bool _sex,string _password, string _address,string _foreignPassport, DateTime _visaOpen, DateTime _visaClose) : base(_name, _surname, _sex, _password, _address)
        {
            ForeignPassport = _foreignPassport;
            VisaOpen = _visaOpen;
            VisaClose = _visaClose;
        }
        public string ForeignPassport {get { return ForeignPassport; } set { ForeignPassport = value; }}
        public DateTime VisaOpen {get { return VisaOpen; } set { VisaOpen = value; } }
        public DateTime VisaClose{ get { return VisaClose; }set { VisaClose = value; }}

        //Вывод данных на консоль

        public new void Print()
        {
            base.Print();
            Console.WriteLine("foreignPassport: {0}", ForeignPassport);
            Console.WriteLine("visaOpen: {0}", VisaOpen);
            Console.WriteLine("visaClose: {0}", VisaClose);
            Console.WriteLine("Хорошего Вам дня!");
        }
    }
}