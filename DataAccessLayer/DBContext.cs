﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBContext : DbContext
    {
        public DBContext(string connString) : base(connString)
        {
        }
    }
}
