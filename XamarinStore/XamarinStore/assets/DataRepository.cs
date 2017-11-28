using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.assets
{
    class DataRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;

        public DataRepository(string dbPath)
        {
            // TODO: Initialize a new SQLiteConnection
            conn = new SQLiteConnection(dbPath);
            // TODO: Crear todas las tablas
            //conn.CreateTable<Person>();
        }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                // TODO: insert a new person into the Person table
                //result = conn.Insert(new Person { Name = name });
                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        /*public List<Person> GetAllPeople()
        {
            //Variable con lista de personas
            List<Person> listPerson = new List<Person>();

            try
            {
                // TODO: return a list of people saved to the Person table in the database
                listPerson = conn.Table<Person>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listPerson;
        }*/
    }
}
