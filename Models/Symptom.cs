using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace project2
{
    [Table("symptoms")]
    public class Symptom
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public int symptom_name { get; set; }
        public int ishemic_desease { get; set; }
        public int pericardits { get; set; }
        public int cardiomyopathy { get; set; }
        public int hypertension { get; set; }
        public int atherosclerosis { get; set; }
        public int arrhythmia { get; set; }
        public int user_has { get; set; }
    }
}
