using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace project2.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

    }
}
