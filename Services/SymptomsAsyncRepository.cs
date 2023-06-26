using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project2.Services
{ 
    public class SymptomsAsyncRepository
    {
        SQLiteConnection database;

            public SymptomsAsyncRepository(string databasePath)
            {
                database = new SQLiteConnection(databasePath);
            }

            public async Task<Symptom> GetItem(int id)
            {
                return database.Get<Symptom>(id);
            }
            public async Task<int> DeleteItem(Symptom item)
            {
                return database.Delete(item);
            }
            public async Task<int> SaveItem(Symptom item)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
            public async Task<int> SetItem(int id)
            {
                return database.Insert(1);
            }


        public int GetValueUserHas(int id)
        {
            return database.Get<Symptom>(id).user_has;
        }
        public int GetValuePericardit(int id)
        {
            return database.Get<Symptom>(id).pericardits;
        }
        public int GetValueArrhythmia(int id)
        {
            return database.Get<Symptom>(id).arrhythmia;
        }
        public int GetValueHypertension(int id)
        {
            return database.Get<Symptom>(id).hypertension;
        }
        public int GetValueAtheroscleros(int id)
        {
            return database.Get<Symptom>(id).atherosclerosis;
        }
        public int GetValueCardiomyopathy(int id)
        {
            return database.Get<Symptom>(id).cardiomyopathy;
        }
        public int GetValueIshemic(int id)
        {
            return database.Get<Symptom>(id).ishemic_desease;
        }
    }
}
