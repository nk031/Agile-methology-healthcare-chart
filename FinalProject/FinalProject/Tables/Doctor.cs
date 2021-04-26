using FinalProject.Tables;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace FinalProject
{
    //this class is added to show doctor discription also can add new doctor 
    public class Doctor
    {
        [PrimaryKey, AutoIncrement]
        public int Id//primary key
        {
            get;
            set;
        }
        [NotNull]
        public string dName// doctor name
        {
            get;
            set;
        }

        public string dPractice // doctor practice
        {
            get;
            set;
        }
        public string dType
        {
            get;
            set;
        }
        public string dAddress
        {
            get;
            set;
        }
        [MaxLength(10)]
        public string dState
        {
            get;
            set;
        }

        public string dZipCode
        {
            get;
            set;
        }
        public string dPhone
        {
            get;
            set;
        }
        public string dEmail
        {
            get;
            set;
        }
        [ManyToMany(typeof(UsersDoctors))] //no limit to add doctor list
        public List<User> Users
        {
            get;
            set;
        }
        [OneToMany]
        public List<Appointment> Appointments//from appointment class
        {
            get;
            set;
        }
        [OneToMany]
        public List<Prescription> Prescriptions //from prescription class
        {
            get;
            set;
        }
        [OneToMany]
        public List<Vaccine> Vaccines//from vaccines class
        {
            get;
            set;
        }
    }
}
