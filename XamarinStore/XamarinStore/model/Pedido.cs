using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    [Table("Pedido")]
    public class Pedido
    {
        //properties
        [PrimaryKey, AutoIncrement, Column("_idPedido")]
        public int IdPedido { get; set; }

        [NotNull,MaxLength(4)]
        public string IdUser { get; set; }

        [NotNull]
        public int IdCase { get; set; }

        [NotNull]
        public int IdCpu { get; set; }

        [NotNull]
        public int IdGpu { get; set; }

        [NotNull]
        public int IdMotherBoard { get; set; }

        [NotNull]
        public int IdRam { get; set; }

        [NotNull]
        public double Price { get; set; }
    }
}
