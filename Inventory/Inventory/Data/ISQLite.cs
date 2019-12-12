using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetDBConnection();
    }
}
