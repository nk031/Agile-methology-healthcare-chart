using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Tables
{
    //class for add folder any new folder
    public class Folders : NoteFolder
    {
        public bool isRoot
        {
            get;
            set;
        }
        [OneToMany(inverseProperty: "ParentFolder", CascadeOperations = CascadeOperation.All)]
        public List<Folders> ChildrenFolders 
        {
            get;
            set;
        }
        [ManyToOne(inverseProperty: "ChildrenFolders", CascadeOperations = CascadeOperation.All)]
        public Folders ParentFolder
        { 
            get; 
            set; 
        }

        [OneToMany]
        public List<Note> Notes
        {
            get;
            set;
        }
    }
}
