using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    [Table("Ram")]
    public class Ram
    {
        //properties
        [PrimaryKey, AutoIncrement, Column("_idRam")]
        public int IdRam { get; set; }

        [MaxLength(250), NotNull]
        public string Name { get; set; }


        [MaxLength(4), NotNull]
        public int Frecuency { get; set; }

        [MaxLength(4), NotNull]
        public string RamType { get; set; }

        [NotNull]
        public double Price { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
