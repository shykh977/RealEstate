using Microsoft.EntityFrameworkCore;
using System;
namespace PropertyBackend.DbConnect
{
    public class ContextCore : DbContext
    {
        public ContextCore(DbContextOptions<ContextCore> options) : base(options)
        {

        }
    }
}
