using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinStore.model;

namespace XamarinStore
{
    public class DataRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;

        public DataRepository(string dbPath)
        {
            // TODO: Initialize a new SQLiteConnection
            conn = new SQLiteConnection(dbPath);
            createTables(conn);
        }

        //---------------- [ table creations ] -----------------
        private void createTables(SQLiteConnection conn)
        {
            // TODO: Crear todas las tablas
            conn.CreateTable<PcBox>();
            conn.CreateTable<CPU>();
            conn.CreateTable<GPU>();
            conn.CreateTable<MotherBoard>();
            conn.CreateTable<Pedido>();
            conn.CreateTable<Ram>();
            conn.CreateTable<User>();
        }
        //---------------- [ table creations ] -----------------

        //---------------- [ get data methods ] -----------------
        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                //sdgsfgsdfg
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

        public List<PcBox> GetAllCases()
        {
            //Variable con lista de cases
            List<PcBox> casesList = new List<PcBox>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                casesList = conn.Table<PcBox>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return casesList;
        }

        public List<CPU> GetAllCpu()
        {
            //Variable con lista de cases
            List<CPU> cpuList = new List<CPU>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                cpuList = conn.Table<CPU>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return cpuList;
        }

        public List<GPU> GetAllGpu()
        {
            //Variable con lista de cases
            List<GPU> gpuList = new List<GPU>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                gpuList = conn.Table<GPU>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return gpuList;
        }

        public List<MotherBoard> GetAllMotherBoards()
        {
            //Variable con lista de cases
            List<MotherBoard> motherBoardList = new List<MotherBoard>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                motherBoardList = conn.Table<MotherBoard>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return motherBoardList;
        }

        public List<Pedido> GetAllPedidos()
        {
            //Variable con lista de cases
            List<Pedido> listPedidos = new List<Pedido>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listPedidos = conn.Table<Pedido>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listPedidos;
        }

        public List<Ram> GetAllRam()
        {
            //Variable con lista de cases
            List<Ram> listRam = new List<Ram>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listRam = conn.Table<Ram>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listRam;
        }

        public List<User> GetAllUsers()
        {
            //Variable con lista de cases
            List<User> listUsers = new List<User>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listUsers = conn.Table<User>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listUsers;
        }
        //---------------- [ get data methods ] -----------------
    }
}
