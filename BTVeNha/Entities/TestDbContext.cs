
using BTVeNha.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTVeNha.Entities
{
    public class TestDbContext:DbContext
    {
        public TestDbContext():base("TestDbContext")
        {

        }
       DbSet<Customer> Customers { get; set; }
    }
}