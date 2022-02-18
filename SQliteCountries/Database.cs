using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace SQliteCountries
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source = SQliteCountries.db");
        }

        public void OpenConenction()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }
        }
    }
}
