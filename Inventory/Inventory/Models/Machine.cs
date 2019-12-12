using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Models
{
    [Table("Machine")]
   public  class Machine
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
