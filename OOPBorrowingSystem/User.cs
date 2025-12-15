using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBorrowingSystem
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }

        public int BorrowNumber { get; set; }
        public string BorrowedItems { get; set; }
        public string BorrowDate { get; set; }
        public bool Returned { get; set; }
    }
}
