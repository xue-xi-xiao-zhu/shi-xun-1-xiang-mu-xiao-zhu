using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.Text;
using back_stage_management_.API.Model;

namespace back_stage_management.API.DAL
{
    public class GoodsContext : DbContext
    {
        public GoodsContext()
        {
        }

        public GoodsContext(DbContextOptions<GoodsContext> options)
                : base(options)
        {

        }

        public DbSet<Goods> Book { get; set; }
    }
}
