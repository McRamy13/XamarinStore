using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    [Table("User")]
    public class User
    {
        //properties
        [PrimaryKey,  Column("_codUser"), MaxLength(4), Unique]
        public string IdUser { get; set; }

        [MaxLength(50), NotNull, Unique]
        public string Nick { get; set; }

        [MaxLength(10), NotNull, Unique]
        public string Password { get; set; }

        [MaxLength(7), NotNull]
        public string Type { get; set; }

        
    }
}
