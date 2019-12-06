using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Permissions;
using QueryManager;
using MusicApplication.Data;

namespace TestApp
{
    class Program
    {
        private static void TestCreateConcert(Query query)
        {
            Concert temp = new Concert("Test", "TestLocation", -1);
            query.CreateConcert(ref temp);

        }

        static void Main(string[] args)
        {
            Query testing = new Query("leia.cs.spu.edu", "wynns_db", "wynns", "wynns30$4410X");
            TestCreateConcert(testing);
        }
    }
}
