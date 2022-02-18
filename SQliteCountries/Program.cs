using System;
using System.Data.SQLite;

namespace SQliteCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void ReadCountries()
        {
            Database databaseObj = new Database();
            string query = "SELECT Country.countryname AS Country, Capital.capitalname AS Capital JOIN Country ON Capital.countryid = Country.rowid ";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConenction();

            SQLiteDataReader data = myCommand.ExecuteReader();

            if(data.HasRows)
            {
                while (data.Read())
                {
                    Console.WriteLine($"Country; {data["Country"]}. Capital: {data["Capital"]}");
                }
            }
            databaseObj.CloseConnection();
               

        }
    }
}
