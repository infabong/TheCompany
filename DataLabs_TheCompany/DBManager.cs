﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataLabs_TheCompany
{   
    public class DBManager
    {
        public OleDbConnection Con;

        public void StartDB()
        {
            string ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; C: \Users\Datalabs Teacher\Source\Repos\TheCompany2\DataLabs_TheCompany\CompanyDatabase.accdb";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            Con.Open();

        }

    }
}