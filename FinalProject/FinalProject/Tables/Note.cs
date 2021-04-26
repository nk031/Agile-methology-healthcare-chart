using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Tables
{
    //class for add notes by doctor
    public class Note : NoteFolder
    {
        public string Description
        {
            get;
            set;
        }
    }
}
