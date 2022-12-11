using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HostelAPI.Model;

namespace HostelAPI.Data
{
    public class HostelAPIContext : DbContext
    {
        public HostelAPIContext (DbContextOptions<HostelAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HostelAPI.Model.User> User { get; set; } = default!;
    }
}
