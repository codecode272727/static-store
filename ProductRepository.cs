using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GetProduct
{
    public class ProductRepository
    {
        public class Product
        {
            public int Id {get;set;}
            public string Name {get;set;}
            public string Code {get;set;}
            public int Amount {get;set;}
            public decimal Price {get;set;}
        }

        private readonly string AZURE_CONN_STRING = Environment.GetEnvironmentVariable("AzureSQLConnectionString");
        
        public async Task GetProductData()
        {
            using var conn = new SqlConnection(AZURE_CONN_STRING);
            var queryResult = await conn.QuerySingleOrDefaultAsync<string>("SELECT * FROM Product WITH (NOLOCK)");
            var result = JArray.Parse(queryResult);
            return result;
        }
        
            
        
    }
}
