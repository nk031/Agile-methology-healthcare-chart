using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace FinalProject.Tables
{
    //added class for cobdition by using this option patient can explain thier condition too doctor 
    public class Conditions
    {
        [PrimaryKey, NotNull]
        public string Type
        {
            get;
            set;
        }

        [ManyToMany(typeof(UsersConditions))]
        public List<User> Users
        {
            get;
            set;
        }
    }
}
