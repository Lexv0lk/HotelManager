using System;

namespace HotelManager
{
    public class Guest : IIdentifiable
    {
        public int Id { get; }

        public string Name;
        public string Surname;
        public string MiddleName;
        public DateTime BirthDate;
        public string Gender;
        public string Phone;

        public int PassportSeries;
        public int PassportNumber;
        public DateTime PassportIssueDate;

        public Guest(int id, string name, string surname, string middleName, DateTime birthDate,
            string gender, string phone, int passportSeries, int passportNumber,
            DateTime passportIssueDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            BirthDate = birthDate;
            Gender = gender;
            Phone = phone;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            PassportIssueDate = passportIssueDate;
        }
    }
}
