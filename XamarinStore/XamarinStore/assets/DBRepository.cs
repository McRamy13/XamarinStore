using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinStore.model;

namespace XamarinStore
{
    public class DBRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;

        public DBRepository(string dbPath)
        {
            // TODO: Initialize a new SQLiteConnection
            conn = new SQLiteAsyncConnection(dbPath);
            createTables(conn);
        }

        //---------------- [ table creations ] -----------------
        private void createTables(SQLiteAsyncConnection conn)
        {
            // TODO: Crear todas las tablas
            conn.CreateTableAsync<PcBox>();
            conn.CreateTableAsync<CPU>();
            conn.CreateTableAsync<GPU>();
            conn.CreateTableAsync<MotherBoard>();
            conn.CreateTableAsync<Pedido>();
            conn.CreateTableAsync<Ram>();
            conn.CreateTableAsync<User>();
        }
        //---------------- [ table creations ] -----------------

        //---------------- [ get data methods ] -----------------

        public async Task<List<PcBox>> GetAllCases()
        {
            //Variable con lista de cases
            List<PcBox> casesList = new List<PcBox>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                casesList = await conn.Table<PcBox>().ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return casesList;
        }

        public async Task<List<CPU>> GetAllCpu()
        {
            //Variable con lista de cases
            List<CPU> cpuList = new List<CPU>();

            try
            {
                //todo change comments
                // TODO: return a list of CPU saved to the Case table in the database
                cpuList = await conn.Table<CPU>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return cpuList;
        }

        public async Task<List<GPU>> GetAllGpu()
        {
            //Variable con lista de cases
            List<GPU> gpuList = new List<GPU>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                gpuList = await conn.Table<GPU>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return gpuList;
        }

        public async Task<List<MotherBoard>> GetAllMotherBoards()
        {
            //Variable con lista de cases
            List<MotherBoard> motherBoardList = new List<MotherBoard>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                motherBoardList = await conn.Table<MotherBoard>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return motherBoardList;
        }

        public async Task<List<Pedido>> GetAllPedidos()
        {
            //Variable con lista de cases
            List<Pedido> listPedidos = new List<Pedido>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listPedidos = await conn.Table<Pedido>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listPedidos;
        }

        public async Task<List<Ram>> GetAllRam()
        {
            //Variable con lista de cases
            List<Ram> listRam = new List<Ram>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listRam = await conn.Table<Ram>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listRam;
        }

        public async Task<List<User>> GetAllUsers()
        {
            //Variable con lista de cases
            List<User> listUsers = new List<User>();

            try
            {
                // TODO: return a list of cases saved to the Case table in the database
                listUsers = await conn.Table<User>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return listUsers;
        }

        //consulta para traer un sólo usuario
        public Task<User> getUserByName(String name)
        {
            var user = from p in conn.Table<User>()
                       where p.Nick == name
                       select p;
            return user.FirstOrDefaultAsync();
        }
        //---------------- [ get data methods ] -----------------
    }
}
