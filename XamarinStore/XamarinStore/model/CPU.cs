using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    /// <summary>
    /// Clase CPU
    /// </summary>
    [Table("CPU")]
    public class CPU
    {
        /// <summary>
        /// Propiedad IdCpu
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("_idCpu")]
        public int IdCpu { get; set; }

        /// <summary>
        /// Propiedad Name
        /// </summary>
        [MaxLength(250), NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Socket
        /// </summary>
        [MaxLength(20), NotNull]
        public string Socket { get; set; }

        /// <summary>
        /// Propiedad Price
        /// </summary>
        [NotNull]
        public double Price { get; set; }

        /// <summary>
        /// Propiedad Descripciópn
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
