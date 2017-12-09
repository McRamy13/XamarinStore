using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    /// <summary>
    /// Clase GPU
    /// </summary>
    [Table("GPU")]
    public class GPU
    {
        /// <summary>
        /// Propiedad IdGPU
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("_idGpu")]
        public int IdGpu { get; set; }

        /// <summary>
        /// Propiedad Name
        /// </summary>
        [MaxLength(250), NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Graphics
        /// </summary>
        [MaxLength(20), NotNull]
        public string Graphics { get; set; }

        /// <summary>
        /// Propiedad Price
        /// </summary>
        [NotNull]
        public double Price { get; set; }

        /// <summary>
        /// Propiedad Descripción
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
