using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    [Table("CPU")]
    public class CPU
    {
        //properties
        [PrimaryKey, AutoIncrement, Column("_idCpu")]
        public int IdCpu { get; set; }

        [MaxLength(250), NotNull]
        public string Name { get; set; }


        [MaxLength(20), NotNull]
        public string Socket { get; set; }

        [NotNull]
        public double Price { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
