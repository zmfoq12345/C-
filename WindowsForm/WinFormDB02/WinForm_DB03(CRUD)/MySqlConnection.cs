using System;
using System.Data;

namespace WinForm_DB03_CRUD_
{
    public class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}