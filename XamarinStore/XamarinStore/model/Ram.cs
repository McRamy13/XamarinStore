using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    /// <summary>
    /// Propiedad Ram
    /// </summary>
    [Table("Ram")]
    public class Ram
    {
        /// <summary>
        /// Propiedad IdRam
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("_idRam")]
        public int IdRam { get; set; }

        /// <summary>
        /// Propiedad Name
        /// </summary>
        [MaxLength(250), NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Frencuency
        /// </summary>
        [MaxLength(4), NotNull]
        public int Frecuency { get; set; }

        /// <summary>
        /// Propiedad RamType
        /// </summary>
        [MaxLength(4), NotNull]
        public string RamType { get; set; }

        /// <summary>
        /// Propiedad Price
        /// </summary>
        [NotNull]
        public double Price { get; set; }

        /// <summary>
        /// Propiedad Description
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
