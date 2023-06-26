using System;
using System.Collections.Generic;
using System.Text;
using project2.Models;
using SQLite;

namespace project2.Services
{
    public class DB
    {
        private readonly SQLiteConnection conn;

        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Note>();
        }
        public List<Note> GetNotes()
        {
            return conn.Table<Note>().ToList();
        }
        public int SaveNote(Note note)
        {
            return conn.Insert(note);
        }

    }
}
