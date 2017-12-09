using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace XamarinStore.model
{
    /// <summary>
    /// Propiedad User
    /// </summary>
    [Table("User")]
    public class User
    {
        /// <summary>
        /// Propiedad IdUser
        /// </summary>
        [PrimaryKey,  Column("_codUser"), MaxLength(4), Unique]
        public string IdUser { get; set; }

        /// <summary>
        /// Propiedad Nick
        /// </summary>
        [MaxLength(50), NotNull, Unique]
        public string Nick { get; set; }

        /// <summary>
        /// Propiedad Password
        /// </summary>
        [MaxLength(10), NotNull, Unique]
        public string Password { get; set; }

        /// <summary>
        /// Propiedad Tipo
        /// </summary>
        [MaxLength(7), NotNull]
        public string Tipo { get; set; }
    }
}
