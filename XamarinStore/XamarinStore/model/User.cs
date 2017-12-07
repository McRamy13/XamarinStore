using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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

        public static implicit operator Task<object>(User v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator User(ObservableCollection<User> v)
        {
            throw new NotImplementedException();
        }
    }
}
