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
            conn.CreateTableAsync<PcBox>().Wait();
            conn.CreateTableAsync<CPU>().Wait();
            conn.CreateTableAsync<GPU>().Wait();
            conn.CreateTableAsync<MotherBoard>().Wait();
            conn.CreateTableAsync<Pedido>().Wait();
            conn.CreateTableAsync<Ram>().Wait();
            conn.CreateTableAsync<User>().Wait();
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
        public async Task<User> GetUserByName(String name)
        {
            User u = null;
            try
            {
                var user = from p in conn.Table<User>()
                       where p.Nick == name
                       select p;
                u = await user.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer un sólo usuario
        public async Task<User> GetUserById(String name)
        {
            User u = null;
            try
            {
                var user = from p in conn.Table<User>()
                           where p.IdUser == name
                           select p;
                u = await user.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer un sólo cpu
        public async Task<CPU> GetCPUById(int id)
        {
            CPU u = null;
            try
            {
                var cpu = from p in conn.Table<CPU>()
                           where p.IdCpu == id
                           select p;
                u = await cpu.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer un sólo GPU
        public async Task<GPU> GetGPUById(int id)
        {
            GPU u = null;
            try
            {
                var gpu = from p in conn.Table<GPU>()
                          where p.IdGpu == id
                          select p;
                u = await gpu.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer una sola MotherBoard
        public async Task<MotherBoard> GetMotherBoardId(int id)
        {
            MotherBoard u = null;
            try
            {
                var motherBoard = from p in conn.Table<MotherBoard>()
                          where p.IdMotherBoard == id
                          select p;
                u = await motherBoard.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer una sola MotherBoard
        public async Task<PcBox> GetPcBoxById(int id)
        {
            PcBox u = null;
            try
            {
                var pcBox = from p in conn.Table<PcBox>()
                          where p.IdCase == id
                          select p;
                u = await pcBox.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }

        //consulta para traer una sola MotherBoard
        public async Task<Ram> GetRamById(int id)
        {
            Ram u = null;
            try
            {
                var gpu = from p in conn.Table<Ram>()
                          where p.IdRam == id
                          select p;
                u = await gpu.FirstAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return u;
        }
        //---------------- [ get data methods ] -----------------
    }
}
