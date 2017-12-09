using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    /// <summary>
    /// Clase Pedido
    /// </summary>
    [Table("Pedido")]
    public class Pedido
    {
        /// <summary>
        /// Propiedad IdPedido
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("_idPedido")]
        public int IdPedido { get; set; }

        /// <summary>
        /// Propiedad IdUser
        /// </summary>
        [NotNull,MaxLength(4)]
        public string IdUser { get; set; }

        /// <summary>
        /// Propiedad IdCase
        /// </summary>
        [NotNull]
        public int IdCase { get; set; }

        /// <summary>
        /// Propiedad IdCPU
        /// </summary>
        [NotNull]
        public int IdCpu { get; set; }


        /// <summary>
        /// Propiedad IdGPU
        /// </summary>
        [NotNull]
        public int IdGpu { get; set; }

        /// <summary>
        /// Propiedad IdMotherBoard
        /// </summary>
        [NotNull]
        public int IdMotherBoard { get; set; }

        /// <summary>
        /// Propiedad IdRam
        /// </summary>
        [NotNull]
        public int IdRam { get; set; }

        /// <summary>
        /// Propiedad Price
        /// </summary>
        [NotNull]
        public double Price { get; set; }
    }
}
