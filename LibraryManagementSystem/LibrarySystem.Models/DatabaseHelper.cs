using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Models {
    internal class DatabaseHelper {
        private static readonly string connectionString =
           "Server=localhost;Port=3308;Database=ark_db;Uid=root;Pwd=083107bdayko_;";

        public static MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }
    }
}
