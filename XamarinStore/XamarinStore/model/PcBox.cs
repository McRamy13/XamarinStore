using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    /// <summary>
    /// Clase PcBox
    /// </summary>
    [Table("PcBox")]
    public class PcBox
    {
        /// <summary>
        /// Propiedad IdCase
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("_idBox")]
        public int IdCase { get; set; }

        /// <summary>
        /// Propiedad Name
        /// </summary>
        [MaxLength(250), NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Type
        /// </summary>
        [MaxLength(20), NotNull]
        public string Type { get; set; }

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
