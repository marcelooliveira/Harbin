﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Harbin.Infrastructure.Database.Connection
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        Func<IDbConnection> _createConn;
        public DbConnectionFactory(Func<IDbConnection> createConn)
        {
            _createConn = createConn;
        }
        public IDbConnection CreateConnection()
        {
            return _createConn();
        }
    }
}
