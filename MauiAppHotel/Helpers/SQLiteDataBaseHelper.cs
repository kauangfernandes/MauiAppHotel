/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

using SQLite;
using MauiAppHotel.Models;

namespace MauiAppHotel.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection __conn;

        public SQLiteDataBaseHelper(string path)
        {
            __conn = new SQLiteAsyncConnection(path);
            __conn.CreateTableAsync<Hospedagem>().Wait();
            __conn.CreateTableAsync<Quarto>().Wait();
        }
    }
}
