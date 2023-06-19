using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Login;
using MySql.Data.MySqlClient;
using main = HotelReservationSystem.MainWindow;

namespace HotelReservationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseConfig.DisableForeignKeyChecks();
            Application.Run(new LoginWindow());
        }
    }

    internal static class DatabaseConfig
    {
        public static void DisableForeignKeyChecks()
        {
            string _connection = Constants.MySqlConstants.Connection;
            string query = "SET GLOBAL FOREIGN_KEY_CHECKS = 0";
            MySqlConnection connection = new MySqlConnection(_connection);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();


        }
    }
}
