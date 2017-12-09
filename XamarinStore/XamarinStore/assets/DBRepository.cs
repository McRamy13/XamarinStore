using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinStore.model;

namespace XamarinStore
{
    /// <summary>
    /// Clase DBRepository que gestionara la llamada
    /// a la BBDD.
    /// </summary>
    public class DBRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;

        /// <summary>
        /// Este método iniciará una nueva conexión a la BBDD
        /// </summary>
        /// <param name="dbPath">Ruta de la BBDD</param>
        public DBRepository(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            CreateTables(conn);
        }

        //---------------- [ table creations ] -----------------
        /// <summary>
        /// Método que llama a las distintas funciones de creación de tablas
        /// </summary>
        /// <param name="conn">Objeto de la conexión de la BBDD</param>
        private void CreateTables(SQLiteAsyncConnection conn)
        {
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
        /// <summary>
        /// Método que obtiene todas las cajas de PC en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de cajas creada</returns>
        public async Task<List<PcBox>> GetAllCases()
        {
            //Variable con lista de cases
            List<PcBox> casesList = new List<PcBox>();

            try
            {
                casesList = await conn.Table<PcBox>().ToListAsync();

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return casesList;
        }

        /// <summary>
        /// Método que obtiene todos los CPU en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de CPU creada</returns>

        public async Task<List<CPU>> GetAllCpu()
        {
            //Variable con lista de cases
            List<CPU> cpuList = new List<CPU>();

            try
            {
                cpuList = await conn.Table<CPU>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return cpuList;
        }

        /// <summary>
        /// Método que obtiene todas las GPU en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de GPU creada</returns>
        public async Task<List<GPU>> GetAllGpu()
        {
            //Variable con lista de cases
            List<GPU> gpuList = new List<GPU>();

            try
            {
                gpuList = await conn.Table<GPU>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            //Se devuelve la lista de personas
            return gpuList;
        }

        /// <summary>
        /// Método que obtiene todas las placas base en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de placas base creadas</returns>
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

        /// <summary>
        /// Método que obtiene todas los pedidos en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de pedidos creada</returns>
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

        /// <summary>
        /// Método que obtiene todas las RAM en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de RAM creada</returns>
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

        /// <summary>
        /// Método que obtiene todos los usuarios en una lista.
        /// </summary>
        /// <remarks>
        /// Llamamos al método ToListAsync para hacer una llamada asíncrona,
        /// añadiendo el await. Muestra una excepción si no se han podido recibir
        /// los datos.
        /// </remarks>
        /// <returns>Retorna la lista de usuarios creada</returns>
        public async Task<List<User>> GetAllUsers()
        {
            //Variable con lista de cases
            List<User> listUsers = new List<User>();

            try
            {
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

        /// <summary>
        /// Método que obtiene un usuario en función de su nick
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// el usuario en función de su nombre
        /// </remarks>
        /// <returns>Retorna el usuario consultado</returns>
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

        /// <summary>
        /// Método que obtiene un procesador en función del ID
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// el procesador en función de su id
        /// </remarks>
        /// <returns>Retorna el procesador consultado</returns>
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

        /// <summary>
        /// Método que obtiene una gráfica en función del ID
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// la gráfica en función de su id
        /// </remarks>
        /// <returns>Retorna la gráfica consultado</returns>
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

        /// <summary>
        /// Método que obtiene la placa base en función del ID
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// la placa base en función de su id
        /// </remarks>
        /// <returns>Retorna la placa base consultada</returns>
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

        /// <summary>
        /// Método que obtiene una caja de pc en función del ID
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// la caja de pc en función de su id
        /// </remarks>
        /// <returns>Retorna la caja de pc</returns>
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

        /// <summary>
        /// Método que obtiene una memoria Ram en función del ID
        /// </summary>
        /// <remarks>
        /// Creamos una sentencia SQL con el código de SQLite en la cual obtendremos
        /// la memoria Ram en función de su id
        /// </remarks>
        /// <returns>Retorna la memoria Ram consultada</returns>
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

        //---------------- [ insert methods ] -----------------

        /// <summary>
        /// Este método añade un nuevo pedido a la BBDD
        /// </summary>
        /// <remarks>
        /// Agrega de manera asíncrona un pedido a la BBDD
        /// </remarks>
        /// <param name="pedido">Objeto pedido que será insertado en la BBDD</param>
        /// <returns></returns>
        public async Task  AddNewOrderAsync(Pedido pedido)
        {
            int result = 0;
            try
            {
                result = await conn.InsertAsync(pedido);
            }catch(Exception ex)
            {
                StatusMessage = string.Format("Failed to add order. Error: {0}", ex.Message);
            }
        }

        //---------------- [ insert methods ] -----------------
    }
}
