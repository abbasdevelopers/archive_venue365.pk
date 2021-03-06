﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace alainsoftech.core.Infrastructure.DbClient
{
    public interface IMySqlDbContext : ICloneable, IDisposable
    {
        MySqlConnection Connection { get; }
        MySqlTransaction Transaction { get; set; }
        bool TransactionEnabled { get; }
        string Host { get; }
        string Database { get; }
        void OpenConnection();
        void OpenConnection(bool beginTransaction);
        void CloseConnection();
        void CloseConnection(bool commitTransaction);
        void CommitTransaction();
        void RollbackTransaction();
    }
}
