using FinalProject.Tables;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace FinalProject
{
    //added class for book an apponitment
    public class Appointment
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id//primary key for class
        {
            get;
            set;
        }

        [NotNull]
        public DateTime aptDate//used datetime variable
        {
            get;
            set;
        }

        //Need to save the time that the user wants to be reminded of their appointment
        //This will be used to resubmit the notifications after device restart, because they are not saved otherwise.
        public DateTime reminderTime
        {
            get;
            set;
        }
        public string followUpAdvice //advice from doctor
        {
            get;
            set;
        }
        public string reasonForVisit//reason for visit to doctor
        {
            get;
            set;
        }

        public string dName// add your doctor name
        {
            get;
            set;
        }
        public string diagnosis
        {
            get;
            set;
        }

        [ForeignKey(typeof(Doctor))]
        public int dId
        {
            get;
            set;
        }

        [ForeignKey(typeof(User))]

        public int uId
        {
            get;
            set;
        }
        [OneToMany]
        public List<Vaccine> Vaccines //give vaccines if needed
        {
            get;
            set;
        }
        [OneToMany]
        public List<Prescription> Prescriptions// any prescription for patient
        {
            get;
            set;
        }
    }
}
