using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    [Table("CPU")]
    class CPU
    {
        //properties
        [PrimaryKey, AutoIncrement, Column("_idCpu")]
        public int IdCpu { get; set; }

        [MaxLength(250), NotNull]
        public string name { get; set; }


        [MaxLength(20), NotNull]
        public string socket { get; set; }

        [NotNull]
        public double price { get; set; }

        [MaxLength(1000)]
        public string description { get; set; }
    }
}
